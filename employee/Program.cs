using System;
public class Employee
{
    static void getinfo()
    {
        int salary, hours;
        Console.WriteLine("Enter the following details of employee:");
        Console.Write("salary: $");
        salary = Convert.ToInt32(Console.ReadLine());
        Console.Write("number of working hours per day:");
        hours = Convert.ToInt32(Console.ReadLine());
        addsal(salary, hours);
    }
    static int addsal(int salary, int hours)
    {
        if (salary < 500)
        {
            salary += 10;
        }
        addwork(salary, hours);
        return salary;
    }
    static void addwork(int salary, int hours)
    {
        if (hours > 6)
            salary += 5;
        Console.WriteLine("the final salary of the employee is $ " + salary);
    }

    public static void Main()
    {
        getinfo();
    }
}