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
    public partial class rentForm8 : Form
    {
        public static string userID;
        public static int movieNum;
        DateTime dt;
        DataTable productTable1;
        DataTable rentalTable1;
        DataTable staffTable1;
        public rentForm8()
        {
            InitializeComponent();
        }  
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void rentForm8_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.dataSet11.PRODUCTS);
            productTable1 = dataSet11.Tables["PRODUCTS"];
            this.rentalsTableAdapter1.Fill(this.dataSet11.RENTALS);
            rentalTable1 = dataSet11.Tables["RENTALS"];
            
            DataRow foundRows = productTable1.Rows.Find(movieNum); //키값으로 찾기
            textBox12.Text = foundRows["MOVIENAME"].ToString();
            textBox10.Text = foundRows["GANRE"].ToString();
            textBox8.Text = foundRows["ENTERTAINMENT"].ToString();
            textBox11.Text = foundRows["MOVIELENGTH"].ToString();
            textBox9.Text = foundRows["MOVIELOCATION"].ToString();
            textBox1.Text = foundRows["GRADE"].ToString();
            textBox2.Text = foundRows["PRICE"].ToString();
            textBox4.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dt = Convert.ToDateTime(textBox4.Text);
            textBox3.Text = dt.AddDays(14).ToString("yyyy-MM-dd");
            if (textBox1.Text == "1") { textBox7.Text = (int.Parse(textBox2.Text) * 0.3).ToString(); }
            else if (textBox1.Text == "2") { textBox7.Text = (int.Parse(textBox2.Text) * 0.2).ToString(); }
            else if (textBox1.Text == "3") { textBox7.Text = (int.Parse(textBox2.Text) * 0.1).ToString(); }
            label5.Text = "* 이 비디오의 등급은 "+textBox1.Text+"등급입니다. \n따라서 위의 벌금은 반납일 초과시\n부여되는 벌금입니다.";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DataRow rentalDataRow = rentalTable1.NewRow();
              
                rentalDataRow["MOVIENUM"] = movieNum;
                rentalDataRow["CLIENTID"] = userID;
                rentalDataRow["RENTALDATE"] = dt;
                rentalDataRow["RETURNDATE"] = dt.AddDays(14);
                rentalDataRow["COMP"] = 1; //1 대여중, 0 반납 완료

                rentalTable1.Rows.Add(rentalDataRow);
                int numOfRows = rentalsTableAdapter1.Update(dataSet11.RENTALS);
                if (numOfRows < 1)
                {
                    MessageBox.Show("대여 실패");
                }
                else
                {
                    MessageBox.Show("대여 성공");
                    this.Close();
                }


                DataRow foundRows = productTable1.Rows.Find(movieNum);
                int num = Convert.ToInt32(foundRows["STOCK"]);
                foundRows["STOCK"] = num - 1;
                int numOfRows2 = productsTableAdapter1.Update(dataSet11.PRODUCTS);
                
                
            }
            else MessageBox.Show("대여 내용을 확인해주세요.");
        }
    }
}
