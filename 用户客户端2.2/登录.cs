using System;
using System.Windows.Forms;

namespace 用户客户端2._2
{
    public partial class 登录 : Form
    {
        public static string tel;
        public 登录()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tel = textBox1.Text;
            DialogResult = DialogResult.OK;
            Dispose();
        }
    }
}
