using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_commarce
{
    public partial class CategoryForm : XtraForm
    {
        private readonly string connectionString;

        public CategoryForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            const string query = "SELECT CategoryId, CategoryName FROM Categories";
            var categoriesTable = FormHelper.LoadDataTable(connectionString, query);

            // Bind the ComboBoxEdit manually
            FormHelper.BindComboBoxEdit(Categories, categoriesTable, "CategoryId", "CategoryName");
        }

        private void Categories_EditValueChanged(object sender, EventArgs e)
        {
            var selectedItem = Categories.SelectedItem as FormHelper.ComboBoxItem;
            if (selectedItem != null)
            {
                var selectedCategoryId = (int)selectedItem.Value;
                LoadTreeListData(selectedCategoryId);
            }
        }

        private void LoadTreeListData(int categoryId)
        {
            const string query = @"
                SELECT CategoryId, ParentCategoryId, CategoryName 
                FROM Categories 
                WHERE CategoryId = @CategoryId OR ParentCategoryId = @CategoryId";

            var treeDataTable = FormHelper.LoadDataTable(connectionString, query, new[]
            {
                new SqlParameter("@CategoryId", categoryId)
            });

            // Ensure TreeList data binding and column setup
            CategoryList.DataSource = treeDataTable;
            CategoryList.KeyFieldName = "CategoryId";
            CategoryList.ParentFieldName = "ParentCategoryId";
            CategoryList.Columns.Clear();

            var column = new DevExpress.XtraTreeList.Columns.TreeListColumn
            {
                Caption = "Category Name",
                FieldName = "CategoryName",
                Visible = true
            };
            CategoryList.Columns.Add(column);

            CategoryList.ExpandAll();
        }
    }
}
