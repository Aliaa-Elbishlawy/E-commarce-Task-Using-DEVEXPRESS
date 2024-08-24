namespace E_commarce
{
    partial class CategoryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelCategoryControl = new DevExpress.XtraEditors.LabelControl();
            Categories = new DevExpress.XtraEditors.ComboBoxEdit();
            CategoryList = new DevExpress.XtraTreeList.TreeList();
            CategoryColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)Categories.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CategoryList).BeginInit();
            SuspendLayout();

            // 
            // labelCategoryControl
            // 
            labelCategoryControl.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            labelCategoryControl.Appearance.BorderColor = Color.Black;
            labelCategoryControl.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            labelCategoryControl.Appearance.ForeColor = Color.Black;
            labelCategoryControl.Appearance.Options.UseBackColor = true;
            labelCategoryControl.Appearance.Options.UseBorderColor = true;
            labelCategoryControl.Appearance.Options.UseFont = true;
            labelCategoryControl.Appearance.Options.UseForeColor = true;
            labelCategoryControl.Anchor = AnchorStyles.Top | AnchorStyles.Left;  // Anchor to top-left
            labelCategoryControl.Location = new Point(30, 30);
            labelCategoryControl.Name = "labelCategoryControl";
            labelCategoryControl.Size = new Size(150, 40);
            labelCategoryControl.TabIndex = 0;
            labelCategoryControl.Text = "Category";

            // 
            // Categories
            // 
            Categories.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;  // Anchor to top-left-right
            Categories.Location = new Point(200, 30);
            Categories.Name = "Categories";
            Categories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Categories.Size = new Size(600, 40);
            Categories.TabIndex = 1;
            Categories.EditValueChanged += Categories_EditValueChanged;

            // 
            // CategoryList
            // 
            CategoryList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;  // Fill the remaining space
            CategoryList.Location = new Point(30, 80);
            CategoryList.Name = "CategoryList";
            CategoryList.Size = new Size(1000, 450);
            CategoryList.TabIndex = 2;

            // 
            // CategoryColumn
            // 
            CategoryColumn.Caption = "Category";
            CategoryColumn.FieldName = "CategoryName";
            CategoryColumn.Name = "CategoryColumn";
            CategoryColumn.Visible = true;
            CategoryColumn.VisibleIndex = 0;

            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(CategoryList);
            Controls.Add(Categories);
            Controls.Add(labelCategoryControl);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)Categories.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CategoryList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private DevExpress.XtraEditors.LabelControl labelCategoryControl;
        private DevExpress.XtraEditors.ComboBoxEdit Categories;
        private DevExpress.XtraTreeList.TreeList CategoryList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn CategoryColumn;
    }
}
