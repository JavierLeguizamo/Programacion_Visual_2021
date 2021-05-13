
void setup() {
  pinMode(13,OUTPUT);
  Serial.begin(9600);
}

void loop() {
 
}

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    switch(inChar){
      case 'A':
        digitalWrite(13,HIGH);
        break;
      case 'B':
        digitalWrite(13,LOW);
        break;
      default:
        break;
    }
  }
}
