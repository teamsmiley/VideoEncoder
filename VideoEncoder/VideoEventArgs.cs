﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEncoderSample
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
