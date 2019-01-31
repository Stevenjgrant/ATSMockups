using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATSMockups
{
    public class PromoEvent
    {
        public SubEventList SubEvents { get; }
        public string EventName { get; set; }
        public DateTime ShipFromDate { get; set; }
        public DateTime ShipToDate { get; set; }
        public int BaseCases { get; set; }
        public int PromoCases { get; set; }

        public PromoEvent()
        {
            SubEvents = new SubEventList();
        }

    }
}
