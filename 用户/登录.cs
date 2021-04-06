using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 用户
{
    public partial class 登录 : Form
    {
        public 登录()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            忘记密码 w = new 忘记密码();
            w.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            注册 z = new 注册();
            z.ShowDialog();
        }

        private void 登录_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
