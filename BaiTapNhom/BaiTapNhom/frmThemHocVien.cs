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
    public partial class frmThemHocVien : Form
    {
        public frmThemHocVien()
        {
            InitializeComponent();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
            txtDiaChi.Clear();
            txtTonGiao.Clear();
            comboboxGioiTinh.Text = "";
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<string> img = new List<string> { "ImagesUser\\xucxac1.jpg", "ImagesUser\\xucxac2.jpg", "ImagesUser\\xucxac3.jpg", "ImagesUser\\xucxac4.jpg", "ImagesUser\\xucxac5.jpg", "ImagesUser\\xucxac6.jpg" };
           
            
            
            try
            {
                using(StreamWriter writer = new StreamWriter(@"UserInfor.txt",true))
                {
                    writer.WriteLine(txtTaiKhoan.Text);
                    writer.WriteLine(dateTimePicker1.Text);
                    writer.WriteLine(comboboxGioiTinh.Text);
                    writer.WriteLine(txtTonGiao.Text);
                    writer.WriteLine(txtDiaChi.Text);
                }
            }
            catch
            {

            }
            try
            {
                using (StreamWriter writer = new StreamWriter(@"User.txt", true))
                {
                    writer.WriteLine(txtTaiKhoan.Text);
                    writer.WriteLine(random.Next(10000000,99999999));
                    writer.WriteLine(img[random.Next(img.Count)]);
                }
            }
            catch
            {

            }
            MessageBox.Show("Da Them 1 Hoc Vien", "ThongBao");
        }
    }
}
