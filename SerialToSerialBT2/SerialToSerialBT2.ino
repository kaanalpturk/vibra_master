
#include "BluetoothSerial.h"
#include <EEPROM.h>
#if !defined(CONFIG_BT_ENABLED) || !defined(CONFIG_BLUEDROID_ENABLED)
#error Bluetooth is not enabled! Please run `make menuconfig` to and enable it
#endif

#if !defined(CONFIG_BT_SPP_ENABLED)
#error Serial Bluetooth not available or not enabled. It is only available for the ESP32 chip.
#endif

BluetoothSerial SerialBT;

const int sensorMin = 0; // sensor maksimum
const int sensorMax = 4095; 
int address[12] = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

int m1_d=0;
int m2_d=0;
int m3_d=0;
int m4_d=0;


int m1_b=0;
int m2_b=0;
int m3_b=0;
int m4_b=0;

int m1_bt=0;
int m2_bt=0;
int m3_bt=0;
int m4_bt=0;

int m1_dt=0;
int m2_dt=0;
int m3_dt=0;
int m4_dt=0;

bool k1=false;
bool k2=false;
bool k3=false;
bool k4=false;

char datas[12];
char readParam;
void setup() {
  Serial.begin(9600);
  EEPROM.begin(48);
  SerialBT.begin("ESP32test"); //Bluetooth device name
  Serial.println("The device started, now you can pair it with bluetooth!");
  
  EEPROM.get(0, readParam);
  if(readParam!=NULL){
    int eepindex=0;
    for(eepindex=0;eepindex<12;eepindex++)
    {
      EEPROM.get(address[eepindex], datas[eepindex]);
      Serial.print(datas[eepindex]);
    }
  }
  else
  {
    int eepindex=0;
    for(eepindex=0;eepindex<12;eepindex++)
    {
      datas[eepindex]='9';
    }  
  }
  //motor1
  pinMode(22, OUTPUT);
  pinMode(23, OUTPUT);
  //motor2
  pinMode(26, OUTPUT);
  pinMode(27, OUTPUT);
  //motor3
  pinMode(32, OUTPUT);
  pinMode(33, OUTPUT);
  //motor4
  pinMode(14, OUTPUT);
  pinMode(12, OUTPUT);

  veriGeldi();
  
}
void veriGeldi()
{
  int aaa=millis();
  m1_dt=aaa;
  m2_dt=aaa;
  m3_dt=aaa;
  m4_dt=aaa;

  m1_bt=aaa;
  m2_bt=aaa;
  m3_bt=aaa;
  m4_bt=aaa;
}

void m1_run()
{
  if(millis() - m1_bt < m1_b)
  {
    digitalWrite(22,LOW);
    digitalWrite(23,LOW);
    k1=false;
  }
  else
  { 
    if(k1==false)
    {
      m1_dt=millis();
      k1=true;
    }
    if(millis() - m1_dt < m1_d)
    {
      digitalWrite(22,HIGH);
      digitalWrite(23,LOW);
    }
    else
    {
      if(millis()>=m1_dt+(m1_d*2))
        {
          m1_dt=millis();
        }
      digitalWrite(22,LOW);
      digitalWrite(23,LOW);
    }
  }
  
}
void m2_run()
{
  if(millis() - m2_bt < m2_b)
  {
    digitalWrite(26,LOW);
    digitalWrite(27,LOW);
    k2=false;
  }
  else
  {  
    if(k2==false)
    {
      m2_dt=millis();
      k2=true;
    }
    if(millis() - m2_dt < m2_d)
    {
      digitalWrite(26,HIGH);
      digitalWrite(27,LOW);
    }
    else
    {
      if(millis()>=m2_dt+(m2_d*2))
        {
          m2_dt=millis();
        }
      digitalWrite(26,LOW);
      digitalWrite(27,LOW);
    }
  }
}
void m3_run()
{
  if(millis() - m3_bt < m3_b)
  {
    digitalWrite(32,LOW);
    digitalWrite(33,LOW);
    k3=false;
  }
  else
  {  
    if(k3==false)
    {
      m3_dt=millis();
      k3=true;
    }
    if(millis() - m3_dt < m3_d)
    {
        digitalWrite(32,HIGH);
        digitalWrite(33,LOW);
    }
    else
    {
        if(millis()>=m3_dt+(m3_d*2))
        {
          m3_dt=millis();
        }
        digitalWrite(32,LOW);
        digitalWrite(33,LOW);
    }
  }
}
void m4_run()
{
  if(millis() - m4_bt < m4_b)
  {
    digitalWrite(14,LOW);
    digitalWrite(12,LOW);
    k4=false;
  }
  else
  {  
    if(k4==false)
    {
      m4_dt=millis();
      k4=true;
    }
    if(millis() - m4_dt < m4_d)
    {
        digitalWrite(14,HIGH);
        digitalWrite(12,LOW);
    }
    else
    {
       if(millis()>=m4_dt+(m4_d*2))
        {
          m4_dt=millis();
        }     
        digitalWrite(14,LOW);
        digitalWrite(12,LOW);
    }
  }
}

