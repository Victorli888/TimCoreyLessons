using DemoLibrary;
using DemoLibrary.Properties;

namespace DIPvli
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMessageSender());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMsgSender CreateMessageSender()
        {
            return new SendByPigeon();
        }
    }
}