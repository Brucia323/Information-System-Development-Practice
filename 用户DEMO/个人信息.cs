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
    public partial class 个人信息 : Form
    {
        public 个人信息()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            收货地址 s = new 收货地址();
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            订单 d = new 订单();
            d.Show();
        }
    }
}
