using System;
using FindMaxNum;
class program
{
    public static void Main(String[] args)
    {
        MaxNumber number = new MaxNumber();
        int actual = number.FindMaxInteger(1, 2, 3);
        Console.WriteLine(actual);
    }
}
