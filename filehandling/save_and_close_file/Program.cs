using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "Student.txt";

        StreamWriter writer = new StreamWriter(path);

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your branch: ");
        string branch = Console.ReadLine();

        Console.Write("Enter your college: ");
        string college = Console.ReadLine();

        writer.WriteLine("Student Details");
        writer.WriteLine("----------------");
        writer.WriteLine("Name    : " + name);
        writer.WriteLine("Branch  : " + branch);
        writer.WriteLine("College : " + college);

        writer.Close();

        Console.WriteLine("File created successfully.");
        Console.WriteLine("Data written to Student.txt");
    }
}