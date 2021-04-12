using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 用户客户端2._2
{
    public partial class 确认订单 : Form
    {
        private String name = "";
        private String address = "";
        private String usetel = "";
        private string orderNumber;
        private String connectionString = "Data Source=.;Initial Catalog=supermarket;Integrated Security=True";
        SqlConnection sqlConnection;
        public static string amount;
        public 确认订单()
        {
            InitializeComponent();
        }

        private void 确认订单_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“supermarketDataSet.addres”中。您可以根据需要移动或删除它。
            this.addresTableAdapter.Fill(this.supermarketDataSet.addres, 登录.tel);
            try
            {
                this.cart_1TableAdapter.FillBy(this.supermarketDataSet1.cart_1, 登录.tel);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            String selectText = "select SUM(sell*quantity) from commodity,cart where commodity.itemnumber=cart.itemnumber and tel='" + 登录.tel + "' and c_state='T'";
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(selectText, sqlConnection);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    amount = sqlDataReader[0].ToString();
                }
                textBox2.Text = amount;
                sqlDataReader.Close();
                sqlConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
            String selectOrdernumber = "select count(*) from book";
            sqlCommand.CommandText = selectOrdernumber;
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    orderNumber = sqlDataReader[0].ToString();
                }
                sqlDataReader.Close();
                sqlConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            orderNumber = 10000 + orderNumber;
            textBox1.Text = orderNumber;
            name = dataGridView1.Rows[0].Cells[1].Value.ToString();
            address = dataGridView1.Rows[0].Cells[2].Value.ToString();
            usetel = dataGridView1.Rows[0].Cells[3].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            address = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            usetel = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertText = "insert into book(ordernamber,b_state,payment,tel,usetel,adr,bookTime,payTime) values('"+orderNumber.ToString()+"','已支付','" + amount.ToString() + "','" + 登录.tel + "','" + usetel + "','" + address + "','" + DateTime.Now.Year+"-" + DateTime.Now.Month+"-" + DateTime.Now.Day + "','" + DateTime.Now.Year+"-" + DateTime.Now.Month+"-" + DateTime.Now.Day + "')";
            SqlCommand sqlCommand = new SqlCommand(insertText,sqlConnection);
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

            支付 pay = new 支付();
            pay.ShowDialog();
            Close();
        }
    }
}
