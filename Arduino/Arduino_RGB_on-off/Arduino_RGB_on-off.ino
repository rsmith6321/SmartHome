#include <LiquidCrystal.h>

String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
String commandString = "";

//int led1Pin = 2;
int R = 11;
int G = 12;
int B = 13;

int R2 = 8;
int G2 = 9;
int B2 = 10;

int R3 = 5;
int G3 = 6;
int B3 = 7;

int R4 = 2;
int G4 = 3;
int B4 = 4;

int digitalPin = 8;
int val = 0;

boolean isConnected = false;

LiquidCrystal lcd(8,9,4,5,6,7); 


void setup() {
  
  Serial.begin(9600);
  pinMode(R, OUTPUT);
  pinMode(G, OUTPUT);
  pinMode(B, OUTPUT);
  
  pinMode(R2, OUTPUT);
  pinMode(G2, OUTPUT);
  pinMode(B2, OUTPUT);
  
  pinMode(R3, OUTPUT);
  pinMode(G3, OUTPUT);
  pinMode(B3, OUTPUT);
  
  pinMode(R4, OUTPUT);
  pinMode(G4, OUTPUT);
  pinMode(B4, OUTPUT);
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
      turnLedOff(R);
      turnLedOff(G);
      turnLedOff(B);

      turnLedOff(R2);
      turnLedOff(G2);
      turnLedOff(B2);

      turnLedOff(R3);
      turnLedOff(G3);
      turnLedOff(B3);

      turnLedOff(R4);
      turnLedOff(G4);
      turnLedOff(B4);
     
      lcd.clear();
      lcd.print("Ready to connect");    
    }
    else if(commandString.equals("LED1"))
    {
      boolean LedRedState = getLedRedState();
      
      if(LedRedState == true)
      {
         turnLedRedOn(R);
         turnLedRedOn(G);
         turnLedRedOn(B);
         
      }

      else{
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
         turnLedGreenOn(R);
         turnLedGreenOn(G);
         turnLedGreenOn(B);
         
      }

      else{
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
         turnLedBlueOn(R);
         turnLedBlueOn(G);
         turnLedBlueOn(B);
         
      }

      else{
         turnLedOff(R);
         turnLedOff(G);
         turnLedOff(B);
      }   
    }

    else if(commandString.equals("LED5"))
    {
      
      boolean LedRedState = getLedRedState();
      
      if(LedRedState == true)
      {
         turnLedRedOn2(R2);
         turnLedRedOn2(G2);
         turnLedRedOn2(B2);
         
      }

      else{
         turnLedOff(R2);
         turnLedOff(G2);
         turnLedOff(B2);
      }   
      
    }

    else if(commandString.equals("LED6"))
    {
      
      boolean LedGreenState = getLedGreenState();
      
       if(LedGreenState == true)
      {
         turnLedGreenOn2(R2);
         turnLedGreenOn2(G2);
         turnLedGreenOn2(B2);
         
      }

      else{
         turnLedOff(R2);
         turnLedOff(G2);
         turnLedOff(B2);
      }   
      
    }

    else if(commandString.equals("LED7"))
    {
      
      boolean LedBlueState = getLedBlueState();
      
       if(LedBlueState == true)
      {
         turnLedBlueOn2(R2);
         turnLedBlueOn2(G2);
         turnLedBlueOn2(B2);
         
      }

      else{
         turnLedOff(R2);
         turnLedOff(G2);
         turnLedOff(B2);
      }   
      
    }

    else if(commandString.equals("LED9"))
    {
      
      boolean LedRedState = getLedRedState();
      
      if(LedRedState == true)
      {
         turnLedRedOn3(R3);
         turnLedRedOn3(G3);
         turnLedRedOn3(B3);
         
      }

      else{
         turnLedOff(R3);
         turnLedOff(G3);
         turnLedOff(B3);
      }   
      
    }

    else if(commandString.equals("LED10"))
    {
      
      boolean LedGreenState = getLedGreenState();
      
       if(LedGreenState == true)
      {
         turnLedGreenOn3(R3);
         turnLedGreenOn3(G3);
         turnLedGreenOn3(B3);
         
      }

      else{
         turnLedOff(R3);
         turnLedOff(G3);
         turnLedOff(B3);
      }   
      
    }

    else if(commandString.equals("LED11"))
    {
      
      boolean LedBlueState = getLedBlueState();
      
       if(LedBlueState == true)
      {
         turnLedBlueOn3(R3);
         turnLedBlueOn3(G3);
         turnLedBlueOn3(B3);
         
      }

      else{
         turnLedOff(R3);
         turnLedOff(G3);
         turnLedOff(B3);
      }   
      
    }

    else if(commandString.equals("LED13"))
    {
      
      boolean LedRedState = getLedRedState();
      
      if(LedRedState == true)
      {
         turnLedRedOn4(R4);
         turnLedRedOn4(G4);
         turnLedRedOn4(B4);
         
      }

      else{
         turnLedOff(R4);
         turnLedOff(G4);
         turnLedOff(B4);
      }   
      
    }

    else if(commandString.equals("LED14"))
    {
      
      boolean LedGreenState = getLedGreenState();
      
       if(LedGreenState == true)
      {
         turnLedGreenOn4(R4);
         turnLedGreenOn4(G4);
         turnLedGreenOn4(B4);
         
      }

      else{
         turnLedOff(R4);
         turnLedOff(G4);
         turnLedOff(B4);
      }   
      
    }

    else if(commandString.equals("LED15"))
    {
      
      boolean LedBlueState = getLedBlueState();
      
       if(LedBlueState == true)
      {
         turnLedBlueOn4(R4);
         turnLedBlueOn4(G4);
         turnLedBlueOn4(B4);
         
      }

      else{
         turnLedOff(R4);
         turnLedOff(G4);
         turnLedOff(B4);
      }   
      
    }

