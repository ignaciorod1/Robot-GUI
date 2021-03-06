#include <Arduino.h>

int data;
int val;
int ledPin = 9;
int potPin = A0;

void setup(){
    Serial.begin(9600);
    pinMode(ledPin, OUTPUT);
}

void loop() {
  val = analogRead(potPin);
  val = map(val, 0, 1023, 0, 100);
  if(Serial.available())  {
    data = Serial.read();
    if (data == 'A')
      digitalWrite(ledPin, HIGH);
    else
      digitalWrite(ledPin, LOW);
  }
  Serial.println(val);

}
