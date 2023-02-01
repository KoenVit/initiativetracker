#include <Arduino.h>
#include "Adafruit_GFX.h"
#include "MCUFRIEND_kbv.h"

#include "Fonts/FreeSans12pt7b.h"

#define X_SIZE 240
#define Y_SIZE 400
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

void InitiativeScreen();
void SetTurns(String currentInitials, String initials1, String initials2, String initials3);
uint16_t* placeTextInCenter(const String &textBuf, uint16_t x, uint16_t y, uint8_t textSize, uint16_t textColor);
void SetTime(int seconds);
void ReadMessage();

void setup() 
{
  Serial.begin(9600);
  uint16_t ID = tft.readID();
  tft.begin(ID); 
  InitiativeScreen();
}

void loop() 
{
  ReadMessage();
}

void InitiativeScreen()
{
  tft.fillScreen(0x08A7);
  tft.fillRect(0, 337, X_SIZE, 63, WHITE);
  tft.drawFastHLine(0, 130, 240, WHITE);
}

void SetTurns(String currentInitials, String initials1, String initials2, String initials3)
{
  tft.setTextWrap(false);
  InitiativeScreen();
  placeTextInCenter(currentInitials, X_SIZE / 2, 150, 5, YELLOW);
  placeTextInCenter(initials1, X_SIZE / 2, 220, 3, WHITE);
  placeTextInCenter(initials2, X_SIZE / 2, 285, 3, WHITE);
  placeTextInCenter(initials3, X_SIZE / 2, 350, 3, WHITE);
}

void SetTime(int seconds)
{
  int minutes = seconds / 60;
  seconds %= 60;
  char timeString[10];
  sprintf(timeString, "%02d:%02d", minutes, seconds);
  placeTextInCenter(timeString, X_SIZE / 2, 398, 2, BLACK);
}

uint16_t* placeTextInCenter(const String &textBuf, uint16_t x, uint16_t y, uint8_t textSize, uint16_t textColor){
    int16_t x1, y1;
    static uint16_t size[2] = {0, 0};
    tft.setFont(&FreeSans12pt7b);
    tft.setTextSize(textSize);
    tft.setTextColor(textColor);
    tft.getTextBounds(textBuf, x, y, &x1, &y1, &size[0], &size[1]);
    tft.setCursor(x - size[0] / 2, y - size[1] / 2);
    tft.print(textBuf);
    return size;
}

void ReadMessage()
{
  static byte ndx = 0;

  char endMarker = '\n';
  char rc;
  const byte numChars = 32;
  char receivedChars[numChars];

  while (Serial.available() > 0)
  {
    rc = Serial.read();

    if (rc != endMarker)
    {
      receivedChars[ndx] = rc;
      ndx++;
      if (ndx >= numChars)
      {
        ndx = numChars - 1;
      }
    }
    else
    {
      receivedChars[ndx] = '\0';

      // Receive connection to program
      if (receivedChars[0] == 'C' && receivedChars[1] == '?' && receivedChars[2] == '\0')
      {
        Serial.println('@');
        SetTurns("KK", "MB", "DR", "JB");
        SetTime(9);
      }
      // Receive next turn command
      else if(receivedChars[0] == 'N' && receivedChars[1] == 'T' && receivedChars[2] == ':' && receivedChars[11] == '\0')
      {
        char turnOne[3];
        char turnTwo[3];
        char turnThree[3];
        char turnFour[3];
        for(int i = 0; i < 2; i++)
        {
          turnOne[i] = receivedChars[i+3];
        }
        for(int i = 0; i < 2; i++)
        {
          turnTwo[i] = receivedChars[i+5];
        }
        for(int i = 0; i < 2; i++)
        {
          turnThree[i] = receivedChars[i+7];
        }
        for(int i = 0; i < 2; i++)
        {
          turnFour[i] = receivedChars[i+9];
        }
        turnOne[2] = '\0';
        turnTwo[2] = '\0';
        turnThree[2] = '\0';
        turnFour[2] = '\0';
        SetTurns(String(turnOne), String(turnTwo), String(turnThree), String(turnFour));
        Serial.println("@");
      }

      ndx = 0;
    }
  }
}