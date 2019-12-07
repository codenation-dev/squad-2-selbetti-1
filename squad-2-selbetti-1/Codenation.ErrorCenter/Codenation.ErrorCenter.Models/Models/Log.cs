using System;
using System.Collections.Generic;
using System.Text;

namespace Codenation.ErrorCenter.Models
{
    public class Log
    {
        public int id { get; set; }
        public string description { get; set; }
        public string origin { get; set; }
        public string level { get; set; }
        public string log { get; set; }
        public string environment { get; set; }
        public int frequency { get; set; }
        public string date { get; set; }
        public bool isArchived { get; set; }
    }
}
