using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FİBONACCİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static long fibonacci1(int sayi)
        {
            if (sayi == 0 || sayi == 1)
                return 1;
            else
            {
                return fibonacci1(sayi - 1) + fibonacci1(sayi - 2);
            }

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(guna2TextBox3.Text);
            guna2TextBox1.Text = fibonacci1(sayi).ToString();
        }
    }
}
