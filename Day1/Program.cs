using System;
public class program
{
    public static void Main() {
        int x, y, z, m, n, c;
        #region sum
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"the summtion is{x + y}");
        #endregion
        #region equations
        x = 1;
        y = 4;
        z = 6;
        Console.WriteLine(-x + y * z);
        x = 35;
        y = 5;
        z = 7;
        Console.WriteLine((x + y) % z);
        x = 14;
        y = -4;
        z = 6;
        m = 11;
        Console.WriteLine(x + y * z / m);
        x = 2;
        y = 15;
        z = 6;
        m = 1;
        n = 7;
        c = 2;
        Console.WriteLine(x + y / z * m - n % c);
        x = 10;
        z = (x++) + x;
        Console.WriteLine(z);
        #endregion
        #region compression
        x = 5;
        y = 4;
        z = 6;
        if (x > y && x > z)
        {
            Console.WriteLine($"the greater value{x}");
        }
        else if (y > z && y > x)
        {
            Console.WriteLine($"the greater value{y}");

        }
        else if (z > y && z > x)
        {
            Console.WriteLine($"the greater value{z}");

        }
        else
        {
            Console.WriteLine("the values arenot compareable or equals");
        }
        #endregion
        #region calculate age
        int year;
        int month;
        int day;
        do
        {
            Console.WriteLine("plz enter year :");
            year = Convert.ToInt32(Console.ReadLine());

        }
        while (year < 1900 || year > 2023);
        do
        {
            Console.WriteLine("plz enter month :");
            month = Convert.ToInt32(Console.ReadLine());
        }
        while (month < 1 || month > 12);
        if (month !=4 && month!= 6 && month!=9 && month !=11 && month!=2)
        {
            do
            {
                Console.WriteLine("plz enter day:");
                day = Convert.ToInt32(Console.ReadLine());
            }
            while (day < 1 || day > 31);
        }
        else if (month == 4|| month == 6|| month == 9 || month ==11)
        {
            do
            {
                Console.WriteLine("plz enter day:");
                day = Convert.ToInt32(Console.ReadLine());
            }
            while (day < 1 || day > 30);
        }
        else
        {
            if (year % 4 == 0)
            {
                do
                {
                    Console.WriteLine("plz enter day:");
                    day = Convert.ToInt32(Console.ReadLine());
                }
                while (day < 1 || day > 29);
            }
            else
            {
                do
                {
                    Console.WriteLine("plz enter day:");
                    day = Convert.ToInt32(Console.ReadLine());
                }
                while (day < 1 || day > 28);
            }
        }
        int yearnow = 2023;
        int monthnow = 10;
        int daynow = 7;

        if (monthnow < month)
        {
            monthnow += 12;
            yearnow -= 1;

        }
        if (daynow < day)
        {
            daynow += 30;
            monthnow -= 1;
        }
        Console.WriteLine($"you are {yearnow - year} years,{monthnow - month} months and {daynow - day} days");
          
        #endregion
    }
}