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
   
    public partial class Form7 : Form
    { 
        DataTable managertable1;
        public Form7()
        {
            InitializeComponent();
        } 
        
        private void Form7_Load(object sender, EventArgs e)
        {
            this.managerTableAdapter1.Fill(this.dataSet11.MANAGER);
            managertable1 = dataSet11.Tables["MANAGER"];
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                DataRow foundRows = managertable1.Rows.Find(textBox1.Text); //키값으로 찾기
                if (foundRows == null)
                {
                    MessageBox.Show("아이디를 확인하세요.");

                    break;
                }
                string pw = foundRows["PASSWORD"].ToString();
                if (string.Compare(pw.Trim(), textBox2.Text, true) == 0) //Trim함수로 공백 삭제
                {
                    MessageBox.Show("접속 ID : " + textBox1.Text);
                    Form5.ID = textBox1.Text; //staff ID 전달
                    textBox1.Text = null;
                    textBox2.Text = null;
                    this.Close();
                    Form5 staff = new Form5();
                    staff.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("비밀번호를 확인하세요.");
                    break;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
