using System;
namespace LSPvli
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create CEO
            CEO ceo = new CEO();
            ceo.FirstName = "Chad";
            ceo.LastName = "Wilson";
            ceo.CalculatePerHourRate(1);

            // Create SQA Lead 
            Manager sqaLead = new Manager();
            sqaLead.FirstName = "Marcos";
            sqaLead.LastName = "Bagsby";
            sqaLead.AssignManager(ceo);
            sqaLead.CalculatePerHourRate(3);
            
            // Normal Employee
            Employee sqaEngineer = new Employee();
            sqaEngineer.FirstName = "Andrew";
            sqaEngineer.LastName = "Demonsharon";
            sqaEngineer.AssignManager(sqaLead);
            sqaEngineer.CalculatePerHourRate(2);
            
            Console.WriteLine($"{sqaEngineer.FirstName}'s Salary is {sqaEngineer.Salary}/hour.");
            sqaEngineer.FindManager();
            Console.WriteLine($"{sqaLead.FirstName}'s Salary is {sqaLead.Salary}/hour.");
            sqaLead.FindManager();
            Console.WriteLine($"{ceo.FirstName}'s Salary is {ceo.Salary}/hour.");
        }
    }
}

/*
The issue we run into is we have two objects that inherit from the same base class but when we go to implement them we find
that they can't be substituted with one another, because our class has conflicting functionality. We need to fix this
to make sure that our classes follow LSP and our interchangeable if they derive from the same base class.

We are doing are best to prevent unexpected behavior. if our Parent class is expected to work in one way and our child class
works in a different way this will cause problems.

The idea of an "IS A" Relationship. 
*/