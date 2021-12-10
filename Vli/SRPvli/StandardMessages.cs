using System;

namespace SRPvli
{
    /// <summary>
    /// Standard Messages used through out the code
    /// </summary>
    public class StandardMessages
    {
        public static void WelcomeMsg()
        {
            Console.WriteLine("Welcome!!!!!");
        }

        public static void EndApp()
        {
            Console.Write("Press ENTER KEY to close");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"Error: {fieldName}");
        }
    }
}