//    else if(commandString.equals("LED4"))
//    {
//      
//      boolean LedRGBState = getLedRGBState();
//      
//
//       if(LedRGBState == true)
//      {
//         turnLedRGBOn(R);
//         turnLedRGBOn(G);
//         turnLedRGBOn(B);
//         
//      }
//
//      else{
//         turnLedOff(R);
//         turnLedOff(G);
//         turnLedOff(B);
//      }   
//    }

    else if(commandString.equals("LED1")and commandString.equals("LED2"))
    {
      boolean LedRedState = getLedRedState();
      boolean LedGreenState = getLedGreenState();
      
      if(LedRedState == true and LedGreenState == true)
      {
////        turnLedOn(led1Pin);
         turnLedRedOn(R);
         turnLedGreenOn(G);
         turnLedRedOn(B);
         
      }

////      else{
//////        turnLedOff(led1Pin);
////         turnLedOff(R);
////         turnLedOff(G);
////         turnLedOff(B);
////      }   
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
  if(inputString.substring(5,7).equals("ON") || inputString.substring(6,8).equals("ON"))
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
  if(inputString.substring(5,7).equals("ON") || inputString.substring(6,8).equals("ON"))
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
  if(inputString.substring(5,7).equals("ON") || inputString.substring(6,8).equals("ON"))
  {
    state = true;
  }else
  {
    state = false;
  }
  return state;
}

boolean getLedRGBState()
{
  boolean state = false;
  if(inputString.substring(5,7).equals("ON") || inputString.substring(6,8).equals("ON"))
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
  if(inputString.substring(5,7).equals("ON"))
  {
     commandString = inputString.substring(1,5);
  }
  else if(inputString.substring(6,8).equals("ON"))
  {
     commandString = inputString.substring(1,6);
  }
}

void turnLedRedOn(int pin)
{
//  digitalWrite(pin,HIGH);    
    analogWrite(R, 255);
    analogWrite(G, 0);
    analogWrite(B, 0);
    
}
void turnLedRedOn2(int pin)
{
    analogWrite(R2, 255);
    analogWrite(G2, 0);
    analogWrite(B2, 0);    
}
void turnLedRedOn3(int pin)
{
    analogWrite(R3, 255);
    analogWrite(G3, 0);
    analogWrite(B3, 0);    
}
void turnLedRedOn4(int pin)
{
    analogWrite(R4, 255);
    analogWrite(G4, 0);
    analogWrite(B4, 0);    
}

void turnLedGreenOn(int pin)
{;
    analogWrite(R, 0);
    analogWrite(G, 255);
    analogWrite(B, 0);
}
void turnLedGreenOn2(int pin)
{
    analogWrite(R2, 0);
    analogWrite(G2, 255);
    analogWrite(B2, 0);
}
void turnLedGreenOn3(int pin)
{
    analogWrite(R3, 0);
    analogWrite(G3, 255);
    analogWrite(B3, 0);
}
void turnLedGreenOn4(int pin)
{
    analogWrite(R4, 0);
    analogWrite(G4, 255);
    analogWrite(B4, 0);
}

void turnLedBlueOn(int pin)
{
//  digitalWrite(pin,HIGH);
    analogWrite(R, 0);
    analogWrite(G, 0);
    analogWrite(B, 255);
}
void turnLedBlueOn2(int pin)
{
    analogWrite(R2, 0);
    analogWrite(G2, 0);
    analogWrite(B2, 255);
}
void turnLedBlueOn3(int pin)
{
    analogWrite(R3, 0);
    analogWrite(G3, 0);
    analogWrite(B3, 255);
}
void turnLedBlueOn4(int pin)
{
    analogWrite(R4, 0);
    analogWrite(G4, 0);
    analogWrite(B4, 255);
}

//void turnLedRGBOn(int pin)
//{
//  for(;;){
//    int i = 0;
//    int j = 0;
//    
//    for(i=0;i<=255;i++){
//              analogWrite(R, i);
//              analogWrite(G, 0);
//              analogWrite(B, 0);   
//              delay(10);
//        if(i==255){
//          for(j=255 ; j > 0 ; j--){
//              analogWrite(R, j);
//              analogWrite(G, 0);
//              analogWrite(B, 0);   
//              delay(10);        
//          }         
//        }
//      }
//
//      for(i=0;i<=255;i++){
//              analogWrite(R, 0);
//              analogWrite(G, i);
//              analogWrite(B, 0);   
//              delay(10);
//        if(i==255){
//          for(j=255 ; j > 0 ; j--){
//              analogWrite(R, 0);
//              analogWrite(G, j);
//              analogWrite(B, 0);   
//              delay(10);         
//          }         
//        }
//      }
//
//      for(i=0;i<=255;i++){
//              analogWrite(R, 0);
//              analogWrite(G, 0);
//              analogWrite(B, i);   
//              delay(10);
//        if(i==255){
//          for(j=255 ; j > 0 ; j--){
//              analogWrite(R, 0);
//              analogWrite(G, 0);
//              analogWrite(B, j);   
//              delay(10);         
//          }         
//        }
//      }
//  delay(10);
//  }
//}

void turnLedOff(int pin)
{
//  digitalWrite(pin,LOW);
    analogWrite(R, 0);
    analogWrite(G, 0);
    analogWrite(B, 0);

    analogWrite(R2, 0);
    analogWrite(G2, 0);
    analogWrite(B2, 0);

    analogWrite(R3, 0);
    analogWrite(G3, 0);
    analogWrite(B3, 0);

    analogWrite(R4, 0);
    analogWrite(G4, 0);
    analogWrite(B4, 0);
    
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
