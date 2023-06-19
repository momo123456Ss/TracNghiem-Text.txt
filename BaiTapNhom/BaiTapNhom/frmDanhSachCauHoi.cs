using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BaiTapNhom
{
    public partial class frmDanhSachCauHoi : Form
    {
        public frmDanhSachCauHoi()
        {
            InitializeComponent();
        }

        private void frmDanhSachCauHoi_Load(object sender, EventArgs e)
        {
            try
            {
                using(StreamReader reader = new StreamReader(@"DeThi1.txt"))
                {
                    richTextBoxCauHoiDeThi1.Text = reader.ReadToEnd();
                }
            }
            catch
            {
                MessageBox.Show("Khong mo dc test 1", "Thong Bao");
            }
        }
    }
}
