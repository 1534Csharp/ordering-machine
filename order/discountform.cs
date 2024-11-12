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
    public partial class discountform : Form
    {
        public discountform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainform.msg += "==========================\r\n";
            if(checkBox1.Checked)
            {
                Mainform.price = Mainform.price * 0.95;
                Mainform.msg = "Premium 5% discount\r\n";
            }
            if (checkBox2.Checked)
            {
                Mainform.price = Mainform.price - 20;
                Mainform.msg += "discount 20 dollars\r\n";
            }
            Mainform.msg += "total" + Math.Round(Mainform.price, 0).ToString()+ Environment.NewLine;
            this.Dispose();
        }
    }
}

