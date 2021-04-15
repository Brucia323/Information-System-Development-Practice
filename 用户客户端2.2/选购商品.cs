using System;
using System.Windows.Forms;

namespace 用户客户端2._2
{
    public partial class 选购商品 : Form
    {
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
                try
                {
                    // TODO: 这行代码将数据插入到表“cart”中。您可以根据需要移动或删除它。
                    cartTableAdapter1.InsertQuery(登录.tel, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), DateTime.Now, (DateTime)commodityTableAdapter.ScalarQuery(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), (double)dataGridView1.Rows[e.RowIndex].Cells[2].Value));
                }
                catch
                {
                    // TODO: 这行代码将数据更新到表“cart”中。您可以根据需要移动或删除它。
                    cartTableAdapter1.UpdateQuery3(登录.tel, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            // TODO: 这行代码将数据加载到表“supermarketDataSet.cart_1”中。您可以根据需要移动或删除它。
            cart_1TableAdapter.Fill(supermarketDataSet.cart_1, 登录.tel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            确认订单 q = new 确认订单();
            q.ShowDialog();
            // TODO: 这行代码将数据加载到表“supermarketDataSet.cart_1”中。您可以根据需要移动或删除它。
            cart_1TableAdapter.Fill(supermarketDataSet.cart_1, 登录.tel);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "cstateDataGridViewTextBoxColumn")
            {
                if (dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString() == "T")
                {
                    // TODO: 这行代码将数据更新到表“cart”中。您可以根据需要移动或删除它。
                    cartTableAdapter1.UpdateQuery(登录.tel, dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
                if (dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString() == "F")
                {
                    // TODO: 这行代码将数据更新到表“cart”中。您可以根据需要移动或删除它。
                    cartTableAdapter1.UpdateQuery1(登录.tel, dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
            }
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Column2")
            {
                if (dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString() == "1")
                {
                    // TODO: 这行代码将数据从表“cart”中删除。您可以根据需要移动或删除它。
                    cartTableAdapter1.DeleteQuery1(登录.tel, dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString(), (DateTime)dataGridView2.Rows[e.RowIndex].Cells[9].Value);
                }
                else
                {
                    // TODO: 这行代码将数据更新到表“cart”中。您可以根据需要移动或删除它。
                    cartTableAdapter1.UpdateQuery2(登录.tel, dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
                }
            }
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Column3")
            {
                // TODO: 这行代码将数据更新到表“cart”中。您可以根据需要移动或删除它。
                cartTableAdapter1.UpdateQuery3(登录.tel, dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            // TODO: 这行代码将数据加载到表“supermarketDataSet.cart_1”中。您可以根据需要移动或删除它。
            cart_1TableAdapter.Fill(supermarketDataSet.cart_1, 登录.tel);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“supermarketDataSet.commodity”中。您可以根据需要移动或删除它。
            commodityTableAdapter.FillBy(supermarketDataSet.commodity, textBox1.Text);
            if (textBox1.Text == "")
            {
                // TODO: 这行代码将数据加载到表“supermarketDataSet.commodity”中。您可以根据需要移动或删除它。
                commodityTableAdapter.Fill(supermarketDataSet.commodity, comboBox1.SelectedValue.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: 跳转到个人中心
        }
    }
}
