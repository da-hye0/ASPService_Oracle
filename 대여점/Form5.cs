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
    public partial class Form5 : Form
    {
        DataTable clienttable1;
        DataTable productTable1;
        DataTable blacklistTable1;
        DataTable staffTable;
        DataTable rentalStaff;
        DataTable staffIDTable;
        public char locateClick = '0';
        public static string ID;
       
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet2.RENTAL_STAFF' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
           
           
            // TODO: 이 코드는 데이터를 'dataSet2.RENTAL_TITLE' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rENTAL_TITLETableAdapter.Fill(this.dataSet2.RENTAL_TITLE);
            // TODO: 이 코드는 데이터를 'dataSet11.PRODUCTS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.pRODUCTSTableAdapter.Fill(this.dataSet11.PRODUCTS);
            productTable1 = dataSet11.Tables["PRODUCTS"];
            this.clientsTableAdapter1.Fill(this.dataSet11.CLIENTS);
            clienttable1 = dataSet11.Tables["CLIENTS"];
            this.blacklistsTableAdapter1.Fill(dataSet11.BLACKLISTS);
            blacklistTable1 = dataSet11.Tables["BLACKLISTS"];

            this.rentalsTableAdapter1.FillStandBy(dataSet11.RENTALS);
            rentalStaff = dataSet11.Tables["RENTALS"];

            textBox11.Text = ID;
        }

        //
        // 상단
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("로그아웃 하시겠습니까?", "Inform",MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK) { this.Close(); }
        }

        
        //
        //회원 조회
        //
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string selID = dr.Cells[0].Value.ToString();
     
            DataRow foundRows = clienttable1.Rows.Find(selID); //키값으로 찾기
            textBox2.Text = foundRows["CLIENTID"].ToString();
            textBox3.Text = foundRows["CLIENTNAME"].ToString();
            DateTime dt = Convert.ToDateTime(foundRows["BIRTH"]);
            textBox4.Text = dt.ToString("yyyy-MM-dd");
            textBox5.Text = foundRows["PHONENUMBER"].ToString();
            textBox6.Text = foundRows["email"].ToString();
            textBox7.Text = foundRows["PANALTY"].ToString();
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "ID") {
                clientsTableAdapter1.FillByID(dataSet11.CLIENTS, textBox1.Text);
            }
            else if (comboBox2.Text == "이름")
            {
                clientsTableAdapter1.FillByNAME(dataSet11.CLIENTS, textBox1.Text);
            }
        }

        
        //
        //위치 찾기
        //
        //
        //FullRowSelection
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "영화 번호")
            {
                pRODUCTSTableAdapter.FillByMnum(dataSet11.PRODUCTS, int.Parse(textBox8.Text));
            }
            else if (comboBox1.Text == "영화 제목")
            {
                pRODUCTSTableAdapter.FillByMname(dataSet11.PRODUCTS, textBox8.Text);
            }
        }
        
        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            
            
            DataGridViewRow dr = dataGridView2.SelectedRows[0];
            Decimal selNum = Convert.ToDecimal(dr.Cells[0].Value);
            
            DataRow foundRows = productTable1.Rows.Find(selNum); //키값으로 찾기
            string location = foundRows["MOVIELOCATION"].ToString();
           
            char c = location[0];
            char f = location[1];

            if(locateClick != '0')
            {
                if (locateClick == 'A') { button2.BackColor = Color.FromArgb(255, 255, 255); }
                else if (locateClick == 'B') {  button3.BackColor = Color.FromArgb(255, 255, 255); }
                else if (locateClick == 'C') {  button5.BackColor = Color.FromArgb(255, 255, 255); }
                else if (locateClick == 'D') {  button6.BackColor = Color.FromArgb(255, 255, 255); }
                else if (locateClick == 'E') {  button7.BackColor = Color.FromArgb(255, 255, 255); }
                else if (locateClick == 'F') {  button8.BackColor = Color.FromArgb(255, 255, 255); }
                else if (locateClick == 'G') {  button9.BackColor = Color.FromArgb(255, 255, 255); }
                else if (locateClick == 'H') {  button10.BackColor = Color.FromArgb(255, 255, 255); }
                else if (locateClick == 'I') { button11.BackColor = Color.FromArgb(255, 255, 255); }
                locateClick = '0';
            }
           
            if (c == 'A') { locateClick = 'A';  button2.BackColor = Color.FromArgb(253, 190, 63); }
            else if (c == 'B') { locateClick = 'B'; button3.BackColor = Color.FromArgb(253, 190, 63); }
            else if (c == 'C') { locateClick = 'C'; button5.BackColor = Color.FromArgb(253, 190, 63); }
            else if (c == 'D') { locateClick = 'D'; button6.BackColor = Color.FromArgb(253, 190, 63); }
            else if (c == 'E') { locateClick = 'E'; button7.BackColor = Color.FromArgb(253, 190, 63); }
            else if (c == 'F') { locateClick = 'F'; button8.BackColor = Color.FromArgb(253, 190, 63); }
            else if (c == 'G') { locateClick = 'G'; button9.BackColor = Color.FromArgb(253, 190, 63); }
            else if (c == 'H') { locateClick = 'H'; button10.BackColor = Color.FromArgb(253, 190, 63); }
            else if (c == 'I') { locateClick = 'I'; button11.BackColor = Color.FromArgb(253, 190, 63); }
            
            label1.Text = c + "보관함의 " + f + "번째 칸에 있습니다. ";
        }

        //
        // 블랙리스트
        //

        private void button13_Click(object sender, EventArgs e)
        {
            DataRow blacklistDataRow = blacklistTable1.NewRow();
            blacklistDataRow["clientID"] = textBox10.Text;
            blacklistDataRow["reason"] = textBox9.Text;
            blacklistTable1.Rows.Add(blacklistDataRow);
            int numOfRows = blacklistsTableAdapter1.Update(dataSet11.BLACKLISTS);
            if (numOfRows < 1)
            {
                textBox10.Text = null;
                textBox9.Text = null;
                MessageBox.Show("입력을 확인하세요");
            }
            else MessageBox.Show("블랙 리스트 추가 완료");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            blacklistsTableAdapter1.FillByBlalistID(dataSet11.BLACKLISTS, textBox7.Text);
        }
   
        private void button12_Click(object sender, EventArgs e)
        {
            blacklistsTableAdapter1.Fill(dataSet11.BLACKLISTS);
        } 
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView3.SelectedRows[0];
            string key = dr.Cells[0].Value.ToString();

            DataRow foundRows = blacklistTable1.Rows.Find(key);
            if (foundRows != null)
            {
                foundRows.Delete();
                int numOfRows = blacklistsTableAdapter1.Update(dataSet11.BLACKLISTS);
                if (numOfRows < 1)
                {
                    MessageBox.Show("입력을 확인하세요");
                }
                else MessageBox.Show("삭제 완료");
                blacklistsTableAdapter1.Fill(dataSet11.BLACKLISTS);
            }
            else
            {
                MessageBox.Show("삭제 할 데이터가 없습니다.");
            }
        }

        //
        // 반납 관리
        //

        private void dataGridView5_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView5.SelectedRows[0];
            int rentalnum = Convert.ToInt32(dr.Cells[1].Value);
            textBox13.Text = rentalnum.ToString();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(comboBox3.Text == "승인 대기 항목")
            {
                this.rentalsTableAdapter1.FillStandBy(dataSet11.RENTALS);
                rentalStaff = dataSet11.Tables["RENTALS"];

            }
            else if (comboBox3.Text == "승인 완료 항목")
            {
                this.rentalsTableAdapter1.FillNotStandBy(dataSet11.RENTALS);
                rentalStaff = dataSet11.Tables["RENTALS"];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.clientsTableAdapter1.Fill(this.dataSet11.CLIENTS);
            DataGridViewRow dr = dataGridView5.SelectedRows[0];
            String userID = dr.Cells[0].Value.ToString();
            int rentalnum = Convert.ToInt32(dr.Cells[1].Value);

            DataRow foundRows = clienttable1.Rows.Find(userID); //키값으로 찾기
            foundRows["PANALTY"] = Convert.ToInt32(textBox12.Text);
           
            int numOfRows = clientsTableAdapter1.Update(dataSet11.CLIENTS);
            if (numOfRows < 1)
            {
                MessageBox.Show("입력을 확인하세요");
            }
            else MessageBox.Show("벌금 입력 완료");

            this.rentalsTableAdapter1.FillStandBy(dataSet11.RENTALS);
            rentalStaff = dataSet11.Tables["RENTALS"];
            DataRow foundRows2 = rentalStaff.Rows.Find(rentalnum);
            foundRows2["STAFFID"] = ID;
            int numOfRows2 = rentalsTableAdapter1.Update(dataSet11.RENTALS);
            if (numOfRows2 < 1)
            {
                MessageBox.Show("입력을 확인하세요");
            }
            else MessageBox.Show("반납 승인 완료");

        }

       
    }
}
