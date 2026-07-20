using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter First Name: ");
            string first = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string last = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(last))
            {
                throw new Exception("Name cannot be empty.");
            }

            foreach (char c in first)
            {
                if (!char.IsLetter(c))
                    throw new Exception("First Name should contain only alphabets.");
            }

            foreach (char c in last)
            {
                if (!char.IsLetter(c))
                    throw new Exception("Last Name should contain only alphabets.");
            }

            Console.WriteLine("Valid Name.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
