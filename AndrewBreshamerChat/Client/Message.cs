using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AndrewBreshamerChat.Client
{
    public class Message
    {
        public string User { get; set; }

        public string ActualMessage { get; set; }

        public DateTime TimeMessage { get; set; }

        public bool IsUser { get; set; }
    }
}
