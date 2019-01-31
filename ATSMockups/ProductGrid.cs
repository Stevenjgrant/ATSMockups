using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATSMockups
{
    public partial class ProductGrid : UserControl
    {
        public List<Product> Products = new List<Product>();
        public  List<ProductField> ProductFields { get; set; }

        public ProductGrid()
        {
            InitializeComponent();

            btnRebateCancel.SendToBack();
            btnRebateOK.SendToBack();

            cmbRebateType.SendToBack();
            lblRebateType.SendToBack();

            txtRebateName.SendToBack();
            lblRebateName.SendToBack();

            cmbFieldSelection.SendToBack();
            lblField.SendToBack();
            pnlSpacer.SendToBack();

            CreateData();
            grdProduct.DataSource = Products;
            grdProduct.RefreshDataSource();

            FillMeasureCombo();
        }

        void FillMeasureCombo()
        {
            cmbFieldSelection.Properties.Items.Clear();
            cmbFieldSelection.Properties.Items.Add(new ProductField(this.Rebate1, true));
            cmbFieldSelection.Properties.Items.Add(new ProductField(this.Rebate2, true));
            cmbFieldSelection.Properties.Items.Add(new ProductField(this.Rebate3, true));
            cmbFieldSelection.Properties.Items.Add(new ProductField(this.Rebate4, true));
            cmbFieldSelection.Properties.Items.Add(new ProductField(this.Rebate5, true));
            cmbFieldSelection.Properties.Items.Add(new ProductField(this.BaseCasePrice, false));
            cmbFieldSelection.Properties.Items.Add(new ProductField(this.PromoCasePrice, false));

            cmbFieldSelection.SelectedIndex = 0;
        }

        void CreateData()
        {
            Products.Add(new Product("ABC123", "Product ABC123", 12, (decimal)21.85));
            Products.Add(new Product("ABC125", "Product ABC125", 12, (decimal)21.85));
            Products.Add(new Product("ABC128", "Product ABC128", 12, (decimal)21.85));
            Products.Add(new Product("ABC131", "Product ABC131", 12, (decimal)21.85));

        }

        private void cmbFieldSelection_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        }

        private void btnRebateOK_Click(object sender, EventArgs e)
        {
            if (txtRebateName.Text.Trim() == "")
                return;

            ProductField f = cmbFieldSelection.SelectedItem as ProductField;
            if (f == null)
                return;
            f.SetRebateName(txtRebateName.Text.Trim());

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
            txtRebateName.Text = f.GridColumn.Caption;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            pnlProductAdd.Visible = true;
        }
    }
}
