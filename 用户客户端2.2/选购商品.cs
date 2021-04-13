using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 用户客户端2._2
{
    public partial class 选购商品 : Form
    {
        private SqlConnection sqlConnection;
        private readonly string connectionString = "Data Source=.;Initial Catalog=supermarket;Integrated Security=True";

        public 选购商品()
        {
            InitializeComponent();
        }

        private void 选购商品_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“supermarketDataSet.sort”中。您可以根据需要移动或删除它。
            sortTableAdapter.Fill(supermarketDataSet.sort);
            // TODO: 这行代码将数据加载到表“supermarketDataSet.commodity”中。您可以根据需要移动或删除它。
            commodityTableAdapter.Fill(supermarketDataSet.commodity, comboBox1.SelectedValue.ToString());
            // TODO: 这行代码将数据加载到表“supermarketDataSet.cart_1”中。您可以根据需要移动或删除它。
            cart_1TableAdapter.Fill(supermarketDataSet.cart_1, 登录.tel);

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“supermarketDataSet.commodity”中。您可以根据需要移动或删除它。
            commodityTableAdapter.Fill(supermarketDataSet.commodity, comboBox1.SelectedValue.ToString());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                string updateCommand = "insert into cart values ('" + 登录.tel + "','" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "','1','T'," + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + ")";
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
            cart_1TableAdapter.Fill(supermarketDataSet.cart_1, 登录.tel);

        }
        public static bool flag = false;

        private void button1_Click(object sender, EventArgs e)
        {
            确认订单 q = new 确认订单();
            q.ShowDialog();
            if (flag == true)
            {
                string deleteString = "delete from cart where tel='" + 登录.tel + "' and c_state='T'";
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(deleteString, sqlConnection);
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "cstateDataGridViewTextBoxColumn")
            {
                if (dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString() == "T")
                {
                    string updateCommand = "update cart set c_state='F' where (tel = '" + 登录.tel + "' and itemnumber = '" + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + "')";
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
                if (dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString() == "F")
                {
                    string updateCommand = "update cart set c_state='T' where (tel = '" + 登录.tel + "' and itemnumber = '" + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + "')";
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
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Column2")
            {
                string command;
                if (dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString() == "1")
                {
                    command = "delete from cart where (tel = '" + 登录.tel + "' and itemnumber = '" + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + "')";
                }
                else
                {
                    command = "update cart set quantity = quantity - 1 where (tel = '" + 登录.tel + "' and itemnumber = '" + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + "')";

                }
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
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
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Column3")
            {
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                string updateCommand = "update cart set quantity = quantity + 1 where (tel = '" + 登录.tel + "' and itemnumber = '" + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + "')";
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
            cart_1TableAdapter.Fill(supermarketDataSet.cart_1, 登录.tel);
        }
    }
}
