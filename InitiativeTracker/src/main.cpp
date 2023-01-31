#include <Arduino.h>
#include "Adafruit_GFX.h"
#include "MCUFRIEND_kbv.h"

#include "Fonts/FreeSans9pt7b.h"
#include "Fonts/FreeSansOblique9pt7b.h"
#include "Fonts/FreeSans12pt7b.h"
#include "Fonts/FreeSerif12pt7b.h"
#include "FreeDefaultFonts.h"

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
int16_t x0, y0, x1, y1, x2, y2, x3, y3;
uint16_t w0, h0, w1, h1;

void InitiativeScreen();
void StartTimer();
void SetTurns(String currentInitials, String initials1, String initials2, String initials3);
uint16_t* placeTextInCenter(const String &textBuf, uint16_t x, uint16_t y, uint8_t textSize, uint16_t textColor);

void setup() 
{
  uint16_t ID = tft.readID();
  tft.begin(ID); 
  InitiativeScreen();
  /*tft.setRotation(1);
  tft.fillScreen(BLACK);
  tft.setCursor(0,0);
  tft.setTextColor(GREEN);
  tft.setTextSize(10);
  tft.println("KK");
  tft.setCursor(300,0);
  tft.setTextSize(7);
  tft.setTextColor(RED);
  tft.println("01");
  tft.setCursor(300,80);
  tft.println("02");
  tft.setTextColor(GREEN);
  tft.setCursor(300,160);
  tft.println("SB");*/
}

void loop() 
{

}

void InitiativeScreen()
{
  tft.fillScreen(0x08A7);
  tft.fillRect(0, 337, 240, 63, WHITE);
  tft.drawFastHLine(29, 130, 181, WHITE);
  SetTurns("KK", "MB", "DR", "JB");
}

void StartTimer()
{

}

void SetTurns(String currentInitials, String initials1, String initials2, String initials3)
{
  tft.setTextWrap(false);
  placeTextInCenter(currentInitials, 120, 79, 13, YELLOW);
  placeTextInCenter(initials1, 120, 172, 8, WHITE);
  placeTextInCenter(initials2, 120, 237, 8, WHITE);
  placeTextInCenter(initials3, 120, 302, 8, WHITE);
  placeTextInCenter("00:23", 120, 368, 4, BLACK);
}

uint16_t* placeTextInCenter(const String &textBuf, uint16_t x, uint16_t y, uint8_t textSize, uint16_t textColor){
    int16_t x1, y1;
    static uint16_t size[2] = {0, 0};
    //tft.setFont(&FreeSans12pt7b);
    tft.setTextSize(textSize);
    tft.setTextColor(textColor);
    tft.getTextBounds(textBuf, x, y, &x1, &y1, &size[0], &size[1]);
    tft.setCursor(x - size[0] / 2, y - size[1] / 2);
    tft.print(textBuf);
    return size;
}