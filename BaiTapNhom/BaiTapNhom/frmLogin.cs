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
    public partial class frmLogin : Form
    {
        Random rand = new Random();
        
        bool checkLogin = false; 
        string tenNguoi, Pass, anhDaiDien;
        List<NguoiDung> ql = new List<NguoiDung>();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btThoat_Click(object sender,EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbUsername.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            lbPassWord.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (StreamReader reader = new StreamReader(@"User.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        tenNguoi = reader.ReadLine();
                        Pass = reader.ReadLine();
                        anhDaiDien = reader.ReadLine();
                        NguoiDung nguoiDung = new NguoiDung(tenNguoi, Pass, anhDaiDien);
                        ql.Add(nguoiDung);
                    }
                }
            }
            catch
            {
                
            }
            if (txtUserName.Text == "admin" && txtPassWord.Text == "admin")
            {
                checkLogin = true;
                frmAdmin admin = new frmAdmin();
                this.Hide();
                admin.ShowDialog();
                
            }
            else
            {
                foreach (NguoiDung nguoiDung in ql)
                {
                    if (txtUserName.Text == nguoiDung.TenNguoiDung && txtPassWord.Text == nguoiDung.PassWord)
                    {
                        checkLogin = true;
                        GiaoDienNguoiDung giaoDienNguoiDung = new GiaoDienNguoiDung(nguoiDung.TenNguoiDung, nguoiDung.PassWord, nguoiDung.AnhDaiDien);
                        this.Hide();
                        giaoDienNguoiDung.ShowDialog();      
                    }

                }
                if (checkLogin == false)
                {
                    MessageBox.Show("Sai", "ThongBao");
                }
            }
            this.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
    }
}
