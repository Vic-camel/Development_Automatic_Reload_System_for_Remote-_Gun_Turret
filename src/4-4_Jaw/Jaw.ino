#include <SPI.h>
#include <Ethernet.h>
#define pwmMax 1650
#define pwmMin 800
#define pwmPin 9
#include <Servo.h>

Servo myservo;
 
byte mac[] = {
  0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };
IPAddress ip(192, 168, 0, 96);
//IPAddress myDns(192, 168, 1, 1);
//IPAddress gateway(192, 168, 1, 1);
IPAddress subnet(255, 255, 0, 0);

EthernetServer server(7000);
boolean alreadyConnected = false;

void setup() {

  Serial.begin(9600);
  myservo.attach(9,pwmMin , pwmMax); // 修正脈衝寬度範圍
  myservo.write(90); // 一開始先置中90度
  delay(1000);
  
  Ethernet.begin(mac, ip, subnet);
  Serial.begin(9600);
   while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }

  if (Ethernet.hardwareStatus() == EthernetNoHardware) {
    Serial.println("Ethernet shield was not found.  Sorry, can't run without hardware. :(");
    while (true) {
      delay(1); // do nothing, no point running without Ethernet hardware
    }
  }
  if (Ethernet.linkStatus() == LinkOFF) {
    Serial.println("Ethernet cable is not connected.");
  }

  server.begin();

  Serial.print("Chat server address:");
  Serial.println(Ethernet.localIP());
}

void loop() {
  
  int d;
  int i;
  int k;
  
  EthernetClient client = server.available();

  if (client)
  {
      if (!alreadyConnected) {
          // clear out the input buffer:
          client.flush();
          Serial.println("We have a new client");
          client.println("Hello, client!");
          alreadyConnected = true;  
        }

      if (client.available() > 0)
      {
          // read the bytes incoming from the client:
          char thisChar = client.read();
          // echo the bytes back to the client:
          Serial.println();

          if(thisChar=='1')
          {
            for(i = pwmMin;i<(pwmMin+1);i++)
            myservo.writeMicroseconds(i); 
            delay(10);   
            Serial.println(1); 
      
            myservo.writeMicroseconds(pwmMin); 
            delay(100);
            Serial.println("開");
            //client.println("Start opening");
            
          }
          if (thisChar=='2')
          {
             for(i = pwmMax;i>(pwmMax-1);i--)
            myservo.writeMicroseconds(i); 
            delay(10);   
            Serial.println(2);
        
            myservo.writeMicroseconds(pwmMax); 
            delay(100);
            Serial.println("夾");
            //client.println("Start gripping");
          }
             
          server.write(thisChar);
          // echo the bytes to the server as well:
          Serial.write(thisChar);
          
      }
  }
}
