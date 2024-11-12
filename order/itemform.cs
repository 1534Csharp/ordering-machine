using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order
{
    public partial class itemform : Form
    {
        public itemform()
        {
            InitializeComponent();
        }


        string[] meal = new string[] { "hamburger1", "hamburger2", "hamburger3" };
        int[] mealprice = new int[] { 50, 70, 100 };
        string[] snack = new string[] { "ice cream", "apple pie", "fries" };
        int[] snackprice = new int[] { 50, 70, 100 };
        private void itemform_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(meal);
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(snack);
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainform.msg+= comboBox1.Text + " " + mealprice[comboBox1.SelectedIndex] + "\r\n";
            Mainform.msg+= comboBox2.Text + " " + snackprice[comboBox2.SelectedIndex] + "\r\n";
            Mainform.price = mealprice[comboBox1.SelectedIndex] + snackprice[comboBox2.SelectedIndex];
            Mainform.msg += $"total {Mainform.price} dollar\r\n";
            this.Dispose();
            discountform d1 = new discountform();
            d1.ShowDialog();
            
        }
    }
}
