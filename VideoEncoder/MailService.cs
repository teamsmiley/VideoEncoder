using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEncoderSample
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending email ..." + args.Video.Title);
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
        
            }
           
        }
    }
}
