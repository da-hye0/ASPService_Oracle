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
    public partial class Form1 : Form
    {
        DataTable clienttable1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.clientsTableAdapter1.Fill(this.dataSet11.CLIENTS);
            clienttable1 = dataSet11.Tables["CLIENTS"];
        }
        //
        //회원가입
        //
        private void btn_join_Click(object sender, EventArgs e)
        {
            Form2 join = new Form2();
            join.Show();

        }
        //
        //아이디 로그인
        //TOTO : 비밀번호 암호화
        private void btn_login_Click(object sender, EventArgs e)
        {
            this.clientsTableAdapter1.Fill(this.dataSet11.CLIENTS);
            while (true)
            {
                DataRow foundRows = clienttable1.Rows.Find(textBox1.Text); //키값으로 찾기
                if (foundRows == null)
                {
                    MessageBox.Show("아이디를 확인하세요.");
                   
                    break;
                }
                string pw = foundRows["CLIENTPASSWORD"].ToString();
                if (string.Compare(pw.Trim(),textBox2.Text,true)==0) //Trim함수로 공백 삭제
                {
                    MessageBox.Show("접속 ID : "+textBox1.Text);
                    Form3.userName = textBox1.Text; //유저 ID 전달
                    textBox1.Text = null;
                    textBox2.Text = null;
                    Form3 user = new Form3();
                    user.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("비밀번호를 확인하세요.");
                    break;
                }
            }
        }
        //
        //관리자 모드
        //
        private void btn_manager_Click(object sender, EventArgs e)
        {
            Form6 rog = new Form6();
            rog.Show();
          
        }
        //
        //스태프
        //
        private void btn_staff_Click(object sender, EventArgs e)
        {
            Form7 rog = new Form7();
            rog.Show();
        }

        //
        //그림
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("프로그램을 종료 하시겠습니까?"," ", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK) { this.Close(); }
        }
    }

}
