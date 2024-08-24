namespace E_commarce
{
    partial class Landing
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
            labelLanding = new DevExpress.XtraEditors.LabelControl();
            CategoryButton = new DevExpress.XtraEditors.SimpleButton();
            ProductButton = new DevExpress.XtraEditors.SimpleButton();
            pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            SuspendLayout();

            // 
            // labelLanding
            // 
            labelLanding.Appearance.BackColor = Color.FromArgb(224, 224, 224);
            labelLanding.Appearance.BorderColor = Color.Black;
            labelLanding.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            labelLanding.Appearance.ForeColor = Color.Black;
            labelLanding.Appearance.Options.UseBackColor = true;
            labelLanding.Appearance.Options.UseBorderColor = true;
            labelLanding.Appearance.Options.UseFont = true;
            labelLanding.Appearance.Options.UseForeColor = true;
            labelLanding.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelLanding.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelLanding.Location = new Point(150, 20);
            labelLanding.Name = "labelLanding";
            labelLanding.Size = new Size(1130, 60);
            labelLanding.TabIndex = 0;
            labelLanding.Text = "Welcome To Our E-commerce Platform";

            // 
            // pictureEdit
            // 
            pictureEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureEdit.Image = Image.FromFile(@"C:\Users\aliaa\source\repos\E-commarce\Resources\best-ecommerce.jpg");
            pictureEdit.Location = new Point(150, 100);
            pictureEdit.Name = "pictureEdit";
            pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit.Size = new Size(1130, 300);
            pictureEdit.TabIndex = 1;

            // 
            // CategoryButton
            // 
            CategoryButton.Appearance.BackColor = Color.FromArgb(255, 224, 192);
            CategoryButton.Appearance.BorderColor = Color.Black;
            CategoryButton.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            CategoryButton.Appearance.ForeColor = Color.Black;
            CategoryButton.Appearance.Options.UseBackColor = true;
            CategoryButton.Appearance.Options.UseBorderColor = true;
            CategoryButton.Appearance.Options.UseFont = true;
            CategoryButton.Appearance.Options.UseForeColor = true;
            CategoryButton.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            CategoryButton.Location = new Point(100, 500);
            CategoryButton.Name = "CategoryButton";
            CategoryButton.Size = new Size(600, 100);
            CategoryButton.TabIndex = 2;
            CategoryButton.Text = "Category";
            CategoryButton.Click += CategoryButton_Click;

            // 
            // ProductButton
            // 
            ProductButton.Appearance.BackColor = Color.FromArgb(255, 224, 192);
            ProductButton.Appearance.BorderColor = Color.Black;
            ProductButton.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            ProductButton.Appearance.ForeColor = Color.Black;
            ProductButton.Appearance.Options.UseBackColor = true;
            ProductButton.Appearance.Options.UseBorderColor = true;
            ProductButton.Appearance.Options.UseFont = true;
            ProductButton.Appearance.Options.UseForeColor = true;
            ProductButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            ProductButton.Location = new Point(735, 500);
            ProductButton.Name = "ProductButton";
            ProductButton.Size = new Size(600, 100);
            ProductButton.TabIndex = 3;
            ProductButton.Text = "Products";
            ProductButton.Click += ProductButton_Click;

            // 
            // Landing
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 659);
            Controls.Add(ProductButton);
            Controls.Add(CategoryButton);
            Controls.Add(pictureEdit);
            Controls.Add(labelLanding);
            Name = "Landing";
            Text = "Landing";
            Load += Landing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private DevExpress.XtraEditors.LabelControl labelLanding;
        private DevExpress.XtraEditors.SimpleButton CategoryButton;
        private DevExpress.XtraEditors.SimpleButton ProductButton;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
    }
}
