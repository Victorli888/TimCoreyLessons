using System;

namespace DemoLibrary
{
    public class Emailer : IMsgSender
    {
        public void SendMessage(IPerson person, string msg)
        {
            Console.WriteLine($"Email sent to {person.EmailAddress}");
        }
    }
} 