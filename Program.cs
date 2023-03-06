using System;
using DailyPlanner;

int a = 0;
int date = 1;
ConsoleKeyInfo key;

day d0 = new day();
day d1 = new day();
day d2 = new day();
day d3 = new day();
day d4 = new day();
day[] d = new day[5];

Days();
Meni();
Menu();

do
{
    keyy();
    if (key.Key == ConsoleKey.Enter)
    {
        body();
    }
    else
    {
        Meni();
        Menu();
    }
}
while (key.Key != ConsoleKey.Escape);

void Days()
    {
        d0.nam = "колледж";
        d0.desc = "пары: математика, ОАИП";
        d0.na1 = "дом";
        d0.des1 = "лежать на диване";
        d[0] = d0;
        d1.nam = "колледж";
        d1.desc = "пары: математика";
        d1.na1 = "дом";
        d1.des1 = "занялся чем-то полезным";
        d[1] = d1;
        d2.nam = "колледж";
        d2.desc = "пары: ОАИП";
        d2.na1 = "дом";
        d2.des1 = "лежать на диване";
        d[2] = d2;
        d3.nam = "коледж";
        d3.desc = "пары: математика, БЖД";
        d3.na1 = "дом";
        d3.des1 = "лежать на диване";
        d[3] = d3;
        d4.nam = "колледж";
        d4.desc = "пары: БЖД, ОАИП";
        d4.na1 = "дом";
        d4.des1 = "лежать на диване";
        d[4] = d4;
}
void Menu()
{
    if (date < 1)
    {
        date = 1;
    }
    if (date > 31)
    {
        date = 31;
    }
    if (date < 10)
    {
        Console.SetCursorPosition(0, 0);
        Console.Write("0");
        Console.Write(date);
        Console.Write(".10.2022");
    }
    else if (date >= 10)
    {
        Console.SetCursorPosition(0, 0);
        Console.Write(date);
        Console.Write(".10.2022");
    }
    if (date < 6)
    {
        Console.SetCursorPosition(2, 1);
        Console.Write("1 ");
        Console.Write(d[date - 1].nam);
        Console.SetCursorPosition(2, 2);
        Console.Write("2 ");
        Console.Write(d[date - 1].na1);
    }
}
void Meni()
{
    if (a < 0 || a > 1)
    { a = 0; }
    Console.Clear();
    Console.SetCursorPosition(0, a + 1);
    Console.WriteLine("->");
}
void keyy()
{
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.UpArrow)
    {
        a--;
    }
    if (key.Key == ConsoleKey.DownArrow)
    {
        a++;
    }
    if (key.Key == ConsoleKey.LeftArrow)
    {
        date--;
    }
    if (key.Key == ConsoleKey.RightArrow)
    {
        date++;
    }
}
void body()
{
    Console.Clear();
    if (a == 0)
    {

        Console.WriteLine(d[date - 1].nam);
        Console.WriteLine("--------------");
        Console.WriteLine("Описание:");
        Console.WriteLine(d[date - 1].desc);
        Console.Write("Дата:");
        Console.Write("0");
        Console.Write(date);
        Console.Write(".10.2022");
    }
    else
    {
        Console.WriteLine(d[date - 1].na1);
        Console.WriteLine("--------------");
        Console.WriteLine("Описание:");
        Console.WriteLine(d[date - 1].des1);
        Console.Write("Дата:");
        Console.Write("0");
        Console.Write(date);
        Console.Write(".10.2022");

    }
}



