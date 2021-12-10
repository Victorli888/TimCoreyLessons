using System;

namespace SRPvli
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            // Create username for the person
            Console.WriteLine($"UserName: {user.FirstName.Substring(0, 1)}J{user.LastName}");
        }
    }
}