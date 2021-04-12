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
using System.Globalization;

namespace 用户客户端
{
    public partial class 购物车 : Form
    {
        String connectionString = "server=.;database=supermarket;integrated security=sspi";
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlConnection sqlConnection;

        public 购物车()
        {
            InitializeComponent();
        }
        private void GetData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataAdapter.Update((DataTable)bindingSource1.DataSource);
            确认订单 qrdd = new 确认订单();
            qrdd.Show();
        }

        private void 购物车_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select commodity.name,cart.quantity,cart.c_state from commodity,cart where commodity.itemnumber=cart.itemnumber and itemnumber = (select itemnumber from cart where tel='17689325323') and tel = '17689325323'");
            dataGridView1.Columns[0].HeaderText = "商品名称";
            dataGridView1.Columns[1].HeaderText = "数量";
            dataGridView1.Columns[2].HeaderText = "";
            //DataGridViewCheckBoxCell dataGridViewCheckBoxCell = new DataGridViewCheckBoxCell();
            //dataGridView1.Columns[2] = dataGridViewCheckBoxCell;
            DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
            dataGridViewButtonColumn.HeaderText = "操作";
            dataGridViewButtonColumn.Name = "column3";
            dataGridViewButtonColumn.DefaultCellStyle.NullValue = "删除";
            dataGridView1.Columns.Add(dataGridViewButtonColumn);

        }

        private void 购物车_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataAdapter.Update((DataTable)bindingSource1.DataSource);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "column2")
            {
                String updateCommand = "delete from cart where itemnumber=(select itemnumber from commodity where name ='" + dataGridView1[e.RowIndex, 0] + "')";
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
    }
}
