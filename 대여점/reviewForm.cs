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
   
    public partial class reviewForm : Form
    {   public static int movieNum = 0;
        public static string userID;
        DataTable reviewtable1;
        public reviewForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reviewForm_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.REVIEW' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rEVIEWTableAdapter.FillByREVIEW(this.dataSet1.REVIEW,movieNum);
            reviewtable1 = dataSet1.Tables["REVIEW"];
        }
    }
}
