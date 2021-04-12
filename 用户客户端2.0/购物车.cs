using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 用户客户端给2._0
{
    public partial class 购物车 : Form
    {
        登录 login;
        private SqlConnection sqlConnection;
        private string connectionString = "Data Source=.;Initial Catalog=supermarket;Integrated Security=True";

        public 购物车()
        {
            InitializeComponent();
        }

        private void 购物车_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“supermarketDataSet2.cart_1”中。您可以根据需要移动或删除它。
            this.cart_1TableAdapter.Fill(this.supermarketDataSet2.cart_1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                String updateCommand = "update from cart set quantity = quantity - 1 where (tel = '" + login.tel + "' and itemnumber = '" + dataGridView1[e.RowIndex, 2].Value + "')";
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(updateCommand, sqlConnection);
                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column2")
            {
                String updateCommand = "update from cart set quantity = quantity + 1 where (tel = '" + login.tel + "' and itemnumber = '" + dataGridView1[e.RowIndex, 2].Value + "')";
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(updateCommand, sqlConnection);
                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column3")
            {
                String deleteCommand = "delete from cart where (tel = '" + login.tel + "' and itemnumber = '" + dataGridView1[e.RowIndex, 2].Value + "')";
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(deleteCommand, sqlConnection);
                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
