
namespace 대여점
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_manager = new System.Windows.Forms.Button();
            this.btn_staff = new System.Windows.Forms.Button();
            this.btn_join = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.dataSet11 = new 대여점.DataSet1();
            this.clientsTableAdapter1 = new 대여점.DataSet1TableAdapters.CLIENTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(455, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(455, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 1);
            this.panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(455, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Location = new System.Drawing.Point(455, 323);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(451, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "UserID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(451, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_manager
            // 
            this.btn_manager.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_manager.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manager.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manager.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_manager.Location = new System.Drawing.Point(664, 12);
            this.btn_manager.Name = "btn_manager";
            this.btn_manager.Size = new System.Drawing.Size(75, 30);
            this.btn_manager.TabIndex = 10;
            this.btn_manager.Text = "manager";
            this.btn_manager.UseVisualStyleBackColor = false;
            this.btn_manager.Click += new System.EventHandler(this.btn_manager_Click);
            // 
            // btn_staff
            // 
            this.btn_staff.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_staff.Location = new System.Drawing.Point(745, 12);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(75, 30);
            this.btn_staff.TabIndex = 11;
            this.btn_staff.Text = "staff";
            this.btn_staff.UseVisualStyleBackColor = false;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // btn_join
            // 
            this.btn_join.FlatAppearance.BorderSize = 0;
            this.btn_join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_join.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_join.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_join.Location = new System.Drawing.Point(558, 354);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(75, 30);
            this.btn_join.TabIndex = 12;
            this.btn_join.Text = "+ join";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(194)))), ((int)(((byte)(85)))));
            this.btn_login.FlatAppearance.BorderSize = 2;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.Location = new System.Drawing.Point(558, 421);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 40);
            this.btn_login.TabIndex = 13;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.btn_staff);
            this.Controls.Add(this.btn_manager);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_manager;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.Button btn_login;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.CLIENTSTableAdapter clientsTableAdapter1;
    }
}

