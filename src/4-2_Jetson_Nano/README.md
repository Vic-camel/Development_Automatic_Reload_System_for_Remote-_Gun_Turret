# Jetson Nano

![image](https://user-images.githubusercontent.com/79196121/172728531-c276e906-85ff-4257-b0e3-47430f007527.png)
![](https://i.imgur.com/P385sbt.gif)

## 環境架設+使用
* <a href="https://hackmd.io/@Mrcamel/ByOT6teoF">linux指令</a>
* JetsonNano環境架設+功能應用介紹於<a href="https://github.com/dusty-nv/jetson-inference">官方介紹</a>學習
  * 
* Object detection<a href="https://hackmd.io/NasoNE1uRbar1bACno685w?view">實作開發過程</a>
  * pre-Trained model: SSD-Mobilenet-v1

## 開發過程
1. 選用辨識方式 --本實作選用 Object detection
2. 神經網路模型 -->本處選用 SSD-Mobilenet-v1
3. 蒐集訓練用樣本素材: 
注意拍照重點
物體在照片中的<b>明暗</b>、<b>位置</b>、<b>大小</b>
4. 匡列物體的形狀

## 硬體
* Jetson Nano 2GB開發板
* Webcam

# 未來與展望
* 辨識彈鍊姿態
