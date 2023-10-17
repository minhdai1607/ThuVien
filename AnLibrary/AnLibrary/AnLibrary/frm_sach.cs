using AnLibrary.EntityFramework;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AnLibrary
{
    public partial class frm_sach : Form
    {
        public frm_sach()
        {
            InitializeComponent();
        }
        dbContext db = new dbContext();
        common cm = new common();
        public void loadbook()
        {
            dtgvSach.DataSource = cm.getdata("");
            dtgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvdeletedBook.DataSource = cm.getdata("");
            dtgvdeletedBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cbb_sup.DataSource = cm.getdata("");
            cbb_sup.ValueMember = "MaNXB";
            cbb_sup.DisplayMember = "TenNXB";
            cbb_type.DataSource = cm.getdata("");
            cbb_type.ValueMember = "MaTL";
            cbb_type.DisplayMember = "TenTL";
        }
        public void khoaphim()
        {
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }
        public void mophim()
        {
            txt_masach.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_save.Enabled = false;
        }
        public void clear()
        {
            loadbook();
            khoaphim();
            txt_masach.Text = "";
            txt_tensach.Text = "";
            txt_tacgia.Text = "";
            txt_sl.Text = "";
            txt_rent.Text = "";
            txt_giamua.Text = "";
        }
        private void frm_sach_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_rent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_giamua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_masach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_masach.Text =="" || txt_tensach.Text == "" || txt_tacgia.Text =="" || txt_giamua.Text == "" || txt_rent.Text == "" || txt_sl.Text == "")
            {
                MessageBox.Show("Các trường dữ liệu không được để trống", "Thông Báo", MessageBoxButtons.OK);
            }    
            int book_code = int.Parse(txt_masach.Text);
            var _module = db.Saches.Where(x => x.Ma == book_code).FirstOrDefault();
            var ten = txt_tensach.Text;
            var tg = txt_tacgia.Text;
            var type = int.Parse(cbb_type.SelectedValue.ToString());
            var sup = int.Parse(cbb_sup.SelectedValue.ToString());
            var mua = int.Parse(txt_giamua.Text);
            var rent = int.Parse(txt_rent.Text);
            var sl = int.Parse(txt_sl.Text);
            if (_module == null)
            {
                db.Saches.Add(new Sach { Ma = book_code, TenSach = ten, TacGia=tg, MaTL=type,MaNXB=sup,
                    Giamua=mua,Giathue=rent,SoLuong=sl, Status = EntityFramework.Status.Active }) ;
                db.SaveChanges();
                clear();
                MessageBox.Show("Thao tác lưu thành công", "Thông Báo", MessageBoxButtons.OK);
                khoaphim();
            }
            else
            {
                MessageBox.Show("Dữ liệu đã tồn tại thao tác thất bại", "Thông Báo", MessageBoxButtons.OK);
                txt_masach.Focus();
            }
        }

        private void dtgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvSach.Rows[e.RowIndex];
            txt_masach.Text = row.Cells[0].Value.ToString();
            mophim();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int book_code = int.Parse(txt_masach.Text);
            var ten = txt_tensach.Text;
            var tg = txt_tacgia.Text;
            var type = int.Parse(cbb_type.SelectedValue.ToString());
            var sup = int.Parse(cbb_sup.SelectedValue.ToString());
            var mua = int.Parse(txt_giamua.Text);
            var rent = int.Parse(txt_rent.Text);
            var sl = int.Parse(txt_sl.Text);
            var _book = db.Saches.FirstOrDefault(x => x.Ma == book_code);
            _book.TenSach = ten;
            _book.TacGia = tg;
            _book.SoLuong = sl;
            _book.MaTL = type;
            _book.MaNXB = sup;
            _book.Giamua = mua;
            _book.Giathue = rent;
            db.SaveChanges();
            MessageBox.Show("Cập nhật thông tin thành công", "Thông Báo", MessageBoxButtons.OK);
            clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int book_code = int.Parse(txt_masach.Text);
            MessageBox.Show("bạn chắc muốn xoá dữ liệu này?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                var _model = db.Saches.FirstOrDefault(x => x.Ma == book_code);
                _model.Status = EntityFramework.Status.DeActive;
                db.SaveChanges();
                MessageBox.Show("Thao tác thành công", "Thông Báo", MessageBoxButtons.OK);
                clear();
            }
        }

        private void dtgvdeletedBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvSach.Rows[e.RowIndex];
            txt_masach.Text = row.Cells[0].Value.ToString();
            khoaphim();
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            int book_code = int.Parse(txt_masach.Text);
            MessageBox.Show("bạn chắc muốn phục hồi dữ liệu này?", "Cảnh báo!", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                var _model = db.Saches.FirstOrDefault(x => x.Ma == book_code);
                _model.Status = EntityFramework.Status.Active;
                db.SaveChanges();
                clear();
                MessageBox.Show("Thao tác thành công", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thao tác xoá không được thực hiện", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void txt_sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
