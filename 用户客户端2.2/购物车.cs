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

namespace 用户客户端2._2
{
    public partial class 购物车 : Form
    {
        private SqlConnection sqlConnection;
        private string connectionString = "Data Source=.;Initial Catalog=supermarket;Integrated Security=True";

        public 购物车()
        {
            InitializeComponent();
        }

        private void 购物车_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“supermarketDataSet.cart_1”中。您可以根据需要移动或删除它。
            this.cart_1TableAdapter.Fill(this.supermarketDataSet.cart_1, 登录.tel);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "cstateDataGridViewTextBoxColumn")
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "T")
                {
                    String updateCommand = "update cart set c_state='F' where (tel = '" + 登录.tel + "' and itemnumber = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "')";
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
                if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "F")
                {
                    String updateCommand = "update cart set c_state='T' where (tel = '" + 登录.tel + "' and itemnumber = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "')";
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
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                String updateCommand = "update cart set quantity = quantity - 1 where (tel = '" + 登录.tel + "' and itemnumber = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "')";
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
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                String updateCommand = "update cart set quantity = quantity + 1 where (tel = '" + 登录.tel + "' and itemnumber = '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "')";
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
            // TODO: 这行代码将数据加载到表“supermarketDataSet.cart_1”中。您可以根据需要移动或删除它。
            this.cart_1TableAdapter.Fill(this.supermarketDataSet.cart_1, 登录.tel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            确认订单 q = new 确认订单();
            q.Show();
        }
    }
}
