using System;
using System.Windows.Forms;

namespace chuyensonguyen
{
    public partial class Form1 : Form
    {
        private chuyendoi csn;

        public Form1()
        {
            InitializeComponent();
            csn = new chuyendoi(); 
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {

                long a = long.Parse(txtNumber.Text);
                txtResult.Text = csn.ThucHienChuyenDoi(a);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumber.Focus();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            txtResult.Clear();
            txtNumber.Focus();
        }

        private void lblExample_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ví dụ: 12345 → Mười hai nghìn ba trăm bốn mươi lăm", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
