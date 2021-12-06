namespace OCPLibrary
{
    /// <summary>
    /// Class to get set Information of the Employee's FirstName, LastName, Email, Whether they are a Manager or Executive
    /// </summary>
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        /// <summary>
        /// Information on if this is a Manager or not, This is an extension of our Employee Model... Debate whether or not its a good idea to Violate OCP
        /// We can say this is okay because It's a minor change that doesn't effect or require changes to the our original program.cs file
        /// </summary>
        public bool IsManager { get; set; } = false;
        /// <summary>
        /// Means they are an Executive 
        /// </summary>
        public bool IsExecutive { get; set; } = false;
    }
}