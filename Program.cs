using System;

class Zadanie1
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę (od 0 do 9999): ");
        int userInput = int.Parse(Console.ReadLine());

        if (userInput >= 0 && userInput <= 9999)
        {
            if (userInput == 0)
            {
                Console.Write("zero");
            }
            else
            {
                int thousands = userInput / 1000;
                int hundreds = (userInput / 100) % 10;
                int tens = (userInput / 10) % 10;
                int ones = userInput % 10;

                if (thousands == 1)
                {
                    Console.Write("tysiąc ");
                }
                if (thousands > 2)
                {
                    Console.Write(GetOnes(thousands) + " tysiące ");
                }
                if (hundreds == 1)
                {
                    Console.Write("sto ");
                }
                if (hundreds == 2)
                {
                    Console.Write("dwieście ");
                }
                if (hundreds >= 3 && hundreds <= 4)
                {
                    Console.Write(GetOnes(hundreds) + "sta ");
                }
                if (hundreds >= 5)
                {
                    Console.Write(GetOnes(hundreds) + "set ");
                }

                if (tens > 1)
                {
                    Console.Write(GetTens(tens) + " ");
                }
                else if (tens == 1)
                {
                    Console.Write(GetTeens(ones) + " ");
                    return;
                }

                if (ones > 0 || userInput == 10)
                {
                    Console.Write(GetOnes(ones) + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("Podaj liczbę pomiędzy 0 a 9999.");
        }
    }

    static string GetOnes(int number)
    {
        switch (number)
        {
            case 1:
                return "jeden";
            case 2:
                return "dwa";
            case 3:
                return "trzy";
            case 4:
                return "cztery";
            case 5:
                return "pięć";
            case 6:
                return "sześć";
            case 7:
                return "siedem";
            case 8:
                return "osiem";
            case 9:
                return "dziewięć";
            default:
                return "";
        }
    }

    static string GetTens(int number)
    {
        switch (number)
        {
            case 2:
                return "dwadzieścia";
            case 3:
                return "trzydzieści";
            case 4:
                return "czterdzieści";
            case 5:
                return "pięćdziesiąt";
            case 6:
                return "sześćdziesiąt";
            case 7:
                return "siedemdziesiąt";
            case 8:
                return "osiemdziesiąt";
            case 9:
                return "dziewięćdziesiąt";
            default:
                return "";
        }
    }

    static string GetTeens(int number)
    {
        switch (number)
        {
            case 0:
                return "dziesięć";
            case 1:
                return "jedenaście";
            case 2:
                return "dwanaście";
            case 3:
                return "trzynaście";
            case 4:
                return "czternaście";
            case 5:
                return "piętnaście";
            case 6:
                return "szesnaście";
            case 7:
                return "siedemnaście";
            case 8:
                return "osiemnaście";
            case 9:
                return "dziewiętnaście";
            default:
                return "";
        }
    }
}

