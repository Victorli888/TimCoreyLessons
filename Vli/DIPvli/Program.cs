using System;
using DemoLibrary;
namespace DIPvli
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson(); 
            owner.FirstName = "Victor";
            owner.LastName = "Li";
            owner.EmailAddress = "vli@msn.com";
            owner.PhoneNumber = "555-1234";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash.";
            chore.Owner = owner;
            
            
            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();
        }
    }
}
/* Dependency Inversion: High Level modules shouldn't depend on low level modules, instead both should depend on abstractions
 We've abstracted our methods to our Factory Class.
 
 Originally we would need to instantiate our classes Person and Chore for new objects.So,
 Our Program Depends on our Chore Class
 Our Chore Class depends on our Emailer Class
This dependency makes it hard to make changes in our code and ultimately forces us to make many changes in order to fit
our needs.

Now in our finished product you can see that if we needed to change the way we send our msg all we need to do is 
swap it in our abstracted class "Factory.cs"
ie Sending it by Carrier Pigeon, Send by Text, or sending it by email. There is no need to change our Chore Class in 
order to do this.
*/