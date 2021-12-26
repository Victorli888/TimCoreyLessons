using System;

namespace LSPvli
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;

        public virtual void AssignManager(IEmployee manager)
        {
            Manager = manager;
        }

        public void FindManager()
        {
            Console.WriteLine($"My Manager is {Manager.FirstName} {Manager.LastName}.");
        }
    }
}
