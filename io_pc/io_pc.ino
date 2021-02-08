/*
 * IO
 * Created: 6/02/2021
 *  Author: moty22.co.uk
*/

unsigned char inByte=0, outByte=0;         //

// the setup function runs once when you press reset or power the board
void setup() {
    // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
    // initialize outputs 8-13 inputs 2-7 analogue A0-A3
  pinMode(8, OUTPUT);
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(13, OUTPUT);
  //comment next 6 lines if no pullup needed          
  pinMode(2, INPUT_PULLUP);
  pinMode(3, INPUT_PULLUP);
  pinMode(4, INPUT_PULLUP);
  pinMode(6, INPUT_PULLUP);
  pinMode(5, INPUT_PULLUP);
  pinMode(7, INPUT_PULLUP);

}

// the loop function runs over and over again forever
void loop() {
  unsigned char i;
  
   if (Serial.available() > 0) {
          // read the incoming byte:
      inByte = Serial.read();
      
      if(inByte < 127)
      {
        PORTB = inByte; //update digital outputs 8-13
      }
      if(inByte == 128) // request for update
      {
        Serial.write(lowByte(analogRead(A0)));  //send low byte of 10 bits analogue read
        Serial.write(highByte(analogRead(A0))); //send high byte of 10 bits analogue read
        Serial.write(lowByte(analogRead(A1)));
        Serial.write(highByte(analogRead(A1)));
        Serial.write(lowByte(analogRead(A2)));
        Serial.write(highByte(analogRead(A2)));
        Serial.write(lowByte(analogRead(A3)));
        Serial.write(highByte(analogRead(A3)));
          //read the 6 digital inputs 2-7 and put them in a byte
        for(i=0;i<6;i++){
        bitWrite(outByte, i, digitalRead(i+2)); 
        }
        Serial.write(outByte);
     }
   }
}
