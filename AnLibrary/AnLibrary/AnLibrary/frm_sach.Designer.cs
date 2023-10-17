
namespace AnLibrary
{
    partial class frm_sach
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.cbb_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tacgia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_giamua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_rent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_sup = new System.Windows.Forms.ComboBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgvSach = new System.Windows.Forms.DataGridView();
            this.dtgvdeletedBook = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdeletedBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách";
            // 
            // txt_masach
            // 
            this.txt_masach.Location = new System.Drawing.Point(176, 43);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(143, 20);
            this.txt_masach.TabIndex = 1;
            this.txt_masach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_masach_KeyPress);
            // 
            // cbb_type
            // 
            this.cbb_type.FormattingEnabled = true;
            this.cbb_type.Location = new System.Drawing.Point(16, 43);
            this.cbb_type.Name = "cbb_type";
            this.cbb_type.Size = new System.Drawing.Size(121, 21);
            this.cbb_type.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(353, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sách";
            // 
            // txt_tensach
            // 
            this.txt_tensach.Location = new System.Drawing.Point(357, 43);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(143, 20);
            this.txt_tensach.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(528, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tác giả";
            // 
            // txt_tacgia
            // 
            this.txt_tacgia.Location = new System.Drawing.Point(532, 43);
            this.txt_tacgia.Name = "txt_tacgia";
            this.txt_tacgia.Size = new System.Drawing.Size(143, 20);
            this.txt_tacgia.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(172, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá mua";
            // 
            // txt_giamua
            // 
            this.txt_giamua.Location = new System.Drawing.Point(176, 113);
            this.txt_giamua.Name = "txt_giamua";
            this.txt_giamua.Size = new System.Drawing.Size(143, 20);
            this.txt_giamua.TabIndex = 1;
            this.txt_giamua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giamua_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(353, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá cho thuê";
            // 
            // txt_rent
            // 
            this.txt_rent.Location = new System.Drawing.Point(357, 113);
            this.txt_rent.Name = "txt_rent";
            this.txt_rent.Size = new System.Drawing.Size(143, 20);
            this.txt_rent.TabIndex = 1;
            this.txt_rent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rent_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(528, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng ban đầu";
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(532, 113);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(143, 20);
            this.txt_sl.TabIndex = 1;
            this.txt_sl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sl_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(12, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nhà xuất bản";
            // 
            // cbb_sup
            // 
            this.cbb_sup.FormattingEnabled = true;
            this.cbb_sup.Location = new System.Drawing.Point(16, 112);
            this.cbb_sup.Name = "cbb_sup";
            this.cbb_sup.Size = new System.Drawing.Size(121, 21);
            this.cbb_sup.TabIndex = 2;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(702, 40);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(127, 23);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Cập nhật thông tin";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(702, 110);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(127, 23);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xoá sách";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(702, 179);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(127, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(702, 249);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(127, 23);
            this.btn_restore.TabIndex = 4;
            this.btn_restore.Text = "Phục hồi sách đã xoá";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(702, 318);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(127, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 161);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 182);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgvSach);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 156);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sách hiện tại có trong thư viện";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgvdeletedBook);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 156);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sách đã xoá";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgvSach
            // 
            this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSach.Location = new System.Drawing.Point(6, 6);
            this.dtgvSach.Name = "dtgvSach";
            this.dtgvSach.Size = new System.Drawing.Size(639, 144);
            this.dtgvSach.TabIndex = 4;
            this.dtgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSach_CellContentClick);
            // 
            // dtgvdeletedBook
            // 
            this.dtgvdeletedBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdeletedBook.Location = new System.Drawing.Point(6, 6);
            this.dtgvdeletedBook.Name = "dtgvdeletedBook";
            this.dtgvdeletedBook.Size = new System.Drawing.Size(639, 144);
            this.dtgvdeletedBook.TabIndex = 5;
            this.dtgvdeletedBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvdeletedBook_CellContentClick);
            // 
            // frm_sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 355);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.cbb_sup);
            this.Controls.Add(this.cbb_type);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.txt_tacgia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_rent);
            this.Controls.Add(this.txt_tensach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_giamua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_masach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_sach";
            this.Text = "Sách";
            this.Load += new System.EventHandler(this.frm_sach_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdeletedBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.ComboBox cbb_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tacgia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_giamua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_rent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_sup;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgvdeletedBook;
    }
}