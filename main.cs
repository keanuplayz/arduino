int switchState = 0;
void setup(){
  pinMode(2, INPUT);
  pinMode(3, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
}

void loop(){
  switchState = digitalRead(2);
  if (switchState == LOW) { // Button is not pressed
    digitalWrite(3, HIGH); // green LED
  	digitalWrite(4, LOW); // red LED
	  digitalWrite(5, LOW); // red LED
  } else { // Button is pressed
    digitalWrite(3, LOW);
  	digitalWrite(4, LOW);
  	digitalWrite(5, HIGH);
    
    delay(250); // wait for a quarter second

    // toggle the LEDs
  	digitalWrite(4, HIGH);
  	digitalWrite(5, LOW);
  	delay(250); // wait for a quarter second
  }
}
