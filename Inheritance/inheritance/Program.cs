using System;

class Person
{
    private string firstName;
    private string lastName;
    private string emailAddress;
    private DateTime dateOfBirth;

    public Person(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = emailAddress;
        this.dateOfBirth = dateOfBirth;
    }
    public bool IsAdult
    {
        get
        {
            return (DateTime.Now.Year - dateOfBirth.Year) >= 18;
        }
    }
    public string SunSign
    {
        get
        {
            int day = dateOfBirth.Day;
            int month = dateOfBirth.Month;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                return "Aries";
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                return "Taurus";
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
                return "Gemini";
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
                return "Cancer";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "Leo";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return "Virgo";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return "Libra";
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return "Scorpio";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return "Sagittarius";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                return "Capricorn";
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return "Aquarius";
            else
                return "Pisces";
        }
    }
    public bool IsBirthDay
    {
        get
        {
            return DateTime.Now.Day == dateOfBirth.Day &&
                   DateTime.Now.Month == dateOfBirth.Month;
        }
    }
    public string ScreenName
    {
        get
        {
            return firstName.ToLower() + lastName.ToLower() + dateOfBirth.ToString("ddMMyyyy");
        }
    }
}
class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, string emailAddress,
                    DateTime dateOfBirth, double salary)
        : base(firstName, lastName, emailAddress, dateOfBirth)
    {
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Date of Birth (dd/mm/yyyy): ");
        DateTime dob = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Enter Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee emp = new Employee(firstName, lastName, email, dob, salary);

        Console.WriteLine("\n------ Employee Details ------");
        Console.WriteLine("Salary      : " + emp.Salary);
        Console.WriteLine("Is Adult    : " + emp.IsAdult);
        Console.WriteLine("Sun Sign    : " + emp.SunSign);
        Console.WriteLine("Birthday    : " + emp.IsBirthDay);
        Console.WriteLine("Screen Name : " + emp.ScreenName);
    }
}
