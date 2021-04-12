using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 用户客户端2._1
{
    public partial class 购物车 : Form
    {
        public 购物车()
        {
            InitializeComponent();
        }

        private void 购物车_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“supermarketDataSet.cart”中。您可以根据需要移动或删除它。
            this.cartTableAdapter.Fill(this.supermarketDataSet.cart,登录.tel);

        }
    }
}
