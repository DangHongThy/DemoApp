using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace demo
{
    public partial class FrmCoffeeShop : Form
    {
        public FrmCoffeeShop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;
        } 

    }
}
