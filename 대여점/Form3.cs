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
    //사용자 모드
    public partial class Form3 : Form
    {
        public static string userName; //유저ID
        DataTable productTable1;
        DataTable clienttable1;
        DataTable rentalTable1;
        DataTable RentalMonth;
        DataTable RentalAll;
        public int selectedNum1;
        public int selectedNum2;
        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet2.MOVIETOP' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.mOVIETOPTableAdapter.Fill(this.dataSet2.MOVIETOP);

            // TODO: 이 코드는 데이터를 'dataSet11.RENTALS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rentalsTableAdapter1.FillByRentals(this.dataSet11.RENTALS,userName);
            rentalTable1 = dataSet11.Tables["RENTALS"];
            // TODO: 이 코드는 데이터를 'dataSt11.RESERVATION' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rESERVATIONTableAdapter.Fill(this.dataSet11.RESERVATION);
             this.productsTableAdapter1.Fill(this.dataSet11.PRODUCTS);
            productTable1 = dataSet11.Tables["PRODUCTS"];
            this.clientsTableAdapter1.Fill(this.dataSet11.CLIENTS);
            clienttable1 = dataSet11.Tables["CLIENTS"];

            DataRow foundRows = clienttable1.Rows.Find(userName); //키값으로 찾기
            textBox2.Text = foundRows["CLIENTID"].ToString();
            textBox3.Text = foundRows["CLIENTNAME"].ToString();
            textBox4.Text = foundRows["PHONENUMBER"].ToString();
            textBox5.Text = foundRows["email"].ToString();
            textBox6.Text = foundRows["PANALTY"].ToString();
            DateTime dt = Convert.ToDateTime(foundRows["BIRTH"]);
            textBox7.Text = dt.ToString("yyyy-MM-dd");

            //top대여
            this.mOVIETOPTableAdapter.Fill(this.dataSet2.MOVIETOP);
            RentalAll = dataSet2.Tables["MOVIETOP"];
            if (RentalAll != null)
            {
                foreach (DataRow row in RentalAll.Rows)
                {
                    chart1.Series[0].Points.AddXY(row["MOVIENAME"], row["TOTAL"]);
                }
            }

        }

        //
        // 벌금 지불
        //
        private void button8_Click(object sender, EventArgs e)
        {
            DataRow foundRows = clienttable1.Rows.Find(userName);
            MessageBox.Show(foundRows["PANALTY"]+"원 지불되었습니다.");
            foundRows["PANALTY"] = 0;
            int numOfRows1 = productsTableAdapter1.Update(dataSet11.PRODUCTS);
            textBox6.Text = "0";

        }
    

        //
        //상단
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("로그아웃 하시겠습니까?", " ",

                    MessageBoxButtons.OKCancel);

            //OK 클릭 시

            if (dialogResult == DialogResult.OK) { this.Close(); }
          
        }

        
        //
        //검색
        //
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "제목")
            {
                productsTableAdapter1.FillByMname(dataSet11.PRODUCTS, textBox1.Text);
            }
            else if (comboBox2.Text == "장르")
            {
                productsTableAdapter1.FillByMGanre(dataSet11.PRODUCTS, textBox1.Text);
            }
            else if(comboBox2.Text == "전체 조회")
            {
                this.productsTableAdapter1.Fill(this.dataSet11.PRODUCTS);
            }
            else if(comboBox2.Text == "대여 가능")
            {
                productsTableAdapter1.FillRentO(dataSet11.PRODUCTS);
            }
        }

        //
        //리뷰 확인
        //
        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            selectedNum1 = Convert.ToInt32(dr.Cells[0].Value);
            reviewForm.userID = userName;
            reviewForm.movieNum = selectedNum1;
            reviewForm review = new reviewForm();
            review.Show();

        }

       //
       //예약
       //
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            selectedNum1 = Convert.ToInt32(dr.Cells[0].Value);
            reservationForm.userID = userName;
            reservationForm.movieNum = selectedNum1;
            reservationForm reservation = new reservationForm();
            reservation.Show();
        }

        //
        //대여
        //
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            selectedNum1 = Convert.ToInt32(dr.Cells[0].Value);

            DataRow foundRows = productTable1.Rows.Find(selectedNum1); //키값으로 찾기
            if (Convert.ToInt32(foundRows["STOCK"]) == 0)
            {
                MessageBox.Show("재고가 없습니다. 예약을 해주세요.");
            }
            else
            {
                rentForm8.userID = userName;
                rentForm8.movieNum = selectedNum1;
                rentForm8 rent = new rentForm8();
                rent.Show();
                this.rentalsTableAdapter1.FillByRentals(this.dataSet11.RENTALS, userName);
            }
        }
        
        
        private void button4_Click(object sender, EventArgs e)
        {

        }
        

       
        //
        //반납 
        //
        private void button5_Click(object sender, EventArgs e)
        {

           
            rentalTable1 = dataSet11.Tables["RENTALS"];

            DataGridViewRow dr = dataGridView2.SelectedRows[0];
            selectedNum2 = Convert.ToInt32(dr.Cells[0].Value);
            int movieNum = Convert.ToInt32(dr.Cells[1].Value);

            DataRow myDataRow = rentalTable1.Rows.Find(selectedNum2);
            myDataRow["COMP"] = 0; //0이면 반납완료
            int numOfRows = rentalsTableAdapter1.Update(dataSet11.RENTALS);
            if (numOfRows < 1)
            {
                MessageBox.Show("실패");
            }
            else
            {
                MessageBox.Show("반납 신청 완료");

                this.rentalsTableAdapter1.FillByRentals(this.dataSet11.RENTALS, userName);
            }

            this.productsTableAdapter1.Fill(this.dataSet11.PRODUCTS);
            productTable1 = dataSet11.Tables["PRODUCTS"];

            DataRow productDataRow =  productTable1.Rows.Find(movieNum);
            int num = Convert.ToInt32(productDataRow["STOCK"]);
            productDataRow["STOCK"] = num + 1;
            int numOfRows1 = productsTableAdapter1.Update(dataSet11.PRODUCTS);
             this.rentalsTableAdapter1.FillByRentals(this.dataSet11.RENTALS, userName);
        }

        //
        //리뷰 작성
        //
        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView2.SelectedRows[0];
            selectedNum2 = Convert.ToInt32(dr.Cells[0].Value);

            DataRow foundRows = rentalTable1.Rows.Find(selectedNum2);
            int found = Convert.ToInt32(foundRows["MOVIENUM"]);

            clientReviewForm.userName = userName;
            clientReviewForm.movieNum = found;
           
            clientReviewForm review = new clientReviewForm();
            review.Show();
        }

        //
        // TOP 10
        //
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            chart1.Series["대여 수"].Points.Clear();
            if (comboBox1.Text == "전체 기간")
            {
                this.mOVIETOPTableAdapter.Fill(this.dataSet2.MOVIETOP);
                RentalAll = dataSet2.Tables["MOVIETOP"];
                if (RentalAll != null)
                {
                    foreach (DataRow row in RentalAll.Rows)
                    {
                        chart1.Series[0].Points.AddXY(row["MOVIENAME"], row["TOTAL"]);
                    }
                }
            }
            else if(comboBox1.Text == "이번 달")
            {
                this.moviE_MONTHTOPTableAdapter1.Fill(this.dataSet2.MOVIE_MONTHTOP);
                RentalMonth = dataSet2.Tables["MOVIE_MONTHTOP"];
                if (RentalMonth != null)
                {
                    foreach (DataRow row in RentalMonth.Rows)
                    {
                        chart1.Series[0].Points.AddXY(row["MOVIENAME"], row["TOTAL"]);
                    }
                }

            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        //새로고침
        private void button7_Click(object sender, EventArgs e)
        {
            this.rentalsTableAdapter1.FillByRentals(this.dataSet11.RENTALS, userName);
        }
    }
}
