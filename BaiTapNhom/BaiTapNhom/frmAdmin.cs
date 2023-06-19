using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapNhom
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btDanhSachHocVien_Click(object sender, EventArgs e)
        {
            frmDanhSachHocVien frmDanhSachHocVien = new frmDanhSachHocVien();
            frmDanhSachHocVien.MdiParent = this;
            frmDanhSachHocVien.Show();
        }

        private void btThemHocVien_Click(object sender, EventArgs e)
        {
            frmThemHocVien themHocVien = new frmThemHocVien();
            themHocVien.MdiParent = this;
            themHocVien.Show();
        }

        private void btCauHoiTEST2_Click(object sender, EventArgs e)
        {
            FrmIncomplete frmIncomplete = new FrmIncomplete();
            frmIncomplete.MdiParent = this;
            frmIncomplete.Show();
        }

        private void btDanhSachTEST1_Click(object sender, EventArgs e)
        {
            frmDanhSachCauHoi frmDanhSachCauHoi = new frmDanhSachCauHoi();
            frmDanhSachCauHoi.MdiParent = this;
            frmDanhSachCauHoi.Show();
        }

        private void btCauHoiTEST3_Click(object sender, EventArgs e)
        {
            frmConSer frmConSer = new frmConSer();
            frmConSer.MdiParent = this;
            frmConSer.Show();
        }

        private void casToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void arrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void titleHonzotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void btThemCauHoi_Click(object sender, EventArgs e)
        {
            frmThemCauHoi frmThemCauHoi = new frmThemCauHoi();
            frmThemCauHoi.MdiParent = this;
            frmThemCauHoi.Show();
        }
    }
}
