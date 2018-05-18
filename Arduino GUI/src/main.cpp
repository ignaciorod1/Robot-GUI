#include <Arduino.h>

int data;
int val;
int ledPin = 9;
int potPin = A0;

void pot(int pin, int val){
  val = analogRead(potPin);
  val = map(val, 0, 1023, 0, 100);
  Serial.println(val);
}

void setup(){
    Serial.begin(14400);
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

  pot(potPin, val);

delay(50);
}
