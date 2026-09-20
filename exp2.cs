using System;
class Student
{
    public int rollNo;
    public string name;
    public string department;
    public int age;
    public double marks;
    public void GetDetails()
    {
        Console.Write("Enter Roll Number: ");
        rollNo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Department: ");
        department = Console.ReadLine();
        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Marks: ");
        marks = Convert.ToDouble(Console.ReadLine());
    }
    public void DisplayDetails()
    {
        Console.WriteLine("\n----- Student Details -----");
        Console.WriteLine("Roll Number : " + rollNo);
        Console.WriteLine("Name        : " + name);
        Console.WriteLine("Department  : " + department);
        Console.WriteLine("Age         : " + age);
        Console.WriteLine("Marks       : " + marks);
    }
    public void CheckResult()
    {
        if (marks >= 50)
            Console.WriteLine("Result : Pass");
        else
            Console.WriteLine("Result : Fail");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.GetDetails();
        student1.DisplayDetails();
        student1.CheckResult();
    }
}
