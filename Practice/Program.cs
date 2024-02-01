

using System;

namespace Activity;

public class Math
{


public void add(int num1, int num2)
{
    Console.WriteLine("The sum of the two number: " + (num1 + num2));
}
public void multiply(int num1, int num2)
{
    Console.WriteLine("The multiply of the two number : " + (num1 * num2));
}
public void minus(int num1, int num2)
{
    Console.WriteLine("The minus of the two number: " + (num1 - num2));
}
public void divide(int num1, int num2)
{
    Console.WriteLine("The dived of the two number: " + (num1 / num2));
}

}

class Program
{
    static void Main (String[] args)
    {

        Math m = new Math();
        int num1, num2;
        Console.Write("Enter first number:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number:");
        num2 = Convert.ToInt32(Console.ReadLine());
        m.add(num1, num2);
        m.multiply(num1, num2);
        m.divide(num1, num2);
        m.minus(num1, num2);

    }


}


