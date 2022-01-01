using System;

namespace DemoLibrary
{
    public class SendByPigeon:IMsgSender
    {
        public void SendMessage(IPerson person, string msg)
        {
            Console.WriteLine($"I am sending a carrier pigeon to {person.FirstName} to say: {msg}");
        }
    }
}