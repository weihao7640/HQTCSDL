
namespace do_an.form
{
    partial class LuongNV
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
            this.dgv_Luong = new System.Windows.Forms.DataGridView();
            this.maLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.lb_year = new System.Windows.Forms.Label();
            this.cbb_month = new System.Windows.Forms.ComboBox();
            this.lb_mouth = new System.Windows.Forms.Label();
            this.cbb_year = new System.Windows.Forms.ComboBox();
            this.btn_reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(668, 21);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "<<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(12, 18);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(563, 49);
            this.lb_title.TabIndex = 28;
            this.lb_title.Text = "Lương";
            // 
            // dgv_Luong
            // 
            this.dgv_Luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Luong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLuong,
            this.thang,
            this.nam,
            this.luongThang});
            this.dgv_Luong.Location = new System.Drawing.Point(32, 153);
            this.dgv_Luong.Name = "dgv_Luong";
            this.dgv_Luong.RowHeadersWidth = 51;
            this.dgv_Luong.RowTemplate.Height = 24;
            this.dgv_Luong.Size = new System.Drawing.Size(698, 267);
            this.dgv_Luong.TabIndex = 30;
            this.dgv_Luong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Luong_CellContentClick);
            // 
            // maLuong
            // 
            this.maLuong.DataPropertyName = "MaLuong";
            this.maLuong.HeaderText = "Mã Lương";
            this.maLuong.MinimumWidth = 6;
            this.maLuong.Name = "maLuong";
            this.maLuong.Width = 125;
            // 
            // thang
            // 
            this.thang.DataPropertyName = "Thang";
            this.thang.HeaderText = "Tháng";
            this.thang.MinimumWidth = 6;
            this.thang.Name = "thang";
            this.thang.Width = 125;
            // 
            // nam
            // 
            this.nam.DataPropertyName = "Nam";
            this.nam.HeaderText = "Năm";
            this.nam.MinimumWidth = 6;
            this.nam.Name = "nam";
            this.nam.Width = 125;
            // 
            // luongThang
            // 
            this.luongThang.DataPropertyName = "LuongThang";
            this.luongThang.HeaderText = "Lương";
            this.luongThang.MinimumWidth = 6;
            this.luongThang.Name = "luongThang";
            this.luongThang.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Loc);
            this.groupBox1.Controls.Add(this.lb_year);
            this.groupBox1.Controls.Add(this.cbb_month);
            this.groupBox1.Controls.Add(this.lb_mouth);
            this.groupBox1.Controls.Add(this.cbb_year);
            this.groupBox1.Location = new System.Drawing.Point(95, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 45);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc";
            // 
            // btn_Loc
            // 
            this.btn_Loc.Location = new System.Drawing.Point(456, 15);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(104, 24);
            this.btn_Loc.TabIndex = 21;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = true;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // lb_year
            // 
            this.lb_year.AutoSize = true;
            this.lb_year.Location = new System.Drawing.Point(249, 18);
            this.lb_year.Name = "lb_year";
            this.lb_year.Size = new System.Drawing.Size(37, 17);
            this.lb_year.TabIndex = 24;
            this.lb_year.Text = "Năm";
            // 
            // cbb_month
            // 
            this.cbb_month.FormattingEnabled = true;
            this.cbb_month.Items.AddRange(new object[] {
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
            this.cbb_month.Location = new System.Drawing.Point(107, 15);
            this.cbb_month.Name = "cbb_month";
            this.cbb_month.Size = new System.Drawing.Size(121, 24);
            this.cbb_month.TabIndex = 19;
            // 
            // lb_mouth
            // 
            this.lb_mouth.AutoSize = true;
            this.lb_mouth.Location = new System.Drawing.Point(52, 18);
            this.lb_mouth.Name = "lb_mouth";
            this.lb_mouth.Size = new System.Drawing.Size(49, 17);
            this.lb_mouth.TabIndex = 23;
            this.lb_mouth.Text = "Tháng";
            // 
            // cbb_year
            // 
            this.cbb_year.FormattingEnabled = true;
            this.cbb_year.Location = new System.Drawing.Point(292, 15);
            this.cbb_year.Name = "cbb_year";
            this.cbb_year.Size = new System.Drawing.Size(121, 24);
            this.cbb_year.TabIndex = 20;
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_reload.BackgroundImage = global::do_an.Properties.Resources.load;
            this.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reload.Location = new System.Drawing.Point(683, 100);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(30, 30);
            this.btn_reload.TabIndex = 32;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // LuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Luong);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_title);
            this.Name = "LuongNV";
            this.Text = "LuongNV";
            this.Load += new System.EventHandler(this.LuongNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Luong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.DataGridView dgv_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongThang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.Label lb_year;
        private System.Windows.Forms.ComboBox cbb_month;
        private System.Windows.Forms.Label lb_mouth;
        private System.Windows.Forms.ComboBox cbb_year;
        private System.Windows.Forms.Button btn_reload;
    }
}