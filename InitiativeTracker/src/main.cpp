#include <Arduino.h>
#include "Adafruit_GFX.h"
#include "MCUFRIEND_kbv.h" 

#include "Fonts/FreeSans9pt7b.h"    // when you want other fonts
#include "Fonts/FreeSans12pt7b.h" // when you want other fonts
#include "Fonts/FreeSerif12pt7b.h" // when you want other fonts
#include "FreeDefaultFonts.h" // when you want other fonts 

#define BLACK 0x0000
#define NAVY 0x000F
#define DARKGREEN 0x03E0
#define DARKCYAN 0x03EF
#define MAROON 0x7800
#define PURPLE 0x780F
#define OLIVE 0x7BE0
#define LIGHTGREY 0xC618
#define DARKGREY 0x7BEF
#define BLUE 0x001F
#define GREEN 0x07E0
#define CYAN 0x07FF
#define RED 0xF800
#define MAGENTA 0xF81F
#define YELLOW 0xFFE0
#define WHITE 0xFFFF
#define ORANGE 0xFD20
#define GREENYELLOW 0xAFE5
#define PINK 0xF81F

MCUFRIEND_kbv tft(A3, A2, A1, A0, A4);  

void setup() {
  // put your setup code here, to run once:
  uint16_t ID = tft.readID();
  tft.begin(ID); 
  tft.setRotation(1);
  tft.fillScreen(BLACK);
  tft.setCursor(0,0);
  tft.setTextColor(GREEN);
  tft.setTextSize(10);
  tft.println("KK");
  tft.setCursor(300,0);
  tft.setTextSize(7);
  tft.setTextColor(RED);
  tft.println("M1");
  tft.setCursor(300,80);
  tft.println("M2");
  tft.setCursor(300,160);
  tft.println("M3");
}

void loop() {
  // put your main code here, to run repeatedly:
}