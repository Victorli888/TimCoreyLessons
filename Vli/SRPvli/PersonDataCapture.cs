using System;

namespace SRPvli
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            // Ask for User information
            Person output = new Person();
            
            Console.Write("What is your firstname:");
            output.FirstName = Console.ReadLine();
            
            Console.Write("What is your last name?");
            output.LastName = Console.ReadLine();
            return output;
        }
    }
}