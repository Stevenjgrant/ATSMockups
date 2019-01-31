using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATSMockups
{
    public class ProductField
    {
        public DevExpress.XtraGrid.Columns.GridColumn GridColumn { get; }
        private string rebateName;
        public bool IsRebate { get; }
        public RebateType RebateType { get; set; }

        public ProductField(DevExpress.XtraGrid.Columns.GridColumn GridColumn, bool IsRebate)
        {
            this.GridColumn = GridColumn;
            this.rebateName = GridColumn.Caption;
            this.IsRebate = IsRebate;
        }

        public override string ToString()
        {
            if (rebateName != GridColumn.Caption)
                return GridColumn.Caption + " [" + rebateName + "]";
            else
                return GridColumn.Caption;
        }

        public void SetRebateName(string NameToSet)
        {
            GridColumn.Caption = NameToSet;
            rebateName = NameToSet;
        }
    }

    
}
