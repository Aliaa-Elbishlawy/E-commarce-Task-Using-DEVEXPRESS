namespace E_commarce
{
    partial class ProductForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ProductControl = new DevExpress.XtraEditors.LabelControl();
            ProductList = new DevExpress.XtraTreeList.TreeList();
            ProductNameColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ProductPriceColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            QuantityColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            comboBoxEditProdcut = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)ProductList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEditProdcut.Properties).BeginInit();
            SuspendLayout();

            // 
            // ProductControl
            // 
            ProductControl.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            ProductControl.Appearance.BorderColor = Color.Black;
            ProductControl.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            ProductControl.Appearance.ForeColor = Color.Black;
            ProductControl.Appearance.Options.UseBackColor = true;
            ProductControl.Appearance.Options.UseBorderColor = true;
            ProductControl.Appearance.Options.UseFont = true;
            ProductControl.Appearance.Options.UseForeColor = true;
            ProductControl.Anchor = AnchorStyles.Top | AnchorStyles.Left;  // Anchor to top-left
            ProductControl.Location = new Point(30, 30);
            ProductControl.Name = "ProductControl";
            ProductControl.Size = new Size(129, 40);
            ProductControl.TabIndex = 0;
            ProductControl.Text = "Product";

            // 
            // ProductList
            // 
            ProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;  // Fill the remaining space
            ProductList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { ProductNameColumn, ProductPriceColumn, QuantityColumn });
            ProductList.Location = new Point(30, 80);
            ProductList.Name = "ProductList";
            ProductList.Size = new Size(1150, 500);
            ProductList.TabIndex = 1;

            // 
            // ProductNameColumn
            // 
            ProductNameColumn.Caption = "Product Name";
            ProductNameColumn.FieldName = "ProductName";
            ProductNameColumn.Name = "ProductNameColumn";
            ProductNameColumn.Visible = true;
            ProductNameColumn.VisibleIndex = 0;

            // 
            // ProductPriceColumn
            // 
            ProductPriceColumn.Caption = "Price";
            ProductPriceColumn.FieldName = "Price";
            ProductPriceColumn.Name = "ProductPriceColumn";
            ProductPriceColumn.Visible = true;
            ProductPriceColumn.VisibleIndex = 1;

            // 
            // QuantityColumn
            // 
            QuantityColumn.Caption = "Quantity";
            QuantityColumn.FieldName = "StockQuantity";
            QuantityColumn.Name = "QuantityColumn";
            QuantityColumn.Visible = true;
            QuantityColumn.VisibleIndex = 2;

            // 
            // comboBoxEditProdcut
            // 
            comboBoxEditProdcut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;  // Anchor to top-left-right
            comboBoxEditProdcut.Location = new Point(200, 30);
            comboBoxEditProdcut.Name = "comboBoxEditProdcut";
            comboBoxEditProdcut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEditProdcut.Size = new Size(600, 40);
            comboBoxEditProdcut.TabIndex = 2;
            comboBoxEditProdcut.EditValueChanged += comboBoxEditProdcut_EditValueChanged;

            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            Controls.Add(comboBoxEditProdcut);
            Controls.Add(ProductList);
            Controls.Add(ProductControl);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductList).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEditProdcut.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private DevExpress.XtraEditors.LabelControl ProductControl;
        private DevExpress.XtraTreeList.TreeList ProductList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ProductNameColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ProductPriceColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn QuantityColumn;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditProdcut;
    }
}
