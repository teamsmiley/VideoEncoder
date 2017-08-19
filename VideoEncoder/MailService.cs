using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEncoderSample
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Sending email ...");
        }
    }
}
