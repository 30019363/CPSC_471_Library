﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC_471_Library.Shared
{
    public class LibraryEvent
    {
        public string EventName { get; set; } = string.Empty;
        public int EventId { get; set; }
        // public DateTime EventDateTime { get; set; } 
        // location time and date, I think location we can pull from library
    }
}
