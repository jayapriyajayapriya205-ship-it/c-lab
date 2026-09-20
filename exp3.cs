using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal eats food.");
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks.");
    }
}
interface IPrintable
{
    void Print();
}

interface IShowable
{
    void Show();
}

class Student : IPrintable, IShowable
{
    public void Print()
    {
        Console.WriteLine("Student can print details.");
    }

    public void Show()
    {
        Console.WriteLine("Student can show details.");
    }
}
class Person
{
    public void DisplayPerson()
    {
        Console.WriteLine("This is a person.");
    }
}
class Employee : Person
{
    public void DisplayEmployee()
    {
        Console.WriteLine("This is an employee.");
    }
}
class Manager : Employee
{
    public void DisplayManager()
    {
        Console.WriteLine("This is a manager.");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("----- Single Inheritance -----");
        Dog d = new Dog();
        d.Eat();
        d.Bark();
        Console.WriteLine("\n----- Multiple Inheritance using Interfaces -----");
        Student s = new Student();
        s.Print();
        s.Show();
        Console.WriteLine("\n----- Multilevel Inheritance -----");
        Manager m = new Manager();
        m.DisplayPerson();
        m.DisplayEmployee();
        m.DisplayManager();
    }
}
