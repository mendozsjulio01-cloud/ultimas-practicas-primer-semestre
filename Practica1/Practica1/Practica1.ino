const int PIN_LED1 = 13;

void setup() {
  Serial.begin(9600);       
  pinMode(PIN_LED1, OUTPUT);
  Serial.println("Sistema iniciado. Envia E o F para controlar el LED.");
}

void loop() {
  if (Serial.available() > 0) {
    char LeerCaracter = Serial.read();   

    if (LeerCaracter == 'E') {
      digitalWrite(PIN_LED1, HIGH);
      Serial.println("LED ENCENDIDO");

    } else if (LeerCaracter == 'F') {
      digitalWrite(PIN_LED1, LOW);
      Serial.println("LED APAGADO");
    }
  }
}
