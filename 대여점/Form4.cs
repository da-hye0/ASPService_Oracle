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
    public partial class Form4 : Form
    {

        DataTable productTable1;
        DataTable rentalTable1;
        DataTable rentalTitleTable;
        DataTable MovieRentalTable;
        DataTable RentalMonth;
        DataTable RentalWeek;
        DataTable MonthTable;
        DataTable rentalMonthTop;
        DataTable rentalWeekTop;
        DataTable rentalAll;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet2.RENTAL_MON' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rENTAL_MONTableAdapter.Fill(this.dataSet2.RENTAL_MON);
            // TODO: 이 코드는 데이터를 'dataSet2.RENTAL_TITLE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rENTAL_TITLETableAdapter.Fill(this.dataSet2.RENTAL_TITLE);
            // TODO: 이 코드는 데이터를 'dataSet1.RENTALS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rENTALSTableAdapter.Fill(this.dataSet1.RENTALS);
            // TODO: 이 코드는 데이터를 'dataSet1.PRODUCTS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.productsTableAdapter1.Fill(this.dataSet1.PRODUCTS);


            productsTableAdapter1.Fill(dataSet11.PRODUCTS);
            productTable1 = dataSet11.Tables["PRODUCTS"];
            rENTALSTableAdapter.FillWithName(this.dataSet1.RENTALS);
            rentalTable1 = (this.dataSet1.RENTALS);
            rENTAL_TITLETableAdapter.Fill(dataSet2.RENTAL_TITLE);
            rentalTitleTable = dataSet2.Tables["RENTAL_TITLE"];

            DateTime dt = DateTime.Now.Date;
            string n = dt.ToString("yyyyMMdd");
            moviE_RENTALTableAdapter1.FillSearchDate(this.dataSet2.MOVIE_RENTAL, Convert.ToInt32(n));
            MovieRentalTable = dataSet2.Tables["MOVIE_RENTAL"];
            int totalNum = 0, totalPrice = 0;
            if (MovieRentalTable != null)
            {
                foreach (DataRow row in MovieRentalTable.Rows)
                {
                    listBox2.Items.Add(row["MOVIENAME"].ToString() + " " + row["COUNTRENT"].ToString());
                    chart2.Series[0].Points.AddXY(row["MOVIENAME"], row["COUNTRENT"]);
                    totalNum += Convert.ToInt32(row["COUNTRENT"]);
                    totalPrice += Convert.ToInt32(row["COUNTRENT"]) * Convert.ToInt32(row["PRICE"]);

                }
            }
            else MessageBox.Show("해당 일 매출 내역이 없습니다.");
            textBox8.Text = totalNum.ToString();
            textBox14.Text = totalPrice.ToString();


            //년 매출
            this.rENTAL_MONTableAdapter.Fill(this.dataSet2.RENTAL_MON);
            rentalTable1 = dataSet2.Tables["RENTAL_MON"];

            if (rentalTable1 != null)
            {
                foreach (DataRow row in rentalTable1.Rows)
                {
                    chart3.Series[0].Points.AddXY(row["MONTHLYDATA"], row["SALES"]);
                }
            }
            //top
            this.movietopTableAdapter1.Fill(this.dataSet2.MOVIETOP);
            rentalAll = dataSet2.Tables["MOVIETOP"];
            if (rentalAll != null)
            {
                foreach (DataRow row in rentalAll.Rows)
                {
                    chart1.Series[0].Points.AddXY(row["MOVIENAME"], row["TOTAL"]);
                }
            }
        }

        //
        //상단
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("로그아웃 하시겠습니까?", "Inform",

                    MessageBoxButtons.OKCancel);

            //OK 클릭 시

            if (dialogResult == DialogResult.OK) { this.Close(); }
        }

        //
        //비디오 등록
        //
        //TODO
        //시퀀스 사용
        private void button2_Click(object sender, EventArgs e)
        {
            DataRow productDataRow = productTable1.NewRow();
            //productDataRow["MOVIENUM"] = 114;
            productDataRow["MOVIENAME"] = textBox1.Text;
            productDataRow["ENTERTAINMENT"] = textBox2.Text;
            productDataRow["MOVIELENGTH"] = int.Parse(textBox3.Text);
            productDataRow["PRICE"] = int.Parse(textBox4.Text);
            productDataRow["STOCK"] = int.Parse(textBox5.Text);
            productDataRow["GRADE"] = int.Parse(textBox6.Text);
            productDataRow["GANRE"] = textBox11.Text;
            productDataRow["YEAR"] = int.Parse(textBox12.Text);
            productDataRow["MOVIELOCATION"] = comboBox1.Text + comboBox2.Text;

            productTable1.Rows.Add(productDataRow);
            int numOfRows = productsTableAdapter1.Update(dataSet11.PRODUCTS);
            if (numOfRows < 1)
            {
                MessageBox.Show("입력을 확인하세요.");
            }
            else
            {
                MessageBox.Show("비디오 등록 완료.");
                productsTableAdapter1.Fill(dataSet11.PRODUCTS);
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                textBox6.Text = null;
                textBox11.Text = null;
                textBox12.Text = null;
                comboBox1.Text = null;
                comboBox2.Text = null;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox11.Text = listBox1.SelectedItem.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox11.Text = null;
            textBox12.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
        }
        //
        //비디오 삭제
        //
        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow dr = dataGridView2.SelectedRows[0];
            string Mnum = dr.Cells[0].Value.ToString();
            DataRow foundRows = productTable1.Rows.Find(Mnum);
            textBox10.Text = foundRows["MOVIENUM"].ToString();
            textBox15.Text = foundRows["PRICE"].ToString();

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (domainUpDown3.Text == "영화 제목")
            {
                productsTableAdapter1.FillByMname(dataSet11.PRODUCTS, textBox1.Text);
            }
            else if (domainUpDown3.Text == "장르")
            {
                productsTableAdapter1.FillByMGanre(dataSet11.PRODUCTS, textBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(dataSet11.PRODUCTS);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView2.SelectedRows[0];
            string Mnum = dr.Cells[0].Value.ToString();

            DataRow foundRows = productTable1.Rows.Find(Mnum); //키값으로 찾기
            if (foundRows != null)
            {
                foundRows.Delete();
                int numOfRows = productsTableAdapter1.Update(dataSet11.PRODUCTS);
                if (numOfRows < 1)
                {
                    textBox10.Text = null;
                    textBox9.Text = null;
                    MessageBox.Show("입력을 확인하세요");
                }
                else MessageBox.Show("삭제 완료");
                productsTableAdapter1.Fill(dataSet11.PRODUCTS);
            }
            else
            {
                MessageBox.Show("삭제 할 데이터가 없습니다.");
            }
        }


        //
        // 비디오 요금 수정
        //
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView2.SelectedRows[0];
            string Mnum = dr.Cells[0].Value.ToString();

            DataRow foundRows = productTable1.Rows.Find(Mnum); //키값으로 찾기
            foundRows["PRICE"] = Convert.ToInt32(textBox15.Text);
            int numOfRows = productsTableAdapter1.Update(dataSet11.PRODUCTS);
            if (numOfRows < 1)
            {
                MessageBox.Show("수정 실패");
            }
            else MessageBox.Show("수정 완료");

        }

        //
        //대여 검색
        //
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "전체 검색")
            {
                this.rENTAL_TITLETableAdapter.FillBySearchTitle(this.dataSet2.RENTAL_TITLE, textBox13.Text);
            }
            else if (comboBox3.Text == "대여중")
            {
                this.rENTAL_TITLETableAdapter.FillBy(this.dataSet2.RENTAL_TITLE, textBox13.Text, 1);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        //
        //일 매출 현황
        //
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            chart2.Series["매출"].Points.Clear();
            listBox2.Text = null;
            int s = Convert.ToInt32(textBox7.Text);
            moviE_RENTALTableAdapter1.FillSearchDate(this.dataSet2.MOVIE_RENTAL, s);
            MovieRentalTable = dataSet2.Tables["MOVIE_RENTAL"];

            int totalNum = 0, totalPrice = 0;
            if (MovieRentalTable != null)
            {
                foreach (DataRow row in MovieRentalTable.Rows)
                {
                    listBox2.Items.Add(row["MOVIENAME"].ToString() + " " + row["COUNTRENT"].ToString());
                    chart2.Series[0].Points.AddXY(row["MOVIENAME"], row["COUNTRENT"]);
                    totalNum += Convert.ToInt32(row["COUNTRENT"]);
                    totalPrice += Convert.ToInt32(row["COUNTRENT"]) * Convert.ToInt32(row["PRICE"]);
                   
                }
            }
            else MessageBox.Show("해당 일 매출 내역이 없습니다.");

            textBox8.Text = totalNum.ToString();
            textBox14.Text = totalPrice.ToString();
        }

        //
        //주, 월 인기 품목 현황
        //
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            chart1.Series["대여 수"].Points.Clear();
           
            if (comboBox4.Text == "전체")
            {
                this.movietopTableAdapter1.Fill(this.dataSet2.MOVIETOP);
                rentalAll = dataSet2.Tables["MOVIETOP"];
                if (rentalAll != null)
                {
                    foreach (DataRow row in rentalAll.Rows)
                    {
                        chart1.Series[0].Points.AddXY(row["MOVIENAME"], row["TOTAL"]);
                    }
                }
            }
            else if (comboBox4.Text == "이번 달")
            {
                this.moviE_MONTHTOPTableAdapter1.Fill(this.dataSet2.MOVIE_MONTHTOP);
                rentalMonthTop = dataSet2.Tables["MOVIE_MONTHTOP"];
                if (rentalMonthTop != null)
                {
                    foreach (DataRow row in rentalMonthTop.Rows)
                    {
                        chart1.Series[0].Points.AddXY(row["MOVIENAME"], row["TOTAL"]);
                    }
                }

            }
            else if(comboBox4.Text=="이번 주")
            {
                moviE_WEEKTOPTableAdapter1.Fill(this.dataSet2.MOVIE_WEEKTOP);
                rentalWeekTop = dataSet2.Tables["MOVIE_WEEKTOP"];
                if (rentalWeekTop != null)
                {
                    foreach (DataRow row in rentalWeekTop.Rows)
                    {
                        chart1.Series[0].Points.AddXY(row["MOVIENAME"], row["TOTAL"]);
                    }
                }


            }
            


        }

        //
        // 월별 매출
        //
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(comboBox5.Text == "매출")
            {
                chart3.Series["대여 수"].Points.Clear();
               
                this.rENTAL_MONTableAdapter.Fill(this.dataSet2.RENTAL_MON);
                rentalTable1 = dataSet2.Tables["RENTAL_MON"];

                if (rentalTable1 != null)
                {
                    foreach (DataRow row in rentalTable1.Rows)
                    {
                        chart3.Series[0].Points.AddXY(row["MONTHLYDATA"], row["SALES"]);
                    }
                }
               

            }
            else if(comboBox5.Text =="대여")
            {
                chart3.Series["대여 수"].Points.Clear();
                this.rENTAL_MONTableAdapter.Fill(this.dataSet2.RENTAL_MON);
                rentalTable1 = dataSet2.Tables["RENTAL_MON"];
                if (rentalTable1 != null)
                {
                    foreach (DataRow row in rentalTable1.Rows)
                    {
                        chart3.Series[0].Points.AddXY(row["MONTHLYDATA"], row["RENTALALL"]);
                    }
                }
            }

        }

      
    }
}

