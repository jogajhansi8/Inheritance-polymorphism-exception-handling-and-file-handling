using System;

class Person
{
    public string FirstName;
    public string LastName;

    public Person(string firstName, string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new Exception("First Name cannot be empty.");

        if (string.IsNullOrWhiteSpace(lastName))
            throw new Exception("Last Name cannot be empty.");

        FirstName = firstName;
        LastName = lastName;
    }
}

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

            Person p = new Person(first, last);

            Console.WriteLine("Person Created Successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
