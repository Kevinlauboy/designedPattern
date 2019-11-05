using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CashRegister.pattern;

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
            Cash cash = CashFactory.createCash(way.SelectedItem.ToString());
            double totalPrice = 0d;
            totalPrice = cash.receipt(Convert.ToDouble(pricebox.Text) * Convert.ToDouble(numbox.Text));
            total += totalPrice;
            recordlist.Items.Add("单价：" + pricebox.Text +
                "数量" + numbox.Text + " " + way.SelectedItem + "合计:" + totalPrice.ToString());
            sum.Text = total.ToString();
        }
    }
}
