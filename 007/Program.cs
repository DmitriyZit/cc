﻿Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;
int x = xa, y = xb;
int count = 0;
while(count < 10000)
{
int what = new Random().Next(0, 3);
}
int x = xa, y = xb;
int count = 0;
    while(count < 10)
    {
        int what = new Random().Next(0, 3);
        if (what == 0)
        {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
        }
    {
    int what = new Random().Next(0, 3);
        if (what == 0)
        {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
        }
        if (what == 1)
        {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
        }
        if (what == 2);
        {
        x = (x + xс) / 2;
        y = (y + yс) / 2;
        }
Console.Set.CursorPosition(x, y);
Console.WriteLine("+");
count++;
}}