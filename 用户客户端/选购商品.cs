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
    public partial class 选购商品 : Form
    {
        String connectionString = "server=.;database=supermarket;integrated security=sspi";
        SqlConnection sqlConnection;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        public 选购商品()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            购物车 cart = new 购物车();
            cart.Show();
        }
        private void 选购商品_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            String selectCommand = "select sort_name from sort";
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(selectCommand, sqlConnection);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    comboBox1.Items.Add(sqlDataReader[0].ToString());
                }
                sqlDataReader.Close();
                sqlConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            if (comboBox1.Items.Count != 0)
            {
                comboBox1.Text = comboBox1.Items[0].ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectCommand = "select itemnumber,name from commodity where sort_number = (select sort_number from sort where sort_name = '" + comboBox1.Text + "')";
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(selectCommand, sqlConnection);
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
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
            dataGridView1.Columns[0].HeaderText = "商品编号";
            dataGridView1.Columns[1].HeaderText = "商品名称";
            DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
            dataGridViewButtonColumn.HeaderText = "操作";
            dataGridViewButtonColumn.Name = "column2";
            dataGridViewButtonColumn.DefaultCellStyle.NullValue = "添加到购物车";
            dataGridView1.Columns.Add(dataGridViewButtonColumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.Columns[e.ColumnIndex].Name == "column2")
            //{
            String updateCommand = "insert into cart values ('"++"','" + dataGridView1[e.RowIndex, 0].Value + "','1','y'," + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + ")";
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
            //}
        }
    }
}
