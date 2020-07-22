﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubnubApi
{
    public class PNHistoryItemResult
    {
        public long Timetoken { get; set; }
        public object Entry { get; set; }
        public object Meta { get; set; }
        public object Actions { get; set; }
        public string Uuid { get; set; }
        public int MessageType { get; set; }
    }
}
