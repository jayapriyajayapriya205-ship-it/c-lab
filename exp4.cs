using System;
class Number
{
    public int value;
    public Number(int v)
    {
        value = v;
    }
    public static Number operator -(Number n)
    {
        return new Number(-n.value);
    }
    public static Number operator +(Number n1, Number n2)
    {
        return new Number(n1.value + n2.value);
    }
    public void Display()
    {
        Console.WriteLine("Value = " + value);
    }
}
class Program
{
     static void Main()
    {
        Console.WriteLine("----- Operator Overloading -----");
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Number n1 = new Number(a);
        Number n2 = new Number(b);
        Number unaryResult = -n1;
        Number binaryResult = n1 + n2;
       Console.WriteLine("\nAfter Unary (-) Operator:");
        unaryResult.Display();
        Console.WriteLine("\nAfter Binary (+) Operator:");
        binaryResult.Display();
    }
}