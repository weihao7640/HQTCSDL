
namespace do_an.form
{
    partial class NghiPhepCaNhan
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
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.cbb_mouth = new System.Windows.Forms.ComboBox();
            this.cbb_year = new System.Windows.Forms.ComboBox();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.dgv_NghiPhep = new System.Windows.Forms.DataGridView();
            this.lb_mouth = new System.Windows.Forms.Label();
            this.lb_year = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.maNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NghiPhep)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(582, 29);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "<<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(3, 19);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(360, 49);
            this.lb_title.TabIndex = 17;
            this.lb_title.Text = "Nghỉ phép";
            this.lb_title.Click += new System.EventHandler(this.lb_title_Click);
            // 
            // cbb_mouth
            // 
            this.cbb_mouth.FormattingEnabled = true;
            this.cbb_mouth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_mouth.Location = new System.Drawing.Point(89, 15);
            this.cbb_mouth.Name = "cbb_mouth";
            this.cbb_mouth.Size = new System.Drawing.Size(121, 24);
            this.cbb_mouth.TabIndex = 19;
            this.cbb_mouth.SelectedIndexChanged += new System.EventHandler(this.cbb_mouth_SelectedIndexChanged);
            // 
            // cbb_year
            // 
            this.cbb_year.FormattingEnabled = true;
            this.cbb_year.Location = new System.Drawing.Point(275, 15);
            this.cbb_year.Name = "cbb_year";
            this.cbb_year.Size = new System.Drawing.Size(121, 24);
            this.cbb_year.TabIndex = 20;
            this.cbb_year.SelectedIndexChanged += new System.EventHandler(this.cbb_year_SelectedIndexChanged);
            // 
            // btn_Loc
            // 
            this.btn_Loc.Location = new System.Drawing.Point(412, 14);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(104, 24);
            this.btn_Loc.TabIndex = 21;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = true;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // dgv_NghiPhep
            // 
            this.dgv_NghiPhep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NghiPhep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNghi,
            this.ngayNghi,
            this.lyDo,
            this.huongLuong});
            this.dgv_NghiPhep.Location = new System.Drawing.Point(27, 140);
            this.dgv_NghiPhep.Name = "dgv_NghiPhep";
            this.dgv_NghiPhep.RowHeadersWidth = 51;
            this.dgv_NghiPhep.RowTemplate.Height = 24;
            this.dgv_NghiPhep.Size = new System.Drawing.Size(662, 278);
            this.dgv_NghiPhep.TabIndex = 22;
            this.dgv_NghiPhep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Luong_CellContentClick);
            // 
            // lb_mouth
            // 
            this.lb_mouth.AutoSize = true;
            this.lb_mouth.Location = new System.Drawing.Point(34, 19);
            this.lb_mouth.Name = "lb_mouth";
            this.lb_mouth.Size = new System.Drawing.Size(49, 17);
            this.lb_mouth.TabIndex = 23;
            this.lb_mouth.Text = "Tháng";
            this.lb_mouth.Click += new System.EventHandler(this.lb_mouth_Click);
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Location = new System.Drawing.Point(232, 18);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(37, 17);
            this.lb_year.TabIndex = 24;
            this.lb_year.Text = "Năm";
            this.lb_year.Click += new System.EventHandler(this.lb_year_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Loc);
            this.groupBox1.Controls.Add(this.lb_year);
            this.groupBox1.Controls.Add(this.cbb_mouth);
            this.groupBox1.Controls.Add(this.lb_mouth);
            this.groupBox1.Controls.Add(this.cbb_year);
            this.groupBox1.Location = new System.Drawing.Point(27, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 45);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc";
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_reload.BackgroundImage = global::do_an.Properties.Resources.load;
            this.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reload.Location = new System.Drawing.Point(567, 100);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(30, 30);
            this.btn_reload.TabIndex = 33;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(603, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // maNghi
            // 
            this.maNghi.DataPropertyName = "MaNghi";
            this.maNghi.HeaderText = "Mã nghỉ";
            this.maNghi.MinimumWidth = 6;
            this.maNghi.Name = "maNghi";
            this.maNghi.Width = 125;
            // 
            // ngayNghi
            // 
            this.ngayNghi.DataPropertyName = "NgayNghi";
            this.ngayNghi.HeaderText = "Ngày nghỉ";
            this.ngayNghi.MinimumWidth = 6;
            this.ngayNghi.Name = "ngayNghi";
            this.ngayNghi.Width = 125;
            // 
            // lyDo
            // 
            this.lyDo.DataPropertyName = "LyDo";
            this.lyDo.HeaderText = "Lý do";
            this.lyDo.MinimumWidth = 6;
            this.lyDo.Name = "lyDo";
            this.lyDo.Width = 125;
            // 
            // huongLuong
            // 
            this.huongLuong.DataPropertyName = "HuongLuong";
            this.huongLuong.HeaderText = "Hưởng lương";
            this.huongLuong.MinimumWidth = 6;
            this.huongLuong.Name = "huongLuong";
            this.huongLuong.Width = 125;
            // 
            // NghiPhepCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_NghiPhep);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_title);
            this.Name = "NghiPhepCaNhan";
            this.Text = "NghiPhepCaNhan";
            this.Load += new System.EventHandler(this.NghiPhepCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NghiPhep)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.ComboBox cbb_mouth;
        private System.Windows.Forms.ComboBox cbb_year;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.DataGridView dgv_NghiPhep;
        private System.Windows.Forms.Label lb_mouth;
        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn lyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn huongLuong;
    }
}