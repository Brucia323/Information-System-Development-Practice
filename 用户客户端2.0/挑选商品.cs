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
    public partial class 挑选商品 : Form
    {
        private SqlConnection sqlConnection;
        private string connectionString = "Data Source=.;Initial Catalog=supermarket;Integrated Security=True";
        登录 login;

        public 挑选商品()
        {
            InitializeComponent();
        }

        private void 挑选商品_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“supermarketDataSet1.sort”中。您可以根据需要移动或删除它。
            this.sortTableAdapter.Fill(this.supermarketDataSet1.sort);
            // TODO: 这行代码将数据加载到表“supermarketDataSet.Selection_of_goods”中。您可以根据需要移动或删除它。
            this.selection_of_goodsTableAdapter.Fill(this.supermarketDataSet.Selection_of_goods);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                String insertCommand = "insert into cart values('"+login.tel+"')";
                sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = new SqlCommand(insertCommand, sqlConnection);
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

        private void button2_Click(object sender, EventArgs e)
        {
            购物车 cart = new 购物车();
            cart.Show();
        }
    }
}
