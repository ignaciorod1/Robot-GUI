#include <Arduino.h>

int data;
int ledPin = 9;

void setup(){
    Serial.begin(9600);
    pinMode(ledPin, OUTPUT);
}

void loop() {
  if(Serial.available())  {
    data = Serial.read();
    if (data == 'A')
      digitalWrite(ledPin, HIGH);
    else
      digitalWrite(ledPin, LOW);
  }
}
