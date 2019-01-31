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
    public partial class frmEvent : Form
    {
        List<ProductField> ProductFields = new List<ProductField>();
        public List<Product> Products = new List<Product>();
        List<RebateType> RebateTypes = new List<RebateType>();
        RebateType OIRebate, BBRebate, ScanRebate, OtherRebate;

        public frmEvent()
        {
            InitializeComponent();
            PlaceProductControls();
            LoadProductFields();
            treeList1.ExpandAll();
            trFinancials.ExpandAll();
            datOrderTo.EditValue = datOrderFrom.DateTime.AddDays((int)numDefaultEventLength.Value * 7);
        }

        private void PlaceProductControls()
        {
            btnRebateCancel.SendToBack();
            btnRebateOK.SendToBack();

            cmbRebateType.SendToBack();
            lblRebateType.SendToBack();

            txtRebateName.SendToBack();
            lblRebateName.SendToBack();

            cmbRebateType1.SendToBack();
            lblField.SendToBack();
            pnlSpacer.SendToBack();

            CreateProductData();
            grdProduct.DataSource = Products;
            grdProduct.RefreshDataSource();

            CreateMeasureData();
            FillMeasureCombo();
            InitRebateTypes();
            cmbRebateType.SelectedIndex = 0;
        }

        void InitRebateTypes()
        {
            RebateTypes.Clear();

            OIRebate = new RebateType("OI");
            RebateTypes.Add(OIRebate);
            BBRebate = new RebateType("BB");
            RebateTypes.Add(BBRebate);
            ScanRebate = new RebateType("Scan");
            RebateTypes.Add(ScanRebate);
            OtherRebate = new RebateType("Other");
            RebateTypes.Add(OtherRebate);

            List<DevExpress.XtraEditors.ComboBoxEdit> combos = new List<DevExpress.XtraEditors.ComboBoxEdit>();
            combos.AddRange(new DevExpress.XtraEditors.ComboBoxEdit[] { cmbRebateType, cmbRebateType1, cmbRebateType2, cmbRebateType3, cmbRebateType4, cmbRebateType5 });
            foreach (DevExpress.XtraEditors.ComboBoxEdit edit in combos)
            {
                edit.Properties.Items.Clear();
                foreach (RebateType rt in RebateTypes)
                    edit.Properties.Items.Add(rt);
                edit.SelectedIndex = 0;
            }
        }

        void CreateProductData()
        {
            Products.Add(new Product("ABC123", "Product ABC123", 12, (decimal)21.85));
            Products.Add(new Product("ABC125", "Product ABC125", 12, (decimal)21.85));
            Products.Add(new Product("ABC128", "Product ABC128", 12, (decimal)21.85));
            Products.Add(new Product("ABC131", "Product ABC131", 12, (decimal)21.85));
        }

        void CreateMeasureData()
        {
            ProductFields.Add(new ProductField(this.Rebate1, true));
            ProductFields.Add(new ProductField(this.Rebate2, true));
            ProductFields.Add(new ProductField(this.Rebate3, true));
            ProductFields.Add(new ProductField(this.Rebate4, true));
            ProductFields.Add(new ProductField(this.Rebate5, true));
            ProductFields.Add(new ProductField(this.BaseCasePrice, false));
            ProductFields.Add(new ProductField(this.PromoCasePrice, false));
        }

        void SetRebatesTab()
        {
            foreach (ProductField field in ProductFields)
            {
                if (field.GridColumn == this.Rebate1)
                {
                    txtRebateName1.Text = field.GridColumn.Caption;
                    //cmbRebateType1.SelectedItem = field.RebateType;
                    //cmbRebateType1.SelectedIndex = 0;
                    SelectRebateComboSelection(cmbRebateType1, field.RebateType);
                }
                else if (field.GridColumn == this.Rebate2)
                {
                    txtRebateName2.Text = field.GridColumn.Caption;
                    //cmbRebateType2.SelectedItem = field.RebateType;
                    SelectRebateComboSelection(cmbRebateType2, field.RebateType);
                }
                else if (field.GridColumn == this.Rebate3)
                {
                    txtRebateName3.Text = field.GridColumn.Caption;
                    //cmbRebateType3.SelectedItem = field.RebateType;
                    SelectRebateComboSelection(cmbRebateType3, field.RebateType);
                }
                else if (field.GridColumn == this.Rebate4)
                {
                    txtRebateName4.Text = field.GridColumn.Caption;
                    //cmbRebateType4.SelectedItem = field.RebateType;
                    SelectRebateComboSelection(cmbRebateType4, field.RebateType);
                }
                else if (field.GridColumn == this.Rebate5)
                {
                    txtRebateName5.Text = field.GridColumn.Caption;
                    //cmbRebateType5.SelectedItem = field.RebateType;
                    SelectRebateComboSelection(cmbRebateType5, field.RebateType);
                }
            }
            // rebate 1
            if (datRebateStart1.Tag.ToString() == "Unset")
            {
                if (cmbRebateType1.SelectedItem.ToString() == "Scan")
                    datRebateStart1.EditValue = datPerfFrom.EditValue;
                else
                    datRebateStart1.EditValue = datShipFrom.EditValue;
            }
            if (datRebateEnd1.Tag.ToString() == "Unset")
            {
                if (cmbRebateType1.SelectedItem.ToString() == "Scan")
                    datRebateEnd1.EditValue = datPerfTo.EditValue;
                else
                    datRebateEnd1.EditValue = datShipTo.EditValue;
            }

        }

        void SelectRebateComboSelection(DevExpress.XtraEditors.ComboBoxEdit control, RebateType rebateType)
        {
            if (rebateType == null)
                return;

            int i = 0;
            foreach (RebateType r in control.Properties.Items)
            {
                if (r.ToString() == rebateType.ToString())
                {
                    control.SelectedIndex = i;
                    return;
                }
                i++;
            }
        }

        void FillMeasureCombo()
        {
            int Index = cmbFieldSelection.SelectedIndex;

            cmbFieldSelection.Properties.Items.Clear();
            foreach (ProductField field in ProductFields)
            {
                cmbFieldSelection.Properties.Items.Add(field);
            }

            if (Index >= 0)
                cmbFieldSelection.SelectedIndex = Index;
            else
                cmbFieldSelection.SelectedIndex = 0;
        }


        private void LoadProductFields()
        {
            ProductFields.Add(new ProductField(this.Rebate1, true));
            ProductFields.Add(new ProductField(this.Rebate2, true));
            ProductFields.Add(new ProductField(this.Rebate3, true));
            ProductFields.Add(new ProductField(this.Rebate4, true));
            ProductFields.Add(new ProductField(this.Rebate5, true));
            ProductFields.Add(new ProductField(this.BaseCasePrice, false));
            ProductFields.Add(new ProductField(this.PromoCasePrice, false));
        }

        private void btnRebateOK_Click(object sender, EventArgs e)
        {
            if (txtRebateName.Text.Trim() == "")
                return;

            ProductField f = cmbFieldSelection.SelectedItem as ProductField;
            if (f == null)
                return;
            f.SetRebateName(txtRebateName.Text.Trim());
            f.RebateType = cmbRebateType.SelectedItem as RebateType;

            if (!f.GridColumn.Visible)
            {
                f.GridColumn.Visible = true;
                f.GridColumn.VisibleIndex = 4;
            }

            FillMeasureCombo();
            SetRebatesTab();
            pnlRebate.Visible = false;
        }

        private void btnRebateCancel_Click(object sender, EventArgs e)
        {
            pnlRebate.Visible = false;
        }

        private void btnApplyRate_Click(object sender, EventArgs e)
        {
            decimal dd = 0;
            bool success = false;

            success = decimal.TryParse(txtAmount.Text, out dd);
            if (!success)
                return;

            ProductField f = cmbFieldSelection.SelectedItem as ProductField;
            if (f == null)
                return;

            if (!f.GridColumn.Visible)
            {
                f.GridColumn.Visible = true;
                f.GridColumn.VisibleIndex = 4;
            }

            foreach (Product p in this.Products)
            {
                if (f.GridColumn == this.Rebate1)
                {
                    p.VarRebate1 = dd;
                    p.CalculatePromoPrice();
                }
                else if (f.GridColumn == this.Rebate2)
                {
                    p.VarRebate2 = dd;
                    p.CalculatePromoPrice();
                }
                else if (f.GridColumn == this.Rebate3)
                {
                    p.VarRebate3 = dd;
                    p.CalculatePromoPrice();
                }
                else if (f.GridColumn == this.Rebate4)
                {
                    p.VarRebate4 = dd;
                    p.CalculatePromoPrice();
                }
                else if (f.GridColumn == this.Rebate5)
                {
                    p.VarRebate5 = dd;
                    p.CalculatePromoPrice();
                }
                else if (f.GridColumn == this.BaseCasePrice)
                {
                    p.BaseCasePrice = dd;
                    p.CalculatePromoPrice();
                }
                else if (f.GridColumn == this.PromoCasePrice)
                    p.PromoCasePrice = dd;

            }
            grdProduct.RefreshDataSource();
        }

        private void btnRedefine_Click(object sender, EventArgs e)
        {
            pnlRebate.Visible = true;

            ProductField f = cmbFieldSelection.SelectedItem as ProductField;
            if (f == null)
                return;

            txtRebateName.Text = f.GridColumn.Caption;

        }

        private void cmbFieldSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductField f = cmbFieldSelection.SelectedItem as ProductField;
            if (f == null)
                return;
            btnRedefine.Enabled = f.IsRebate;
            txtRebateName.Text = f.GridColumn.Caption;
        }

        private void datOrderFrom_EditValueChanged(object sender, EventArgs e)
        {
            if (datOrderTo.Tag.ToString() == "Unset")
                datOrderTo.EditValue = datOrderFrom.DateTime.AddDays((int)numDefaultEventLength.Value * 7);

            if (datPerfFrom.Tag.ToString() == "Unset")
                datPerfFrom.EditValue = datOrderFrom.EditValue;

            if (datShipFrom.Tag.ToString() == "Unset")
                datShipFrom.EditValue = datOrderFrom.EditValue;

            if (datPerfTo.Tag.ToString() == "Unset")
                datPerfTo.EditValue = datOrderTo.EditValue;

            if (datShipTo.Tag.ToString() == "Unset")
                datShipTo.EditValue = datOrderTo.EditValue;

            datOrderFrom.Tag = "Set";
        }

        private void datOrderTo_EditValueChanged(object sender, EventArgs e)
        {
            if (datPerfTo.Tag.ToString() == "Unset")
                datPerfTo.EditValue = datOrderTo.EditValue;

            if (datShipTo.Tag.ToString() == "Unset")
                datShipTo.EditValue = datOrderTo.EditValue;

            datOrderTo.Tag = "Set";
        }

        private void datShipFrom_EditValueChanged(object sender, EventArgs e)
        {
            datShipFrom.Tag = "Set";
        }

        private void datPerfFrom_EditValueChanged(object sender, EventArgs e)
        {
            datPerfFrom.Tag = "Set";
        }

        private void datPerfTo_EditValueChanged(object sender, EventArgs e)
        {
            datPerfTo.Tag = "Set";
        }

        private void datShipTo_EditValueChanged(object sender, EventArgs e)
        {
            datShipTo.Tag = "Set";
        }

        private void datRebateEnd1_EditValueChanged(object sender, EventArgs e)
        {
            datRebateEnd1.Tag = "Set";
        }

        private void datRebateStart1_EditValueChanged(object sender, EventArgs e)
        {
            datRebateStart1.Tag = "Set";
        }

        private void datRebateStart2_EditValueChanged(object sender, EventArgs e)
        {
            datRebateStart2.Tag = "Set";
        }

        private void datRebateEnd2_EditValueChanged(object sender, EventArgs e)
        {
            datRebateEnd2.Tag = "Set";
        }

        private void datRebateStart3_EditValueChanged(object sender, EventArgs e)
        {
            datRebateStart3.Tag = "Set";
        }

        private void datRebateEnd3_EditValueChanged(object sender, EventArgs e)
        {
            datRebateEnd3.Tag = "Set";
        }

        private void datRebateStart4_EditValueChanged(object sender, EventArgs e)
        {
            datRebateStart4.Tag = "Set";
        }

        private void datRebateEnd4_EditValueChanged(object sender, EventArgs e)
        {
            datRebateEnd4.Tag = "Set";
        }

        private void datRebateStart5_EditValueChanged(object sender, EventArgs e)
        {
            datRebateStart5.Tag = "Set";
        }

        private void datRebateEnd5_EditValueChanged(object sender, EventArgs e)
        {
            datRebateEnd5.Tag = "Set";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            pnlProductAdd.Visible = true;
        }

        private void chkRebateDates1_CheckedChanged(object sender, EventArgs e)
        {
            pnlRebateDates1.Visible = chkRebateDates1.Checked;
            pnlRebateDates2.Visible = chkRebateDates2.Checked;
            pnlRebateDates3.Visible = chkRebateDates3.Checked;
            pnlRebateDates4.Visible = chkRebateDates4.Checked;
            pnlRebateDates5.Visible = chkRebateDates5.Checked;
        }

        private void chkShowDates_CheckedChanged(object sender, EventArgs e)
        {
            pnlOrderDates.Visible = chkShowOrderDates.Checked;
            pnlShipDates.Visible = chkShowShipDates.Checked;
            pnlPerfDates.Visible = chkShowPerfDates.Checked;
        }
    }

}
