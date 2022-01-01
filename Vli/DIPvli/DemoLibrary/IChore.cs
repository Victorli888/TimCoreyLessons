namespace DemoLibrary
{
    public interface IChore
    {
        string ChoreName { get; set; }
        IPerson Owner { get; set; }
        double HoursWorked { get; set; }
        bool Completed { get; }
        void PerformedWork(double hours);
        void CompleteChore();
    }
}