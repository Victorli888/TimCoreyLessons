using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OCPLibrary
{
    /// <summary>
    /// Create an account for the New Engineer using their first initial and last name, with an Engineer email
    /// </summary>
    public class EngineerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@ffenginering.com";
            output.IsExecutive = false;
            output.IsManager = false;

            return output;
        }
    
    }
}