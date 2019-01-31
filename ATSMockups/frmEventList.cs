using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATSMockups
{
    public partial class frmEventList : Form
    {
        EventList MyEvents = new EventList();

        public frmEventList()
        {
            InitializeComponent();
            CreateData();
            grdEvents.DataSource = MyEvents;
            grdEvents.RefreshDataSource();
        }

        void CreateData()
        {
            PromoEvent e = null;
            e = new PromoEvent() { EventName = "My Event 1", ShipFromDate = new DateTime(2019, 7, 5), ShipToDate = new DateTime(2019, 7, 28), BaseCases = 456, PromoCases = 567 };
            MyEvents.Add(e);
            e = new PromoEvent() { EventName = "My Event 2", ShipFromDate = new DateTime(2019, 8, 5), ShipToDate = new DateTime(2019, 9, 3), BaseCases = 1234, PromoCases = 2345 };
            MyEvents.Add(e);
            e = new PromoEvent() { EventName = "My Event 3", ShipFromDate = new DateTime(2019, 9, 1), ShipToDate = new DateTime(2019, 9, 28), BaseCases = 9500, PromoCases = 35000 };
            MyEvents.Add(e);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEvent frm = new frmEvent();
            frm.ShowDialog(this);
        }
    }
}
