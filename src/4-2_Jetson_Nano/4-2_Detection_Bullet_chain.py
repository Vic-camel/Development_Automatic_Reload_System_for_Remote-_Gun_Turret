import time ,cv2
import jetson.inference
import jetson.utils
import numpy as np

fps_av = 0
dispW = 640
dispH = 360
flip = 2
widthCam = 640
heightCam = 480

#camSet = 'nvarguscamerasrc !  video/x-raw(memory:NVMM), width=3264, height=2464, format=NV12, framerate=21/1 ! nvvidconv flip-method='+str(flip)+' ! video/x-raw, width='+str(dispW)+', height='+str(dispH)+', format=BGRx ! videoconvert ! video/x-raw, format=BGR ! appsink drop=true'
#camSet = 'nvarguscamerasrc wbmode=4 tnr-mode=2 tnr-strength=1 ee-mode=2 ee-strength=1 !  video/x-raw(memory:NVMM), width=3264, height=2464, format=NV12, framerate=21/1 ! nvvidconv flip-method='+str(flip)+' ! video/x-raw, width='+str(dispW)+', height='+str(dispH)+', format=BGRx ! videoconvert ! video/x-raw, format=BGR ! videobalance contrast=1.5 brightness=-0.2 saturation=1.2 ! appsink drop=true'
cam = cv2.VideoCapture('/dev/video0')
cam.set(cv2.CAP_PROP_FRAME_WIDTH,widthCam)
cam.set(cv2.CAP_PROP_FRAME_HEIGHT,heightCam)

font = cv2.FONT_HERSHEY_COMPLEX
net = jetson.inference.detectNet('ssd-mobilenet-v2',['--model=/home/vic/jetson-inference/python/training/detection/ssd/models/bullet_chain/ssd-mobilenet.onnx','--input_blob=input_0','--output-cvg=scores','--labels=/home/vic/jetson-inference/python/training/detection/ssd/models/bullet_chain/labels.txt','--output-bbox=boxes'],threshold=0.5)
timeStamp = time.time()
while True:
    _,img = cam.read()
    height = img.shape[0]
    width = img.shape[1] 
    frame = cv2.cvtColor(img,cv2.COLOR_BGR2RGBA).astype(np.float32)
    frame = jetson.utils.cudaFromNumpy(frame)
    detections = net.Detect(frame,width,height)
    for detect in detections:
        confidence = float(detect.Confidence)*100
        ID = detect.ClassID
        top = int(detect.Top)
        left = int(detect.Left)
        bottom = int(detect.Bottom)
        right = int(detect.Right)
        item = net.GetClassDesc(ID)
        cv2.rectangle(img,(left,top),(right,bottom),(0,255,0),2)
        cv2.rectangle(img,(left+4,top),(left+130,top+50),(0,255,255),-3)
        cv2.putText(img,item,(left+4,top+20),font,0.6,(0,0,255),2)
        cv2.putText(img,str(round(confidence,1))+"%",(left+4,top+47),font,0.6,(0,0,255),2)  
    dt = time.time() - timeStamp
    timeStamp = time.time()
    fps = 1/dt
    fps_av = 0.9*fps_av + 0.1*fps
    cv2.putText(img, str(round(fps_av,1))+' fps',(0,30),font,0.8,(0,255,255),2)
    cv2.imshow('detCam',img)
    cv2.moveWindow('detCam',0,0)
    if cv2.waitKey(1) == ord('q'):
        break
cam.release()
cv2.destroyAllWindows()


