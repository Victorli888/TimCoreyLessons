namespace DemoLibrary
{
    /// <summary>
    /// Our Chore class would be considered as a High Level Module since it depends on the other modules, In this case
    /// Those modules would be our Logger Class and Person Class
    /// </summary>
    public class Chore : IChore
    {
        private ILogger _logger;
        private IMsgSender _messageSender;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; set; }
        public bool Completed { get; private set; } = false;

        public Chore(ILogger logger, IMsgSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;

        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            Completed = true;

            Logger log = new Logger();
            log.Log($"Completed {ChoreName}");

            _messageSender.SendMessage(Owner,$"The chore {ChoreName} is complete.");
        }
    }
}