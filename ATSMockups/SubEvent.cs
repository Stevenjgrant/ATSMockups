using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATSMockups
{
    public class SubEvent
    {
        public string AccountName { get; set; }
        public DateTime ShipFromDate { get; set; }
        public DateTime ShipToDate { get; set; }
        public int BaseCases { get; set; }
        public int PromoCases { get; set; }

    }
}
