namespace ATSMockups
{
    partial class ProductGrid
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductGrid));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SimpleContextButton simpleContextButton1 = new DevExpress.Utils.SimpleContextButton();
            this.grdProduct = new DevExpress.XtraGrid.GridControl();
            this.grvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Included = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BaseCasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Rebate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rebate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rebate3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rebate4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rebate5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PromoCasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlFactor = new System.Windows.Forms.Panel();
            this.btnApplyRate = new DevExpress.XtraEditors.SimpleButton();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnRedefine = new DevExpress.XtraEditors.SimpleButton();
            this.cmbFieldSelection = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblField = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlRebate = new System.Windows.Forms.Panel();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.btnRebateCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRebateOK = new DevExpress.XtraEditors.SimpleButton();
            this.lblRebateType = new System.Windows.Forms.Label();
            this.cmbRebateType = new System.Windows.Forms.ComboBox();
            this.lblRebateName = new System.Windows.Forms.Label();
            this.txtRebateName = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlProductEdit = new System.Windows.Forms.Panel();
            this.pnlProductAdd = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblFindCode = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txtSearchCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnRemoveProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProduct = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.pnlFactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFieldSelection.Properties)).BeginInit();
            this.pnlRebate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlProductEdit.SuspendLayout();
            this.pnlProductAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProduct
            // 
            this.grdProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduct.Location = new System.Drawing.Point(0, 57);
            this.grdProduct.MainView = this.grvProduct;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1});
            this.grdProduct.Size = new System.Drawing.Size(1274, 390);
            this.grdProduct.TabIndex = 0;
            this.grdProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvProduct});
            // 
            // grvProduct
            // 
            this.grvProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Included,
            this.Code,
            this.ProductName,
            this.BaseCasePrice,
            this.Rebate1,
            this.Rebate2,
            this.Rebate3,
            this.Rebate4,
            this.Rebate5,
            this.PromoCasePrice});
            this.grvProduct.GridControl = this.grdProduct;
            this.grvProduct.Name = "grvProduct";
            this.grvProduct.OptionsView.ShowGroupPanel = false;
            this.grvProduct.OptionsView.ShowIndicator = false;
            // 
            // Included
            // 
            this.Included.Caption = "Included";
            this.Included.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Included.FieldName = "Included";
            this.Included.MinWidth = 35;
            this.Included.Name = "Included";
            this.Included.Visible = true;
            this.Included.VisibleIndex = 0;
            this.Included.Width = 92;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // Code
            // 
            this.Code.Caption = "Code";
            this.Code.FieldName = "Code";
            this.Code.MinWidth = 35;
            this.Code.Name = "Code";
            this.Code.OptionsColumn.AllowEdit = false;
            this.Code.Visible = true;
            this.Code.VisibleIndex = 1;
            this.Code.Width = 109;
            // 
            // ProductName
            // 
            this.ProductName.Caption = "Description";
            this.ProductName.FieldName = "Name";
            this.ProductName.MinWidth = 35;
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.AllowEdit = false;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 2;
            this.ProductName.Width = 436;
            // 
            // BaseCasePrice
            // 
            this.BaseCasePrice.Caption = "Base Case Price";
            this.BaseCasePrice.ColumnEdit = this.repositoryItemTextEdit1;
            this.BaseCasePrice.FieldName = "BaseCasePrice";
            this.BaseCasePrice.MinWidth = 35;
            this.BaseCasePrice.Name = "BaseCasePrice";
            this.BaseCasePrice.Visible = true;
            this.BaseCasePrice.VisibleIndex = 3;
            this.BaseCasePrice.Width = 174;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "C2";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "<Enter a Value>";
            // 
            // Rebate1
            // 
            this.Rebate1.Caption = "Rebate 1";
            this.Rebate1.FieldName = "VarRebate1";
            this.Rebate1.MinWidth = 35;
            this.Rebate1.Name = "Rebate1";
            this.Rebate1.Visible = true;
            this.Rebate1.VisibleIndex = 4;
            this.Rebate1.Width = 174;
            // 
            // Rebate2
            // 
            this.Rebate2.Caption = "Rebate 2";
            this.Rebate2.FieldName = "VarRebate2";
            this.Rebate2.MinWidth = 35;
            this.Rebate2.Name = "Rebate2";
            this.Rebate2.Width = 80;
            // 
            // Rebate3
            // 
            this.Rebate3.Caption = "Rebate 3";
            this.Rebate3.FieldName = "VarRebate3";
            this.Rebate3.MinWidth = 35;
            this.Rebate3.Name = "Rebate3";
            this.Rebate3.Width = 80;
            // 
            // Rebate4
            // 
            this.Rebate4.Caption = "Rebate 4";
            this.Rebate4.FieldName = "VarRebate4";
            this.Rebate4.MinWidth = 35;
            this.Rebate4.Name = "Rebate4";
            this.Rebate4.Width = 80;
            // 
            // Rebate5
            // 
            this.Rebate5.Caption = "Rebate 5";
            this.Rebate5.FieldName = "VarRebate5";
            this.Rebate5.MinWidth = 35;
            this.Rebate5.Name = "Rebate5";
            this.Rebate5.Width = 80;
            // 
            // PromoCasePrice
            // 
            this.PromoCasePrice.Caption = "Promo Case Price";
            this.PromoCasePrice.FieldName = "PromoCasePrice";
            this.PromoCasePrice.MinWidth = 35;
            this.PromoCasePrice.Name = "PromoCasePrice";
            this.PromoCasePrice.Visible = true;
            this.PromoCasePrice.VisibleIndex = 5;
            this.PromoCasePrice.Width = 177;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Tick1.gif");
            this.imageList1.Images.SetKeyName(1, "Cross.gif");
            this.imageList1.Images.SetKeyName(2, "down_dis.gif");
            this.imageList1.Images.SetKeyName(3, "plus.gif");
            this.imageList1.Images.SetKeyName(4, "minus.gif");
            this.imageList1.Images.SetKeyName(5, "find.gif");
            // 
            // pnlFactor
            // 
            this.pnlFactor.Controls.Add(this.btnApplyRate);
            this.pnlFactor.Controls.Add(this.txtAmount);
            this.pnlFactor.Controls.Add(this.labelControl3);
            this.pnlFactor.Controls.Add(this.btnRedefine);
            this.pnlFactor.Controls.Add(this.cmbFieldSelection);
            this.pnlFactor.Controls.Add(this.lblField);
            this.pnlFactor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFactor.Location = new System.Drawing.Point(0, 45);
            this.pnlFactor.Name = "pnlFactor";
            this.pnlFactor.Size = new System.Drawing.Size(1274, 40);
            this.pnlFactor.TabIndex = 2;
            // 
            // btnApplyRate
            // 
            this.btnApplyRate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnApplyRate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnApplyRate.ImageOptions.ImageIndex = 0;
            this.btnApplyRate.ImageOptions.ImageList = this.imageList1;
            this.btnApplyRate.Location = new System.Drawing.Point(676, 0);
            this.btnApplyRate.Name = "btnApplyRate";
            this.btnApplyRate.Size = new System.Drawing.Size(146, 40);
            this.btnApplyRate.TabIndex = 11;
            this.btnApplyRate.Text = "Apply";
            this.btnApplyRate.Click += new System.EventHandler(this.btnApplyRate_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAmount.EditValue = "0";
            this.txtAmount.Location = new System.Drawing.Point(610, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(66, 36);
            this.txtAmount.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl3.Location = new System.Drawing.Point(526, 0);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 40);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = " Amount";
            // 
            // btnRedefine
            // 
            this.btnRedefine.Appearance.Options.UseTextOptions = true;
            this.btnRedefine.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnRedefine.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnRedefine.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRedefine.ImageOptions.ImageIndex = 2;
            this.btnRedefine.ImageOptions.ImageList = this.imageList1;
            this.btnRedefine.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnRedefine.Location = new System.Drawing.Point(379, 0);
            this.btnRedefine.Name = "btnRedefine";
            this.btnRedefine.Size = new System.Drawing.Size(147, 40);
            this.btnRedefine.TabIndex = 12;
            this.btnRedefine.Text = "Redefine";
            this.btnRedefine.Click += new System.EventHandler(this.btnRedefine_Click);
            // 
            // cmbFieldSelection
            // 
            this.cmbFieldSelection.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbFieldSelection.Location = new System.Drawing.Point(79, 0);
            this.cmbFieldSelection.Name = "cmbFieldSelection";
            this.cmbFieldSelection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Redefine >", -1, true, false, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            simpleContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            simpleContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            simpleContextButton1.Caption = "Edit";
            simpleContextButton1.Id = new System.Guid("5d76a280-09e6-477e-8e7a-527dc3240738");
            simpleContextButton1.Name = "simpleContextButton1";
            this.cmbFieldSelection.Properties.ContextButtons.Add(simpleContextButton1);
            this.cmbFieldSelection.Size = new System.Drawing.Size(300, 36);
            this.cmbFieldSelection.TabIndex = 7;
            this.cmbFieldSelection.SelectedIndexChanged += new System.EventHandler(this.cmbFieldSelection_SelectedIndexChanged);
            this.cmbFieldSelection.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmbFieldSelection_ButtonClick);
            // 
            // lblField
            // 
            this.lblField.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblField.Location = new System.Drawing.Point(0, 0);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(79, 40);
            this.lblField.TabIndex = 6;
            this.lblField.Text = "Field";
            this.lblField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1274, 45);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Multi Edit Options";
            // 
            // pnlRebate
            // 
            this.pnlRebate.Controls.Add(this.pnlSpacer);
            this.pnlRebate.Controls.Add(this.btnRebateCancel);
            this.pnlRebate.Controls.Add(this.btnRebateOK);
            this.pnlRebate.Controls.Add(this.lblRebateType);
            this.pnlRebate.Controls.Add(this.cmbRebateType);
            this.pnlRebate.Controls.Add(this.lblRebateName);
            this.pnlRebate.Controls.Add(this.txtRebateName);
            this.pnlRebate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRebate.Location = new System.Drawing.Point(0, 85);
            this.pnlRebate.Name = "pnlRebate";
            this.pnlRebate.Size = new System.Drawing.Size(1274, 37);
            this.pnlRebate.TabIndex = 3;
            this.pnlRebate.Visible = false;
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpacer.Location = new System.Drawing.Point(801, 0);
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Size = new System.Drawing.Size(210, 37);
            this.pnlSpacer.TabIndex = 7;
            // 
            // btnRebateCancel
            // 
            this.btnRebateCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnRebateCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRebateCancel.ImageOptions.ImageIndex = 1;
            this.btnRebateCancel.ImageOptions.ImageList = this.imageList1;
            this.btnRebateCancel.Location = new System.Drawing.Point(666, 0);
            this.btnRebateCancel.Name = "btnRebateCancel";
            this.btnRebateCancel.Size = new System.Drawing.Size(135, 37);
            this.btnRebateCancel.TabIndex = 6;
            this.btnRebateCancel.Text = "Cancel";
            this.btnRebateCancel.Click += new System.EventHandler(this.btnRebateCancel_Click);
            // 
            // btnRebateOK
            // 
            this.btnRebateOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnRebateOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRebateOK.ImageOptions.ImageIndex = 0;
            this.btnRebateOK.ImageOptions.ImageList = this.imageList1;
            this.btnRebateOK.Location = new System.Drawing.Point(569, 0);
            this.btnRebateOK.Name = "btnRebateOK";
            this.btnRebateOK.Size = new System.Drawing.Size(97, 37);
            this.btnRebateOK.TabIndex = 5;
            this.btnRebateOK.Text = "OK";
            this.btnRebateOK.Click += new System.EventHandler(this.btnRebateOK_Click);
            // 
            // lblRebateType
            // 
            this.lblRebateType.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRebateType.Location = new System.Drawing.Point(427, 0);
            this.lblRebateType.Name = "lblRebateType";
            this.lblRebateType.Size = new System.Drawing.Size(142, 37);
            this.lblRebateType.TabIndex = 4;
            this.lblRebateType.Text = "Rebate Type";
            this.lblRebateType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRebateType
            // 
            this.cmbRebateType.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbRebateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRebateType.FormattingEnabled = true;
            this.cmbRebateType.Items.AddRange(new object[] {
            "OI",
            "BB",
            "Scan",
            "Other"});
            this.cmbRebateType.Location = new System.Drawing.Point(273, 0);
            this.cmbRebateType.Name = "cmbRebateType";
            this.cmbRebateType.Size = new System.Drawing.Size(154, 32);
            this.cmbRebateType.TabIndex = 1;
            // 
            // lblRebateName
            // 
            this.lblRebateName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRebateName.Location = new System.Drawing.Point(136, 0);
            this.lblRebateName.Name = "lblRebateName";
            this.lblRebateName.Size = new System.Drawing.Size(137, 37);
            this.lblRebateName.TabIndex = 2;
            this.lblRebateName.Text = "Rebate Name";
            this.lblRebateName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRebateName
            // 
            this.txtRebateName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtRebateName.Location = new System.Drawing.Point(0, 0);
            this.txtRebateName.Name = "txtRebateName";
            this.txtRebateName.Size = new System.Drawing.Size(136, 29);
            this.txtRebateName.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(0, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(1274, 45);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Product List";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdProduct);
            this.panel1.Controls.Add(this.pnlProductEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 447);
            this.panel1.TabIndex = 7;
            // 
            // pnlProductEdit
            // 
            this.pnlProductEdit.Controls.Add(this.pnlProductAdd);
            this.pnlProductEdit.Controls.Add(this.btnRemoveProduct);
            this.pnlProductEdit.Controls.Add(this.btnAddProduct);
            this.pnlProductEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlProductEdit.Name = "pnlProductEdit";
            this.pnlProductEdit.Size = new System.Drawing.Size(1274, 57);
            this.pnlProductEdit.TabIndex = 1;
            // 
            // pnlProductAdd
            // 
            this.pnlProductAdd.Controls.Add(this.simpleButton2);
            this.pnlProductAdd.Controls.Add(this.checkEdit1);
            this.pnlProductAdd.Controls.Add(this.simpleButton1);
            this.pnlProductAdd.Controls.Add(this.lblFindCode);
            this.pnlProductAdd.Controls.Add(this.textEdit1);
            this.pnlProductAdd.Controls.Add(this.txtSearchCode);
            this.pnlProductAdd.Controls.Add(this.labelControl4);
            this.pnlProductAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductAdd.Location = new System.Drawing.Point(288, 0);
            this.pnlProductAdd.Name = "pnlProductAdd";
            this.pnlProductAdd.Size = new System.Drawing.Size(986, 57);
            this.pnlProductAdd.TabIndex = 20;
            this.pnlProductAdd.Visible = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton2.ImageOptions.ImageIndex = 1;
            this.simpleButton2.ImageOptions.ImageList = this.imageList1;
            this.simpleButton2.Location = new System.Drawing.Point(852, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(135, 37);
            this.simpleButton2.TabIndex = 21;
            this.simpleButton2.Text = "Cancel";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(9, 11);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Product Groups";
            this.checkEdit1.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1;
            this.checkEdit1.Size = new System.Drawing.Size(182, 38);
            this.checkEdit1.TabIndex = 19;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.ImageOptions.ImageIndex = 0;
            this.simpleButton1.ImageOptions.ImageList = this.imageList1;
            this.simpleButton1.Location = new System.Drawing.Point(749, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(97, 37);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "OK";
            // 
            // lblFindCode
            // 
            this.lblFindCode.Location = new System.Drawing.Point(197, 19);
            this.lblFindCode.Name = "lblFindCode";
            this.lblFindCode.Size = new System.Drawing.Size(42, 23);
            this.lblFindCode.TabIndex = 15;
            this.lblFindCode.Text = "Code";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(521, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.textEdit1.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.textEdit1.Properties.ContextImageOptions.Image = global::ATSMockups.Properties.Resources.find;
            this.textEdit1.Properties.NullText = "Type to Search";
            this.textEdit1.Properties.NullValuePrompt = "Type to Search";
            this.textEdit1.Size = new System.Drawing.Size(222, 34);
            this.textEdit1.TabIndex = 17;
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Location = new System.Drawing.Point(255, 11);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtSearchCode.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtSearchCode.Properties.ContextImageOptions.Image = global::ATSMockups.Properties.Resources.find;
            this.txtSearchCode.Properties.NullText = "Type to Search";
            this.txtSearchCode.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSearchCode.Size = new System.Drawing.Size(161, 34);
            this.txtSearchCode.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(422, 18);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 23);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Description";
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnRemoveProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemoveProduct.ImageOptions.ImageIndex = 4;
            this.btnRemoveProduct.ImageOptions.ImageList = this.imageList1;
            this.btnRemoveProduct.Location = new System.Drawing.Point(143, 0);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(145, 57);
            this.btnRemoveProduct.TabIndex = 13;
            this.btnRemoveProduct.Text = "Remove";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddProduct.ImageOptions.ImageIndex = 3;
            this.btnAddProduct.ImageOptions.ImageList = this.imageList1;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(143, 57);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // ProductGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pnlRebate);
            this.Controls.Add(this.pnlFactor);
            this.Controls.Add(this.labelControl1);
            this.Name = "ProductGrid";
            this.Size = new System.Drawing.Size(1274, 614);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.pnlFactor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFieldSelection.Properties)).EndInit();
            this.pnlRebate.ResumeLayout(false);
            this.pnlRebate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlProductEdit.ResumeLayout(false);
            this.pnlProductAdd.ResumeLayout(false);
            this.pnlProductAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView grvProduct;
        private DevExpress.XtraGrid.Columns.GridColumn ProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn BaseCasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn Rebate1;
        private DevExpress.XtraGrid.Columns.GridColumn Rebate2;
        private DevExpress.XtraGrid.Columns.GridColumn Rebate3;
        private DevExpress.XtraGrid.Columns.GridColumn Rebate4;
        private DevExpress.XtraGrid.Columns.GridColumn Rebate5;
        private DevExpress.XtraGrid.Columns.GridColumn PromoCasePrice;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn Included;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private System.Windows.Forms.Panel pnlFactor;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFieldSelection;
        private System.Windows.Forms.Label lblField;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel pnlRebate;
        private System.Windows.Forms.Panel pnlSpacer;
        private DevExpress.XtraEditors.SimpleButton btnRebateCancel;
        private DevExpress.XtraEditors.SimpleButton btnRebateOK;
        private System.Windows.Forms.Label lblRebateType;
        private System.Windows.Forms.ComboBox cmbRebateType;
        private System.Windows.Forms.Label lblRebateName;
        private System.Windows.Forms.TextBox txtRebateName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnApplyRate;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnRedefine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlProductEdit;
        private DevExpress.XtraEditors.SimpleButton btnRemoveProduct;
        private DevExpress.XtraEditors.SimpleButton btnAddProduct;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblFindCode;
        private DevExpress.XtraEditors.TextEdit txtSearchCode;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Panel pnlProductAdd;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
