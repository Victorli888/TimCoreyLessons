using System;

namespace MoshEventsAndDelegates
{
    public class EmailMsgSender
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"Mail Service: Sending an Email... about {e.Video.Title}");
        }
    }
}