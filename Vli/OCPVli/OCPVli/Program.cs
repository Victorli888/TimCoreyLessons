using System;
using System.Collections.Generic;
using OCPLibrary;

namespace OCPVli
{
    class Program
    {
        public static void Main(string[] args)
        {
            /// We have a list of applicants, but we want to extend our functionality to tell if they are Managers/Execs
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Andrew", LastName = "Le" },
                new ManagerModel { FirstName = "Yash", LastName = "Khade" },
                new ExecutiveModel { FirstName = "Peter", LastName = "Chin" },
                new EngineerModel {FirstName = "Brando", LastName = "Mando"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
          
            
            // Create List Employees from list of Applicants 
            foreach (var person in applicants)
            {
                // Use the Class instance of that person to create their appropiate account type.
                employees.Add(person.AccountProcessor.Create(person));
            }

            // Show Information of all employees in our employee list.
            foreach (var emp in employees)
            {
                Console.WriteLine(
                    $"{emp.FirstName}{emp.LastName}: {emp.EmailAddress} {emp.IsExecutive}, {emp.IsManager}");
            }
        }
    }
}


/* Notes:
With the Open Closed Principle we should be doing our best to reduce the risk of bugs when we introduce new functionality
to our code. Open to Extension but, Closed for modification

Instead of modifying our PersonModel to fit changes for new Employee types and opening the door for bugs to occur, we create an 
interface that creates the accounts that necessary for the applicant.

Using a single Class to handle all our accounts violates OCP and SRP
OCP Violation: Our Class would need to be modified everytime a new employee type is added
SRP Violation:  Our Class has more than one single Responsibility Actor that would give the need for change.

If instead we created new Classes for each new employee type then changes needed for that particular employee could be
extended without needing to modify the other classes containing other employee types

We also allow for our list of <PersonModel> to contain more than one Model, so now instead of changing the parameters in
each of our list of Applicants We simply change the type of Employee that they are.

*/