using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_603410155_3
{
    public partial class Form1 : Form
    {
        string s_n = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        double p;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Fb_Click(object sender, EventArgs e)
        {

        }

        private void Ib_Click(object sender, EventArgs e)
        {

        }

        private void Hb_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CB_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tab_C.Controls.Remove(pay);
        }
        public void coff(string menu,string bath)
        {
            string[] pp = { menu, bath };
            var lv1 = new ListViewItem(pp);
            lv.Items.Add(lv1);
            LP();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            coff("GreeTea(Hot)", "20");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            coff("GreeTea(Ice)", "25");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            coff("GreeTea(Frappe)", "30");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            coff("ThaiTea(Hot)", "20");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            coff("ThaiTea(Ice)", "25");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            coff("ThaiTea(Frappe)", "30");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            coff("CoCoa(Hot)", "20");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            coff("CoCoa(Ice)", "25");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            coff("CoCoa(Frappe)", "30");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            coff("Milk(Hot)", "20");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            coff("Milk(Ice)", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            coff("Milk(Frappe)", "30");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            coff("MilkTea(Hot)", "20");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            coff("MilkTea(Ice)", "25");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            coff("MilkTea(Frappe)", "30");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            coff("LemonTea(Hot)", "20");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            coff("LemonTea(Ice)", "25");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            coff("LemonTea(Frappe)", "30");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            coff("Milo(Hot)", "20");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            coff("Milo(Ice)", "25");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coff("Milo(Frappe)", "30");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            coff("Nescafe(Hot)", "20");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            coff("Nescafe(Ice)", "25");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coff("Nescafe(Frappe)", "30");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            coff("NesteaTea(Hot)", "20");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            coff("NesteaTea(Ice)", "25");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coff("NesteaTea(Frappe)", "30");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            coff("Cantaloupe(Ice)", "25");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            coff("Red lime Soda(Ice)", "25");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            coff("BlueHawai(Ice)", "25");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            coff("Apple(Ice)", "25");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            coff("Strawbery(Ice)", "25");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            coff("Honey lime Soda(Ice)", "25");
        }
        public string[]LP()
        {
            p = 0;
            string[] s = new string[lv.Items.Count];
            int t = lv.Items.Count;
            for (int i = 0; i < t; i++)
            {
                p += double.Parse(lv.Items[i].SubItems[1].Text);
                s[i] = lv.Items[i].SubItems[0].Text.ToString();
            }
            tB.Text = p.ToString();
            return s;
        }
        public string[] inlp()
        {
            string[] s = new string[lv.Items.Count];
            int t = lv.Items.Count;
            for (int i = 0;i<t;i++)
            {
                s[i] = lv.Items[i].SubItems[1].Text.ToString();
            }
            return s;
        }
        public void se()
        {
            string[] s_u = LP();
            label33.Text = "";
            string[] n_o = inlp();
            string file = "peet_coffee" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string filebill = "peet_coffee";
            filebill += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd//mm//yyyy");
            filebill += "Menu" + "\r\n";
            for (int i = 0; i < lv.Items.Count; i++)
            {
                filebill += s_u[i] + new string(' ', 20) + n_o[i] + "Bath" + "\r\n";
            }
            filebill += "\r\n";
            filebill += "Totai price :" + tB.Text;
            System.IO.File.WriteAllText(s_n + @"\" + file + "txt", filebill);
            label33.Text += filebill + "\r\n" + "\r\n" + "\r\n" + "Save File at" + s_n + @"\" + file + ".txt";
        }
        

        private void Pay_m_Click(object sender, EventArgs e)
        {
            
        }

        private void C_Click(object sender, EventArgs e)
        {
            lv.Items.Clear();
            op = false;
            tab_C.Controls.Remove(pay);
            tB.Text = "";
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            coff("Esspresso(Hot)", "35");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            coff("Esspresso(Ice)", "45");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            coff("Esspresso(Frappe)", "50");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            coff("Americano(Hot)", "35");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            coff("Americano(Ice)", "45");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            coff("Americano(Frappe)", "50");
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            coff("Latte(Hot)", "35");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            coff("Latte(Ice)", "45");
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            coff("Latte(Frappe)", "50");
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            coff("Mocha(Hot)", "35");
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            coff("Mocha(Ice)", "45");
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            coff("Mocha(Frappe)", "50");
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            coff("Cappuccino(Hot)", "35");
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            coff("Cappuccino(Ice)", "45");
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            coff("Cappuccino(Frappe)", "50");
        }
        bool op = false;
        private void button50_Click(object sender, EventArgs e)
        {
            tB.Text = "";
            if (op == false)
            {
                tab_C.TabPages.Insert(1, pay);
                op = true;
                tab_C.SelectedTab = pay;
            }
            else tab_C.SelectedTab = pay;
            if (lv.Items.Count > 0)
                se();
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
