using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Marks in Subject 1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks in Subject 2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks in Subject 3: ");
            int m3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nStudent Name : " + name);
            Console.WriteLine("Total Marks  : " + (m1 + m2 + m3));
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter integer values only.");
        }
    }
}
