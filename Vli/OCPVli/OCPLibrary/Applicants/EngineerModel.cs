namespace OCPLibrary
{
    public class EngineerModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new EngineerAccounts();

    }
}