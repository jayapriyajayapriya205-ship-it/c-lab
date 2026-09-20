using System;
delegate void Notify(string message);
class Student
{
    public string name;
    public event Notify StudentEvent;
    public Student(string studentName)
    {
        name = studentName;
    }
    public void CompleteTask()
    {
        Console.WriteLine("\n" + name + " completed the task.");
        StudentEvent?.Invoke("Task completed successfully.");
    }
}
class Program
{
    static void DisplayMessage(string message)
    {
        Console.WriteLine("Notification: " + message);
    }
    static void Main()
    {
        Console.WriteLine("----- Delegates and Events -----");
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();
        Student student = new Student(name);
        student.StudentEvent += DisplayMessage;
        student.CompleteTask();
    }
}