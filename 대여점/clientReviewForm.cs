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
    public partial class clientReviewForm : Form
    {
        public static string userName;
        public static int movieNum;
        DataTable reviewtable1;
        public clientReviewForm()
        {
            InitializeComponent();
        }

        private void clientReviewForm_Load(object sender, EventArgs e)
        {
            this.reviewTableAdapter1.FillByREVIEW(this.dataSet11.REVIEW, movieNum);
            reviewtable1 = dataSet11.Tables["REVIEW"];
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            DataRow reviewDataRow = reviewtable1.NewRow();

            reviewDataRow["MOVIENUM"] = movieNum;
            reviewDataRow["CLIENTID"] = userName;
            reviewDataRow["REVIEWCONTENTS"] = richTextBox1.Text;
            reviewDataRow["RATING"] = comboBox1.SelectedItem;
            reviewtable1.Rows.Add(reviewDataRow);
            int numOfRows = reviewTableAdapter1.Update(dataSet11.REVIEW);
            if (numOfRows < 1)
            {
                MessageBox.Show("저장 실패.");
                
            }
            else
            {
                MessageBox.Show("리뷰 저장 완료!");
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
