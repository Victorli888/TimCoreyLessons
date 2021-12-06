using System;
namespace LSPvli
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create SQA Lead 
            Manager sqaLead = new Manager();
            sqaLead.FirstName = "Marcos";
            sqaLead.LastName = "Bagsby";
            sqaLead.CalculatePerHourRate(3);
            
            // Create CEO
            Employee emp = new CEO();
            emp.FirstName = "Chad";
            emp.LastName = "Wilson";
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s Salary is {emp.Salary}/hour.");
            Console.ReadLine();
        }
    }
}