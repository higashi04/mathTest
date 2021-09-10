using System;

public class Suma 
{
    public static void Main(string [] args)
    {
        int numOne;
        int numTwo;
        int sum;
        Console.Write("Type first number: ");
        numOne = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type second number: ");
        numTwo = Convert.ToInt32(Console.ReadLine());
        sum = numOne + numTwo;
        Console.WriteLine("The sum equals {0}", sum);
    }
}