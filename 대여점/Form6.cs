using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 대여점
{
    public partial class Form6 : Form
    {
        private string mPW = "@1234";
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == mPW)
            {
                Form4 manager = new Form4();
                manager.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("PASSWORD ERROR");
                textBox1.Text = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
