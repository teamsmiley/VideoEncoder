using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEncoderSample
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MessageService: Sending text message ...");
        }

        
    }
}
