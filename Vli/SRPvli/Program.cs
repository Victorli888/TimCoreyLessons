namespace SRPvli
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StandardMessages.WelcomeMsg();
            // Instantiate our Person Object from our Person Class & Collect our User's information
            Person user = PersonDataCapture.Capture();
            
            // Validate the Inputs are valid 
            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApp();
                return; 
            }
            
            AccountGenerator.CreateAccount(user);
            
            StandardMessages.EndApp();
        }
    }
}

/* Single Responsibility Principle
* Our Classes should have a single Actor of responsiblity to change, if we have to change our classes for more than one
reason then our class is to broad and needs to focus up to a Single Responsibility. Tying in more than one functionality
in a single class makes our code hard to read, and leaves the possibility to break code when changes are required.

* Single Responsibility leaves our classes easier to maintain, Understand, and extend
*/