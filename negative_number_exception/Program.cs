using System;

class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0)
            {
                throw new NegativeNumberException("Marks cannot be negative.");
            }

            Console.WriteLine("Marks = " + marks);
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter only integer values.");
        }
    }
}
