using System;
using System.Windows.Forms;

namespace 用户客户端2._2
{
    public partial class 确认订单 : Form
    {
        private string name = "";
        private string address = "";
        private string usetel = "";
        private string orderNumber;
        private double amount;
        public 确认订单()
        {
            InitializeComponent();
        }

        private void 确认订单_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“supermarketDataSet.addres”中。您可以根据需要移动或删除它。
            addresTableAdapter.Fill(supermarketDataSet.addres, 登录.tel);
            try
            {
                // TODO: 这行代码将数据加载到表“supermarketDataSet.cart_1”中。您可以根据需要移动或删除它。
                cart_1TableAdapter.FillBy(supermarketDataSet1.cart_1, 登录.tel);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            try
            {
                // TODO: 这行代码将数据加载到值“amount”中。您可以根据需要移动或删除它。
                amount = (double)cart_1TableAdapter.ScalarQuery(登录.tel);
            }
            catch (Exception)
            {
                MessageBox.Show("购物车中没有商品可以结算");
            }
            textBox2.Text = amount.ToString();
            orderNumber = bookTableAdapter1.ScalarQuery().ToString();
            orderNumber = 10000 + orderNumber;
            textBox1.Text = orderNumber;
            try
            {
                name = dataGridView1.Rows[0].Cells[1].Value.ToString();
                address = dataGridView1.Rows[0].Cells[2].Value.ToString();
                usetel = dataGridView1.Rows[0].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请添加地址");
                // TODO: 调用添加地址的页面
                try
                {
                    // TODO: 这行代码将数据加载到表“supermarketDataSet.addres”中。您可以根据需要移动或删除它。
                    addresTableAdapter.Fill(supermarketDataSet.addres, 登录.tel);
                    name = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    address = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    usetel = dataGridView1.Rows[0].Cells[3].Value.ToString();
                }
                catch (Exception)
                {
                    Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            address = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            usetel = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据插入到表“book”中。您可以根据需要移动或删除它。
            bookTableAdapter1.InsertQuery(orderNumber, (int)amount, 登录.tel, usetel, address, DateTime.Now, DateTime.Now);
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                // TODO: 这行代码将数据插入到表“orderproducts”中。您可以根据需要移动或删除它。
                orderproductsTableAdapter1.InsertQuery(orderNumber, (int)dataGridView2.Rows[i].Cells[1].Value, (int)dataGridView2.Rows[i].Cells[3].Value, (DateTime)dataGridView2.Rows[i].Cells[7].Value);
            }
            // TODO: 这行代码将数据更新到表“users”中。您可以根据需要移动或删除它。
            usersTableAdapter1.UpdateQuery(Convert.ToInt32(amount), 登录.tel);
            // TODO: 这行代码将数据从表“cart”中删除。您可以根据需要移动或删除它。
            cartTableAdapter1.DeleteQuery(登录.tel);
            支付 pay = new 支付();
            pay.ShowDialog();
            Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
