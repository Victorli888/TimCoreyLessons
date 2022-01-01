using System;

namespace DemoLibrary.Properties
{
    public class SendTextMsg:IMsgSender
    {
        public void SendMessage(IPerson person, string msg)
        {
            Console.WriteLine($"I am sending a text message to {person.FirstName} to say: {msg}");
        }
    }
}