using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OCPLibrary
{
    /// <summary>
    /// Create an account for the New Applicant using their first initial and last name
    /// Make sure this follows OCP Open for Extenstion but Closed for modification
    /// </summary>
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@fusefitness.com";
            output.IsExecutive = false;
            output.IsManager = false;

            return output;
        }
    
    }
}