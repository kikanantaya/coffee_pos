using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee
{
    public partial class Form1 : Form
    {
        string u = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }
        public void Ak(string Menu, string Baht)
        {
            string[] kik = { Menu, Baht };
            var ko = new ListViewItem(kik);
            listView1.Items.Add(ko);
            ListPrice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ak("Esspresso(Hot)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ak("Esspresso(Ice)", "45");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ak("Esspresso(Frappe)", "50");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ak("Americaro(Hot)", "35");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ak("Americaro(Ice)", "45");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ak("Lalte(Hot)", "35");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ak("Lalte(Ice)", "45");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ak("Lalte(Frappe)", "50");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ak("Mocha(Hot)", "35");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ak("Mocha(Ice)", "45");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Ak("Mocha(Frappe)", "50");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Ak("Cappuccino(Hot)", "35");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Ak("Cappuccino(Ice)", "45");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Ak("Cappuccino(Frappe)", "50");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Ak("Gree Tea(Hot)", "20");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Ak("Gree Tea(Ice)", "25");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Ak("Gree Tea(Frappe)", "30");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Ak("Thai Tea(Hot)", "20");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Ak("Thai Tea(Ice)", "25");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Ak("Thai Tea(Frappe)", "30");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Ak("CoCoa(Hot)", "20");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Ak("CoCoa(Ice)", "25");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Ak("CoCoa(Frappe)", "30");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Ak("Milk(Hot)", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Ak("Milk(Ice)", "25");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Ak("Milk(Frappe)", "30");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Ak("Milk Tea(Ice)", "25");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Ak("Milk Tea(Frappe)", "30");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Ak("Lemon Tea(Ice)", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Ak("Lemon Tea(Frappe)", "30");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Ak("Milo(Hot)", "20");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Ak("Milo(Ice)", "25");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Ak("Milo(Frappe)", "30");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Ak("Nestea (Hot)", "20");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Ak("Nestea (Ice)", "25");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Ak("Nestea (Frappe)", "30");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Ak("Nestea Tea (Hot)", "20");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Ak("Nestea Tea (Ice)", "25");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Ak("Nestea Tea (Frappe)", "30");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Ak("Italian Soda (Ict)", "25");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Ak("Red lime Soda (Ice)", "25");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Ak("Honey lime Soda(Ice)", "25");
        }
        double ko;
        public string[] ListPrice()
        {
            ko = 0;
            string[] k = new string[listView1.Items.Count];
            int p = listView1.Items.Count;
            for (int i = 0; i < p; i++)
            {
                ko += double.Parse(listView1.Items[i].SubItems[1].Text);
                k[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label29.Text = ko.ToString();
            return k;
        }

        public string[] inListPrice()
        {
            string[] r = new string[listView1.Items.Count];
            int ko = listView1.Items.Count;
            for (int i = 0; i < ko; i++)
            {
                r[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return r;
        }
        public void sef()
        {
            string[] l = ListPrice();
            string[] m = inListPrice();
            string pk = "kikky coffee" + DateTime.Now.ToString("hhmmss_dd_yyyy");
            string pkbill = "kikky coffee";
            pkbill += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd/mm/yyyy") + "\r\n";
            pkbill += "Menu" + "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                pkbill += l[i] + new string(' ', 20) + m[i] + "Bath" + "\r\n";
            }
            pkbill += "\r\n";
            pkbill += "Total Price :" + label29.Text;
            System.IO.File.WriteAllText(u + @"\" + pk + ".txt",pkbill );
            textBox1.Text += pkbill + "\r\n" + "\r\n" + "\r\n"+"\r\n" + "Save File at " + l + @"\" + u + ".txt";
        }
        bool t = false;

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            if (t == false)
            {
                tabControl1.TabPages.Insert(1,Payment); t= true;
                tabControl1.SelectedTab = Payment;
            }
            else
            {
                tabControl1.SelectedTab = Payment;
            }
            if (listView1.Items.Count > 0)
                sef();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            t = false;
            tabControl1.Controls.Remove(Payment);
            label29.Text = " ";
            textBox1.Text = " ";
        }
    }
    
}
