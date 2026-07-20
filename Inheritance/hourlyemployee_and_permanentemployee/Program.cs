using System;
interface IPayable
{
    void CalculatePay();
}
class Person
{
    public string FirstName;
    public string LastName;
    public string Email;
    public DateTime DateOfBirth;

    public Person(string firstName, string lastName, string email, DateTime dob)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        DateOfBirth = dob;
    }
}
class HourlyEmployee : Person, IPayable
{
    public double HoursWorked;
    public double PayPerHour;
    public double TotalPay;

    public HourlyEmployee(string firstName, string lastName, string email,
        DateTime dob, double hoursWorked, double payPerHour)
        : base(firstName, lastName, email, dob)
    {
        HoursWorked = hoursWorked;
        PayPerHour = payPerHour;
    }

    public void CalculatePay()
    {
        TotalPay = HoursWorked * PayPerHour;
    }

    public void Display()
    {
        Console.WriteLine("\n----- Hourly Employee -----");
        Console.WriteLine("Name       : " + FirstName + " " + LastName);
        Console.WriteLine("Hours      : " + HoursWorked);
        Console.WriteLine("Pay/Hour   : " + PayPerHour);
        Console.WriteLine("Total Pay  : " + TotalPay);
    }
}
class PermanentEmployee : Person, IPayable
{
    public double BasicSalary;
    public double HRA;
    public double DA;
    public double Tax;
    public double TotalPay;
    public double NetPay;

    public PermanentEmployee(string firstName, string lastName, string email,
        DateTime dob, double basicSalary)
        : base(firstName, lastName, email, dob)
    {
        BasicSalary = basicSalary;
    }

    public void CalculatePay()
    {
        HRA = BasicSalary * 0.15;
        DA = BasicSalary * 0.10;
        TotalPay = BasicSalary + HRA + DA;
        Tax = TotalPay * 0.08;
        NetPay = TotalPay - Tax;
    }

    public void Display()
    {
        Console.WriteLine("\n----- Permanent Employee -----");
        Console.WriteLine("Name       : " + FirstName + " " + LastName);
        Console.WriteLine("Basic      : " + BasicSalary);
        Console.WriteLine("HRA        : " + HRA);
        Console.WriteLine("DA         : " + DA);
        Console.WriteLine("Tax        : " + Tax);
        Console.WriteLine("Total Pay  : " + TotalPay);
        Console.WriteLine("Net Pay    : " + NetPay);
    }
}
class Program
{
    static void Main()
    {
        HourlyEmployee h = new HourlyEmployee(
            "Rahul",
            "Kumar",
            "rahul@gmail.com",
            new DateTime(2000, 5, 20),
            40,
            500);

        h.CalculatePay();
        h.Display();
        PermanentEmployee p = new PermanentEmployee(
            "Anita",
            "Sharma",
            "anita@gmail.com",
            new DateTime(1998, 8, 15),
            50000);

        p.CalculatePay();
        p.Display();
    }
}
