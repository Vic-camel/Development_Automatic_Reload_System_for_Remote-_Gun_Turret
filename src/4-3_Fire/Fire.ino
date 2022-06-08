#define pwmMax 2200
#include <SPI.h>
#include <Ethernet.h>
#define pwmMin 800
#define pwmPin 9
#include <Servo.h>

Servo myservo;

byte mac[] = {
  0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };
IPAddress ip(192, 168, 0, 68);
//IPAddress myDns(192, 168, 1, 1);
//IPAddress gateway(192, 168, 1, 1);
IPAddress subnet(255, 255, 0, 0);

EthernetServer server(7000);
boolean alreadyConnected = false;

void setup()
{
    Serial.begin(9600);
    myservo.attach(9, 800, 2200); // 修正脈衝寬度範圍
    myservo.write(170); // 一開始先置中90度
    delay(3000);

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

void loop()
{
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
          client.println("Start firing");
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
            for(i = 800;i<801;i++)
            myservo.writeMicroseconds(i); 
            delay(1000);   
            Serial.println("Firing");  
            client.println("Start firing");

            myservo.writeMicroseconds(2200); 
            delay(100);
            Serial.println("1");   
          }
          
          server.write(thisChar);
          // echo the bytes to the server as well:
          Serial.write(thisChar);
          
      }
  }
  
}
