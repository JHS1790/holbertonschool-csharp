using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int last_digit = number % 10;
        if (last_digit < 0)
            last_digit = last_digit * -1;
        Console.Write(last_digit);
        return (last_digit);
    }
}
