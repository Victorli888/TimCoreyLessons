using System;
namespace LSPvli
{
    public class CEO : Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }

        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("The CEO has no manager");
        }

        public void GeneratePerformanceReview()
        {
            //Simulate someone doing Performance reviews
            Console.WriteLine("Hey I'm Doing reviews (CEO)");
            
        }

        public void FireEmployee()
        {
            Console.WriteLine("I'm sorry to say but You have been terminated from our Company.");
        }
    }
}