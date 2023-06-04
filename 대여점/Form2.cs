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
    public partial class Form2 : Form
    {
        DataTable clientsTable1;
        public Boolean IDcheck = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            clientsTableAdapter1.Fill(dataSet11.CLIENTS);
            clientsTable1 = dataSet11.Tables["CLIENTS"];
        }

        private void btn_join(object sender, EventArgs e)
        {
            while (true) {
                if (IDcheck == false) { MessageBox.Show("아이디 중복검사를 하지 않았습니다."); break; }
                DataRow clientsDataRow = clientsTable1.NewRow();

                clientsDataRow["clientName"] = textBox1.Text;
                clientsDataRow["clientID"] = textBox2.Text;
                clientsDataRow["clientPassword"] = textBox3.Text;
                DateTime dt = DateTime.ParseExact(textBox4.Text, "yyyy-MM-dd", null);
                clientsDataRow["Birth"] = dt;
                clientsDataRow["PhoneNumber"] = textBox5.Text;
                clientsDataRow["email"] = textBox6.Text;
                clientsDataRow["panalty"] = 0;
                clientsTable1.Rows.Add(clientsDataRow);
                int numOfRows = clientsTableAdapter1.Update(dataSet11.CLIENTS);
                if (numOfRows < 1)
                {
                    MessageBox.Show("입력을 확인하세요."); 
                    break;
                }
                else
                {
                    MessageBox.Show("회원 가입 완료.");
                   
                } 
                this.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            DataRow foundRows = clientsTable1.Rows.Find(textBox2.Text); //키값으로 찾기
            if (foundRows == null)
            {
                IDcheck = true;
                MessageBox.Show("중복 확인 완료");
            }
            else
            {
                IDcheck = false;
                MessageBox.Show("아이디 중복, 다시 입력하세요.");

            }
           
        }
    }
}
