
namespace TranTuanKiet_QLNS.GUI
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBNS = new System.Windows.Forms.TextBox();
            this.TBNAME = new System.Windows.Forms.TextBox();
            this.TBID = new System.Windows.Forms.TextBox();
            this.CBNAME = new System.Windows.Forms.ComboBox();
            this.DTNGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THEM = new System.Windows.Forms.Button();
            this.THOAT = new System.Windows.Forms.Button();
            this.SUA = new System.Windows.Forms.Button();
            this.XOA = new System.Windows.Forms.Button();
            this.TBGT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MÃ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ĐƠN VỊ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "HỌ TÊN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "NOI SINH";
            // 
            // TBNS
            // 
            this.TBNS.Location = new System.Drawing.Point(345, 47);
            this.TBNS.Name = "TBNS";
            this.TBNS.Size = new System.Drawing.Size(232, 27);
            this.TBNS.TabIndex = 5;
            // 
            // TBNAME
            // 
            this.TBNAME.Location = new System.Drawing.Point(345, 6);
            this.TBNAME.Name = "TBNAME";
            this.TBNAME.Size = new System.Drawing.Size(232, 27);
            this.TBNAME.TabIndex = 6;
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(79, 6);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(135, 27);
            this.TBID.TabIndex = 7;
            // 
            // CBNAME
            // 
            this.CBNAME.FormattingEnabled = true;
            this.CBNAME.Location = new System.Drawing.Point(79, 46);
            this.CBNAME.Name = "CBNAME";
            this.CBNAME.Size = new System.Drawing.Size(151, 28);
            this.CBNAME.TabIndex = 8;
            // 
            // DTNGAYSINH
            // 
            this.DTNGAYSINH.Location = new System.Drawing.Point(674, 6);
            this.DTNGAYSINH.Name = "DTNGAYSINH";
            this.DTNGAYSINH.Size = new System.Drawing.Size(305, 27);
            this.DTNGAYSINH.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "NGÀY SINH";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(46, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(921, 176);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ROW);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MÃ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "HỌ TÊN";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NGÀY SINH";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "GIỚI TÍNH";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NƠI SINH";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 160;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ĐƠN VỊ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // THEM
            // 
            this.THEM.Location = new System.Drawing.Point(103, 368);
            this.THEM.Name = "THEM";
            this.THEM.Size = new System.Drawing.Size(94, 29);
            this.THEM.TabIndex = 13;
            this.THEM.Text = "THÊM";
            this.THEM.UseVisualStyleBackColor = true;
            this.THEM.Click += new System.EventHandler(this.THEM_Click);
            // 
            // THOAT
            // 
            this.THOAT.Location = new System.Drawing.Point(674, 368);
            this.THOAT.Name = "THOAT";
            this.THOAT.Size = new System.Drawing.Size(94, 29);
            this.THOAT.TabIndex = 14;
            this.THOAT.Text = "THOÁT";
            this.THOAT.UseVisualStyleBackColor = true;
            this.THOAT.Click += new System.EventHandler(this.THOAT_Click);
            // 
            // SUA
            // 
            this.SUA.Location = new System.Drawing.Point(504, 368);
            this.SUA.Name = "SUA";
            this.SUA.Size = new System.Drawing.Size(94, 29);
            this.SUA.TabIndex = 15;
            this.SUA.Text = "SỮA";
            this.SUA.UseVisualStyleBackColor = true;
            this.SUA.Click += new System.EventHandler(this.SUA_Click);
            // 
            // XOA
            // 
            this.XOA.Location = new System.Drawing.Point(295, 368);
            this.XOA.Name = "XOA";
            this.XOA.Size = new System.Drawing.Size(94, 29);
            this.XOA.TabIndex = 16;
            this.XOA.Text = "XÓA";
            this.XOA.UseVisualStyleBackColor = true;
            this.XOA.Click += new System.EventHandler(this.XOA_Click);
            // 
            // TBGT
            // 
            this.TBGT.Location = new System.Drawing.Point(95, 101);
            this.TBGT.Name = "TBGT";
            this.TBGT.Size = new System.Drawing.Size(135, 27);
            this.TBGT.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Giới tinh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 429);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBGT);
            this.Controls.Add(this.XOA);
            this.Controls.Add(this.SUA);
            this.Controls.Add(this.THOAT);
            this.Controls.Add(this.THEM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTNGAYSINH);
            this.Controls.Add(this.CBNAME);
            this.Controls.Add(this.TBID);
            this.Controls.Add(this.TBNAME);
            this.Controls.Add(this.TBNS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBNS;
        private System.Windows.Forms.TextBox TBNAME;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.ComboBox CBNAME;
        private System.Windows.Forms.DateTimePicker DTNGAYSINH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button THEM;
        private System.Windows.Forms.Button THOAT;
        private System.Windows.Forms.Button SUA;
        private System.Windows.Forms.Button XOA;
        private System.Windows.Forms.TextBox TBGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}