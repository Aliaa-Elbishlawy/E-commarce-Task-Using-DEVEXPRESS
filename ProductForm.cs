using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_commarce
{
    public partial class ProductForm : XtraForm
    {
        private readonly string connectionString;

        public ProductForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            InitializeTreeList();
        }

        private void LoadCategories()
        {
            string query = "SELECT CategoryId, CategoryName FROM Categories";
            DataTable categoriesTable = FormHelper.LoadDataTable(connectionString, query);

            // Bind the ComboBoxEdit manually
            FormHelper.BindComboBoxEdit(comboBoxEditProdcut, categoriesTable, "CategoryId", "CategoryName");
        }

        private void comboBoxEditProdcut_EditValueChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBoxEditProdcut.SelectedItem as FormHelper.ComboBoxItem;
            if (selectedItem != null)
            {
                int selectedCategoryId = (int)selectedItem.Value;
                LoadProducts(selectedCategoryId);
            }
        }

        private void LoadProducts(int categoryId)
        {
            string query = @"
                SELECT ProductName, Price, StockQuantity 
                FROM Products 
                WHERE CategoryId = @CategoryId";

            DataTable productsTable = FormHelper.LoadDataTable(connectionString, query, new[]
            {
                new SqlParameter("@CategoryId", categoryId)
            });

            // Check if the DataTable has rows
            if (productsTable.Rows.Count == 0)
            {
                MessageBox.Show("No products found for the selected category.");
            }

            // Bind data to TreeList
            ProductList.DataSource = productsTable;
            ProductList.ParentFieldName = null;
            ProductList.ExpandAll();
        }

        private void InitializeTreeList()
        {
            // Clear existing columns and configure new ones
            FormHelper.InitializeTreeList(ProductList, new[]
            {
                "ProductName",
                "Price",
                "StockQuantity"
            });
        }
    }
}
