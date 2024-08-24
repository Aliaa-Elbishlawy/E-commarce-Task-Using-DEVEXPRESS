using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_commarce
{
    public static class FormHelper
    {
        public static DataTable LoadDataTable(string connectionString, string query, SqlParameter[] parameters = null)
        {
            var dataTable = new DataTable();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                connection.Open();
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static void BindComboBoxEdit(ComboBoxEdit comboBoxEdit, DataTable dataTable, string valueField, string displayField)
        {
            comboBoxEdit.Properties.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                comboBoxEdit.Properties.Items.Add(new ComboBoxItem
                {
                    Value = row[valueField],
                    DisplayText = row[displayField].ToString()
                });
            }
        }

        public static void InitializeTreeList(TreeList treeList, string[] columnNames)
        {
            treeList.Columns.Clear();
            foreach (var columnName in columnNames)
            {
                var column = new DevExpress.XtraTreeList.Columns.TreeListColumn
                {
                    Caption = columnName,
                    FieldName = columnName,
                    Visible = true
                };
                treeList.Columns.Add(column);
            }
        }

        public class ComboBoxItem
        {
            public object Value { get; set; }
            public string DisplayText { get; set; }

            public override string ToString() => DisplayText;
        }
    }
}
