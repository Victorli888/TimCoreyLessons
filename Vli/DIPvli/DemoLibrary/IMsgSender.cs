namespace DemoLibrary
{
    public interface IMsgSender
    {
        void SendMessage(IPerson person, string msg);
    }
}