# ordering-machine
# 11/12 

## order machine
* 建立主選單視窗(外帶、內用)
* 建立點餐視窗(餐點)
* 建立優惠視窗(會員、折扣碼)

### 成果照

點餐機視窗
![image](https://hackmd.io/_uploads/BykWe_xzkx.png)
點餐後+折扣後視窗
![image](https://hackmd.io/_uploads/rJ5Y15gfJx.png)
點餐
![image](https://hackmd.io/_uploads/ryT-gclM1x.png)
折扣
![image](https://hackmd.io/_uploads/HycQx9eGJl.png)



form1
```csharp=
namespace order
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string msg = "";
        public static double price = 0;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemform f1 = new itemform();
            f1.ShowDialog();
        }

        private void Mainform_Activated(object sender, EventArgs e)
        {
            textBox1.Text = msg;
        }
    }
}
```
itemform
```csharp=
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


```
discountform
```csharp=
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


```
