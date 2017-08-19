using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEncoderSample
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending text message ..."+ args.Video.Title);
        }

        
    }
}
