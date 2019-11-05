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
using System.Reflection;

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

        DataSet xmlConfig;
        private void receipt_Click(object sender, EventArgs e)
        {

            double totalPrice = 0d;

            /* 使用简单工厂模式实现
            Cash cash = CashFactory.createCash(way.SelectedItem.ToString());
            totalPrice = cash.receipt(Convert.ToDouble(pricebox.Text) * Convert.ToDouble(numbox.Text));
            total += totalPrice;
            */

            /* 使用策略模式实现
            string strway = way.SelectedItem.ToString();
            CashContext cashcontext = new CashContext(strway);
            totalPrice = cashcontext.getReceipt(Convert.ToDouble(pricebox.Text) * Convert.ToDouble(numbox.Text));
            total += totalPrice;
            recordlist.Items.Add("单价：" + pricebox.Text +
                "数量" + numbox.Text + " " + way.SelectedItem + "合计:" + totalPrice.ToString());
            sum.Text = total.ToString();
             */

            //使用反射机制结合策略模式
            CashContext cashcontext = new CashContext();

            DataRow dr = ((DataRow[])xmlConfig.Tables[0].Select("name='" + way.SelectedItem.ToString() + "'"))[0];

            //声明一个参数的对象数组
            object[] args = null;
            if (dr["para"].ToString() != "")
                args = dr["para"].ToString().Split(',');
            cashcontext.CashImp = (Cash)Assembly.Load("CashRegister").CreateInstance(
            "CashRegister.strategy." + dr["class"].ToString(), false,
             BindingFlags.Default, null, args, null, null
            );
            totalPrice = cashcontext.getReceipt(Convert.ToDouble(pricebox.Text) * Convert.ToDouble(numbox.Text));
            total += totalPrice;
            recordlist.Items.Add("单价：" + pricebox.Text +
                "数量" + numbox.Text + " " + way.SelectedItem + "合计:" + totalPrice.ToString());
            sum.Text = total.ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            xmlConfig = new DataSet();
            xmlConfig.ReadXml(Application.StartupPath + "\\CashAcceptType.xml");
            foreach (DataRowView dr in xmlConfig.Tables[0].DefaultView)
            {
                way.Items.Add(dr["name"].ToString());
            }
            way.SelectedIndex = 0;
        }
    }
}
