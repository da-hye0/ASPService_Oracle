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
    public partial class reservationForm : Form
    {
        public static string userID;
        public static int movieNum;
        DataTable productTable1;
        DataTable reservationTable1;
        public reservationForm()
        {
            InitializeComponent();
        }
        private void reservationForm_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.dataSet11.PRODUCTS);
            productTable1 = dataSet11.Tables["PRODUCTS"];
            this.reservationTableAdapter1.Fill(this.dataSet11.RESERVATION);
            reservationTable1 = dataSet11.Tables["RESERVATION"];
            
            
            DataRow foundRows = productTable1.Rows.Find(movieNum); //키값으로 찾기
            textBox1.Text = userID;
            textBox2.Text = foundRows["MOVIENAME"].ToString();
            textBox3.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        //
        //예약
        // 예약번호 시퀀스
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow reservatuonDataRow = reservationTable1.NewRow();
            reservatuonDataRow["MOVIENUM"]= movieNum;
            reservatuonDataRow["CLIENTID"] = userID;
            reservatuonDataRow["RESERVATIONDATE"] = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));

            reservationTable1.Rows.Add(reservatuonDataRow);
            
            int numOfRows = reservationTableAdapter1.Update(dataSet11.RESERVATION);
            if (numOfRows < 1)
            {
                MessageBox.Show("예약불가");
            }
            else
            {
                MessageBox.Show("예약 완료. 대여 가능시 알림을 보내드립니다.");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.reservationTableAdapter1.Fill(this.dataSet11.RESERVATION);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
