#include <LiquidCrystal.h>

String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
String commandString = "";

//int led1Pin = 2;
int R = 9;
int G = 10;
int B = 11;
int digitalPin = 8;
int val = 0;

boolean isConnected = false;

LiquidCrystal lcd(8,9,4,5,6,7); 


void setup() {
  
  Serial.begin(9600);
//  pinMode(led1Pin,OUTPUT);
  pinMode(R, OUTPUT);
  pinMode(G, OUTPUT);
  pinMode(B, OUTPUT);
  pinMode(digitalPin, INPUT);
  initDisplay();
}

void loop() {

  val = digitalRead(digitalPin);  //อ่านค่าสัญญาณ digital ขา8 ที่ต่อกับเซ็นเซอร์
  Serial.print("val = "); // พิมพ์ข้อมความส่งเข้าคอมพิวเตอร์ "val = "
  Serial.println(val); // พิมพ์ค่าของตัวแปร val
//  if (val == 1) { // ค่า เป็น 0  ตรวจจับเจอวัตถุ สั่งให้ไฟ LED ติด
//    digitalWrite(led1Pin, HIGH); // สั่งให้ LED ติดสว่าง
//  }
//  else {
//    digitalWrite(led1Pin, LOW); // สั่งให้ LED ดับ
//  }
//   delay(100);

  if(stringComplete)
  {
    stringComplete = false;
    getCommand();
    
    if(commandString.equals("STAR"))
    {
      lcd.clear();
    }
    if(commandString.equals("STOP"))
    {
//      turnLedOff(led1Pin);
      turnLedOff(R);
      turnLedOff(G);
      turnLedOff(B);
      lcd.clear();
      lcd.print("Ready to connect");    
    }
    else if(commandString.equals("LED1"))
    {
      boolean LedRedState = getLedRedState();
      
      if(LedRedState == true)
      {
//        turnLedOn(led1Pin);
         turnLedRedOn(R);
         turnLedRedOn(G);
         turnLedRedOn(B);
         
      }

      else{
//        turnLedOff(led1Pin);
         turnLedOff(R);
         turnLedOff(G);
         turnLedOff(B);
      }   
    }

    else if(commandString.equals("LED2"))
    {
      
      boolean LedGreenState = getLedGreenState();
      

       if(LedGreenState == true)
      {
//        turnLedOn(led1Pin);
         turnLedGreenOn(R);
         turnLedGreenOn(G);
         turnLedGreenOn(B);
         
      }

      else{
//        turnLedOff(led1Pin);
         turnLedOff(R);
         turnLedOff(G);
         turnLedOff(B);
      }   
    }

    else if(commandString.equals("LED3"))
    {
      
      boolean LedBlueState = getLedBlueState();
      

       if(LedBlueState == true)
      {
//        turnLedOn(led1Pin);
         turnLedBlueOn(R);
         turnLedBlueOn(G);
         turnLedBlueOn(B);
         
      }

      else{
//        turnLedOff(led1Pin);
         turnLedOff(R);
         turnLedOff(G);
         turnLedOff(B);
      }   
    }

    else if(commandString.equals("LED1")and commandString.equals("LED2"))
    {
      boolean LedRedState = getLedRedState();
      boolean LedGreenState = getLedGreenState();
      
      if(LedRedState == true and LedGreenState == true)
      {
//        turnLedOn(led1Pin);
         turnLedRedOn(R);
         turnLedGreenOn(G);
         turnLedRedOn(B);
         
      }

//      else{
////        turnLedOff(led1Pin);
//         turnLedOff(R);
//         turnLedOff(G);
//         turnLedOff(B);
//      }   
    }
    
    inputString = "";
  }
//  else {
//    digitalWrite(led1Pin, LOW); // สั่งให้ LED ดับ
//  }
//   delay(100);
}

void initDisplay()
{
  lcd.begin(16, 2);
  lcd.print("Ready to connect");
}

boolean getLedRedState()
{
  boolean state = false;
  if(inputString.substring(5,7).equals("ON"))
  {
    state = true;
  }else
  {
    state = false;
  }
  return state;
}

boolean getLedGreenState()
{
  boolean state = false;
  if(inputString.substring(5,7).equals("ON"))
  {
    state = true;
  }else
  {
    state = false;
  }
  return state;
}

boolean getLedBlueState()
{
  boolean state = false;
  if(inputString.substring(5,7).equals("ON"))
  {
    state = true;
  }else
  {
    state = false;
  }
  return state;
}

void getCommand()
{
  if(inputString.length()>0)
  {
     commandString = inputString.substring(1,5);
  }
}

void turnLedRedOn(int pin)
{
//  digitalWrite(pin,HIGH);
    analogWrite(R, 255);
    analogWrite(G, 0);
    analogWrite(B, 0);
    
}

void turnLedGreenOn(int pin)
{
//  digitalWrite(pin,HIGH);
    analogWrite(R, 0);
    analogWrite(G, 255);
    analogWrite(B, 0);
}

void turnLedBlueOn(int pin)
{
//  digitalWrite(pin,HIGH);
    analogWrite(R, 0);
    analogWrite(G, 0);
    analogWrite(B, 255);
}

void turnLedOff(int pin)
{
//  digitalWrite(pin,LOW);
    analogWrite(R, 0);
    analogWrite(G, 0);
    analogWrite(B, 0);
    
}

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}
