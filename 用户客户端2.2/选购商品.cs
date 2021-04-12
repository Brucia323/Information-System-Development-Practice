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
    public partial class 选购商品 : Form
    {
        private SqlConnection sqlConnection;
        private String connectionString= "Data Source=.;Initial Catalog=supermarket;Integrated Security=True";

        public 选购商品()
        {
            InitializeComponent();
        }

        private void 选购商品_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“supermarketDataSet.sort”中。您可以根据需要移动或删除它。
            this.sortTableAdapter.Fill(this.supermarketDataSet.sort);
            // TODO: 这行代码将数据加载到表“supermarketDataSet.commodity”中。您可以根据需要移动或删除它。
            this.commodityTableAdapter.Fill(this.supermarketDataSet.commodity,comboBox1.SelectedValue.ToString());

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“supermarketDataSet.commodity”中。您可以根据需要移动或删除它。
            this.commodityTableAdapter.Fill(this.supermarketDataSet.commodity, comboBox1.SelectedValue.ToString());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                String updateCommand = "insert into cart values ('" + 登录.tel + "','" + dataGridView1[e.RowIndex, 0].Value + "','1','T'," + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + ")";
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

        private void button1_Click(object sender, EventArgs e)
        {
            购物车 cart = new 购物车();
            cart.Show();
        }
    }
}
