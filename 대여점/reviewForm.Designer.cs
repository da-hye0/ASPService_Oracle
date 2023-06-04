
namespace 대여점
{
    partial class reviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reviewForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataSet1 = new 대여점.DataSet1();
            this.rEVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEVIEWTableAdapter = new 대여점.DataSet1TableAdapters.REVIEWTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rEVIEWBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rATINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEVIEWCONTENTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVIEWBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEVIEWBindingSource
            // 
            this.rEVIEWBindingSource.DataMember = "REVIEW";
            this.rEVIEWBindingSource.DataSource = this.dataSet1;
            // 
            // rEVIEWTableAdapter
            // 
            this.rEVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIENTIDDataGridViewTextBoxColumn,
            this.rATINGDataGridViewTextBoxColumn,
            this.rEVIEWCONTENTSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEVIEWBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(32, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(767, 419);
            this.dataGridView1.TabIndex = 8;
            // 
            // rEVIEWBindingSource1
            // 
            this.rEVIEWBindingSource1.DataMember = "REVIEW";
            this.rEVIEWBindingSource1.DataSource = this.dataSet1;
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENTID";
            this.cLIENTIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.cLIENTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            this.cLIENTIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rATINGDataGridViewTextBoxColumn
            // 
            this.rATINGDataGridViewTextBoxColumn.DataPropertyName = "RATING";
            this.rATINGDataGridViewTextBoxColumn.HeaderText = "★";
            this.rATINGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rATINGDataGridViewTextBoxColumn.Name = "rATINGDataGridViewTextBoxColumn";
            this.rATINGDataGridViewTextBoxColumn.Width = 125;
            // 
            // rEVIEWCONTENTSDataGridViewTextBoxColumn
            // 
            this.rEVIEWCONTENTSDataGridViewTextBoxColumn.DataPropertyName = "REVIEWCONTENTS";
            this.rEVIEWCONTENTSDataGridViewTextBoxColumn.HeaderText = "Review";
            this.rEVIEWCONTENTSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rEVIEWCONTENTSDataGridViewTextBoxColumn.Name = "rEVIEWCONTENTSDataGridViewTextBoxColumn";
            this.rEVIEWCONTENTSDataGridViewTextBoxColumn.Width = 460;
            // 
            // reviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reviewForm";
            this.Load += new System.EventHandler(this.reviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEVIEWBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rEVIEWBindingSource;
        private DataSet1TableAdapters.REVIEWTableAdapter rEVIEWTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rEVIEWBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rATINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEVIEWCONTENTSDataGridViewTextBoxColumn;
    }
}