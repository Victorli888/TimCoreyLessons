using System;

namespace MoshEventsAndDelegates
{
    /// <summary>
    /// Custom Class for our delgate incase we need to send more Information about the video being encoded
    /// </summary>
    public class VideoEventArgs:EventArgs
    {
        public Video Video { get; set; }   
    }
}