using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errorCenter.Models
{
    public class ErrorFilter
    {
        public string environment { get; set; }
        public string order { get; set; }
        public string search { get; set; }
        public string searchValue { get; set; }
    }
}
