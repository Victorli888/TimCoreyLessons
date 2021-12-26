using System;
namespace LSPvli
{
    public class CEO : BaseEmployee, IManager 

    {
    public override void CalculatePerHourRate(int rank)
    {
        decimal baseAmount = 150M;
        Salary = baseAmount * rank;
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