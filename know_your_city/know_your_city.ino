int catedrala = 3;
int huniade = 4;
int muzeu = 5;
int bastion = 2;
int optiune1 = 6;
int optiune2 = 7;


volatile boolean stareOptiune1=false;
volatile boolean stareOptiune2=false;
volatile boolean stareCatedrala=false;
volatile boolean stareHuniade=false;
volatile boolean stareMuzeu=false;
volatile boolean stareBastion=false;


void setup() {
  Serial.begin(9600);
  pinMode(catedrala, INPUT_PULLUP);
  pinMode(huniade, INPUT_PULLUP);
  pinMode(muzeu, INPUT_PULLUP);
  pinMode(bastion, INPUT_PULLUP);
  Serial.println("sdvdv");
  pinMode(optiune1, INPUT_PULLUP);
  pinMode(optiune2, INPUT_PULLUP);
}

void loop() {

  if(digitalRead(optiune1)==LOW)
  {
    stareOptiune1=true;
  }
  if(stareOptiune1==true)
  {
    Serial.println("optiune1");
    stareOptiune1=false;
    delay(500);
  }

  if(digitalRead(optiune2)==LOW)
  {
    stareOptiune2=true;
  }
  if(stareOptiune2==true)
  {
    Serial.println("optiune2");
    stareOptiune2=false;
    delay(500);
  }

  if(digitalRead(catedrala)==LOW)
  {
    stareCatedrala=true;
  }
  if(stareCatedrala==true)
  {
    Serial.println("catedrala");
    stareCatedrala=false;
    delay(500);
  }

  if(digitalRead(huniade)==LOW)
  {
    stareHuniade=true;
  }
  if(stareHuniade==true)
  {
    Serial.println("huniade");
    stareHuniade=false;
    delay(500);
  }

  if(digitalRead(muzeu)==LOW)
  {
    stareMuzeu=true;
  }
  if(stareMuzeu==true)
  {
    Serial.println("muzeu");
    stareMuzeu=false;
    delay(500);
  }

  if(digitalRead(bastion)==LOW)
  {
    stareBastion=true;
  }
  if(stareBastion==true)
  {
    Serial.println("bastion");
    stareBastion=false;
    delay(500);
  }
  }
  
  
  


  
