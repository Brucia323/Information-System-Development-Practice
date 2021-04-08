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
    public partial class 用户 : Form
    {
        public 用户()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            登录 d = new 登录();
            d.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            购物车 g = new 购物车();
            g.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            个人信息 g = new 个人信息();
            g.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
