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
    public partial class frmDanhSachHocVien : Form
    {
        List<ThongTinCaNhan> thongTinHocVien = new List<ThongTinCaNhan>();
        bool check = false;
        public frmDanhSachHocVien()
        {
            InitializeComponent();
        }

        private void frmDanhSachHocVien_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void frmDanhSachHocVien_Load(object sender, EventArgs e)
        {
            listViewHocVien.Clear();
            listViewHocVien.View = View.Details;
            listViewHocVien.Columns.Add("Ho Ten", 130, HorizontalAlignment.Center);
            listViewHocVien.Columns.Add("Ngay Sinh", 100, HorizontalAlignment.Center);
            listViewHocVien.Columns.Add("GioiTinh", 100, HorizontalAlignment.Center);
            listViewHocVien.Columns.Add("Ton Giao", 100, HorizontalAlignment.Center);
            listViewHocVien.Columns.Add("Dia Chi", 100, HorizontalAlignment.Center);
            try
            {
                using (StreamReader reader = new StreamReader(@"UserInfor.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string hoTen = reader.ReadLine();
                        string ngaySinh = reader.ReadLine();
                        string gioiTinh = reader.ReadLine();
                        string tonGiao = reader.ReadLine();
                        string diaChi = reader.ReadLine();
                        ThongTinCaNhan tn = new ThongTinCaNhan(hoTen, ngaySinh, gioiTinh, tonGiao, diaChi);
                        thongTinHocVien.Add(tn);
                    }
                }
            }
            catch
            {

            }
            foreach(ThongTinCaNhan tn in thongTinHocVien)
            {
                ListViewItem item = new ListViewItem(tn.Name);
                item.SubItems.Add(tn.NgaySinh);
                item.SubItems.Add(tn.GioiTinh);
                item.SubItems.Add(tn.TonGiao);
                item.SubItems.Add(tn.DiaChi);
                listViewHocVien.Items.Add(item);
            }
        }

        private void listViewHocVien_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (check == false)
            {
                listViewHocVien.Sorting = SortOrder.Ascending;
                check = true;
            }
            else if(check == true)
            {
                listViewHocVien.Sorting = SortOrder.Descending;
                check = false;
            }
        }

        private void tztTimKiem_TextChanged(object sender, EventArgs e)
        {
            listViewHocVien.Clear();
            thongTinHocVien.Clear();
            listViewHocVien.View = View.Details;
            listViewHocVien.Columns.Add("Ho Ten", 130, HorizontalAlignment.Center);
            listViewHocVien.Columns.Add("Ngay Sinh", 100, HorizontalAlignment.Center);
            listViewHocVien.Columns.Add("GioiTinh", 100, HorizontalAlignment.Center);
            listViewHocVien.Columns.Add("Ton Giao", 100, HorizontalAlignment.Center);
            listViewHocVien.Columns.Add("Dia Chi", 100, HorizontalAlignment.Center);
            try
            {
                using (StreamReader reader = new StreamReader(@"UserInfor.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string hoTen = reader.ReadLine();
                        string ngaySinh = reader.ReadLine();
                        string gioiTinh = reader.ReadLine();
                        string tonGiao = reader.ReadLine();
                        string diaChi = reader.ReadLine();
                        ThongTinCaNhan tn = new ThongTinCaNhan(hoTen, ngaySinh, gioiTinh, tonGiao, diaChi);
                        thongTinHocVien.Add(tn);
                    }
                }
            }
            catch
            {

            }
            foreach (ThongTinCaNhan tn in thongTinHocVien)
            {
                if (tn.Name.Contains(tztTimKiem.Text))
                {
                    
                    ListViewItem item = new ListViewItem(tn.Name);
                    item.SubItems.Add(tn.NgaySinh);
                    item.SubItems.Add(tn.GioiTinh);
                    item.SubItems.Add(tn.TonGiao);
                    item.SubItems.Add(tn.DiaChi);
                    listViewHocVien.Items.Add(item);
                }
            }
        }
    }
}
