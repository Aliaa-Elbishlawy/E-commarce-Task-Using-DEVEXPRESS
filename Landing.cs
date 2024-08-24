using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commarce
{
    public partial class Landing : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString;

        public Landing(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the category form
            CategoryForm category = new CategoryForm(connectionString);

            category.ShowDialog();
        }

        private void Landing_Load(object sender, EventArgs e)
        {

        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the product form
            ProductForm category = new ProductForm(connectionString);

            category.ShowDialog();
        }
    }
}