﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 用户客户端2._1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            登录 login = new 登录();
            login.ShowDialog();
            if(login.DialogResult==DialogResult.OK)
            {
                login.Dispose();
            Application.Run(new 选购商品());
            }
            else
            {
                login.Close();
                return;
            }
        }
    }
}
