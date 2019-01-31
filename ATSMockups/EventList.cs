using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATSMockups
{
    public class EventList : List<PromoEvent>, DevExpress.Data.IRelationList
    {
        public int RelationCount => 1;

        public IList GetDetailList(int index, int relationIndex)
        {
            SubEventList list = new SubEventList();

            SubEvent se = null;
            PromoEvent Current = this[index];
            se = new SubEvent()
            {
                AccountName = "Sub Account 1",
                BaseCases = 1000,
                PromoCases = 2000,
                ShipFromDate = Current.ShipFromDate,
                ShipToDate = Current.ShipToDate
            };
            list.Add(se);

            se = new SubEvent()
            {
                AccountName = "Sub Account 2",
                BaseCases = 1500,
                PromoCases = 2500,
                ShipFromDate = Current.ShipFromDate,
                ShipToDate = Current.ShipToDate
            };
            list.Add(se);

            se = new SubEvent()
            {
                AccountName = "Sub Account 3",
                BaseCases = 800,
                PromoCases = 2000,
                ShipFromDate = Current.ShipFromDate,
                ShipToDate = Current.ShipToDate
            };
            list.Add(se);

            se = new SubEvent()
            {
                AccountName = "Sub Account 4",
                BaseCases = 9000,
                PromoCases = 25000,
                ShipFromDate = Current.ShipFromDate,
                ShipToDate = Current.ShipToDate
            };
            list.Add(se);

            return list;
        }

        public string GetRelationName(int index, int relationIndex)
        {
            return "SubEvents";
        }

        public bool IsMasterRowEmpty(int index, int relationIndex)
        {
            return false;
        }
    }
}