int i=0;
void loop() {
  while(SerialBT.available()) {
   char a=SerialBT.read();
   datas[i]=a;
   //Serial.print(datas[i]);
   if(datas[i]!=NULL)
   {EEPROM.write(i, a);}
   i=i+1;
   if(i==12)
   {
    i=0;
    EEPROM.commit();
    veriGeldi();
    break;
   }
  }
  int eepindex=0;
    for(eepindex=0;eepindex<12;eepindex++)
    {
      EEPROM.get(address[eepindex], datas[eepindex]);
      //Serial.print(datas[eepindex]);
    }
    //Serial.print("\n");
    /*int sensorReading = analogRead(A0);
    //int range = map(sensorReading, sensorMin, sensorMax, 0, 1024);
    Serial.println(sensorReading);*/
  if(datas[0]!='9')
  {
     if(datas[1]=='0')
     {
      m1_d=1000000;
     }
     else if(datas[1]=='1')
     {
      m1_d=1000;
     }
     else if(datas[1]=='2')
     {
      m1_d=2000;
     }
     else if(datas[1]=='3')
     {
      m1_d=3000;
     }
     //*******************************
     if(datas[2]=='0')
     {
      m1_b=0;
     }
     else if(datas[2]=='1')
     {
      m1_b=1000;
     }
     else if(datas[2]=='2')
     {
      m1_b=2000;
     }
     else if(datas[2]=='3')
     {
      m1_b=3000;
     }
     m1_run();
  }
  else
  {
    digitalWrite(22,LOW);
    digitalWrite(23,LOW);
  }
  if(datas[3]!='9')
  {
     if(datas[4]=='0')
     {
      m2_d=1000000;
     }
     else if(datas[4]=='1')
     {
      m2_d=1000;
     }
     else if(datas[4]=='2')
     {
      m2_d=2000;
     }
     else if(datas[4]=='3')
     {
      m2_d=3000;
     }
     //*******************************
     if(datas[5]=='0')
     {
      m2_b=0;
     }
     else if(datas[5]=='1')
     {
      m2_b=1000;
     }
     else if(datas[5]=='2')
     {
      m2_b=2000;
     }
     else if(datas[5]=='3')
     {
      m2_b=3000;
     }
     m2_run();
  }
  else
  {
    digitalWrite(26,LOW);
    digitalWrite(27,LOW);
  }
  if(datas[6]!='9')
  {
     if(datas[7]=='0')
     {
      m3_d=1000000;
     }
     else if(datas[7]=='1')
     {
      m3_d=1000;
     }
     else if(datas[7]=='2')
     {
      m3_d=2000;
     }
     else if(datas[7]=='3')
     {
      m3_d=3000;
     }
     //*******************************
     if(datas[8]=='0')
     {
      m3_b=0;
     }
     else if(datas[8]=='1')
     {
      m3_b=1000;
     }
     else if(datas[8]=='2')
     {
      m3_b=2000;
     }
     else if(datas[8]=='3')
     {
      m3_b=3000;
     }
     m3_run();
  }
  else
  {
    digitalWrite(32,LOW);
    digitalWrite(33,LOW);
  }
  if(datas[9]!='9')
  {
     if(datas[10]=='0')
     {
      m4_d=1000000;
     }
     else if(datas[10]=='1')
     {
      m4_d=1000;
     }
     else if(datas[10]=='2')
     {
      m4_d=2000;
     }
     else if(datas[10]=='3')
     {
      m4_d=3000;
     }
     //*******************************
     if(datas[11]=='0')
     {
      m4_b=0;
     }
     else if(datas[11]=='1')
     {
      m4_b=1000;
     }
     else if(datas[11]=='2')
     {
      m4_b=2000;
     }
     else if(datas[11]=='3')
     {
      m4_b=3000;
     }
     m4_run();
  }
  else
  {
    digitalWrite(14,LOW);
    digitalWrite(12,LOW);
  }
}
