namespace LSPvli
{
    public abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + (rank * 2);
        }
    }
}

// using the abstract keyword in our class we protect our baseEmployee class by making sure that we can't directly instantiate it
// because our expectation in our code is that our Classes inherit from this base class so it should not be instantiated directly