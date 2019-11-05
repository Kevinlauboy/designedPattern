using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using CashRegister.pattern;
using CashRegister.strategy;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            way.Items.Add("正常收费");
            way.Items.Add("打8折");
            way.Items.Add("满300返100");
        }

        double total = 0.0d;
        private void receipt_Click(object sender, EventArgs e)
        {

            double totalPrice = 0d;

            /* 使用简单工厂模式实现
            Cash cash = CashFactory.createCash(way.SelectedItem.ToString());
            totalPrice = cash.receipt(Convert.ToDouble(pricebox.Text) * Convert.ToDouble(numbox.Text));
            total += totalPrice;
            */

            /* 使用策略模式实现*/
            CashContext cashcontext = new CashContext();
            string strway = way.SelectedItem.ToString();
            switch (strway)
            {
                case "正常收费":
                    cashcontext.CashImp=new CashNormal();
                    break;
                case "打8折":
                    cashcontext.CashImp = new CashDiscount("0.8");
                    break;
                case "满300返100":
                    cashcontext.CashImp = new CashReduction("1000", "100");
                    break;
                default:
                    cashcontext.CashImp = new CashNormal();
                    break;
            }
            totalPrice = cashcontext.getReceipt(Convert.ToDouble(pricebox.Text) * Convert.ToDouble(numbox.Text));
            total += totalPrice;
            recordlist.Items.Add("单价：" + pricebox.Text +
                "数量" + numbox.Text + " " + way.SelectedItem + "合计:" + totalPrice.ToString());
            sum.Text = total.ToString();
        }
    }
}
