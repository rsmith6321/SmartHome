int R = 9;
int G = 10;
int B = 11;
//int ledPin = 2;
int digitalPin = 8;
int val = 0;
void setup() {
  //  pinMode(ledPin, OUTPUT);  // sets the pin as output
  pinMode(digitalPin, INPUT); // sets the pin as input
  pinMode(R, OUTPUT);
  pinMode(G, OUTPUT);
  pinMode(B, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  val = digitalRead(digitalPin);  //อ่านค่าสัญญาณ digital ขา8 ที่ต่อกับเซ็นเซอร์
  Serial.print("val = "); // พิมพ์ข้อมความส่งเข้าคอมพิวเตอร์ "val = "
  Serial.println(val); // พิมพ์ค่าของตัวแปร val


  if (val == 1) { // ค่า เป็น 0  ตรวจจับเจอวัตถุ สั่งให้ไฟ LED ติด
    //    digitalWrite(ledPin, HIGH); // สั่งให้ LED ติดสว่าง
    // กำหนด LED สีแดง
    analogWrite(R, 255);
    analogWrite(G, 0);
    analogWrite(B, 0);
    delay(100);

    analogWrite(R, 0);
    analogWrite(G, 0255);
    analogWrite(B, 0);
    delay(100);

    analogWrite(R, 0);
    analogWrite(G, 0);
    analogWrite(B, 255);
    delay(100);

  }
  else {
    //    digitalWrite(ledPin, LOW); // สั่งให้ LED ดับ
    // กำหนด LED ดับ
    analogWrite(R, 0);
    analogWrite(G, 0);
    analogWrite(B, 0);
  }
  delay(100);
}
