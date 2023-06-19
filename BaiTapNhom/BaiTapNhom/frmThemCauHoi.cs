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
    public partial class frmThemCauHoi : Form
    {
        int count = 0;
        Random rand = new Random();
        public frmThemCauHoi()
        {
            InitializeComponent();
        }

        private void frmThemCauHoi_Load(object sender, EventArgs e)
        {

        }

        private void btThemCauHoi_Click(object sender, EventArgs e)
        {
            if (rdTEST1.Checked)
            {
                try
                {
                    using(StreamWriter writer = new StreamWriter(@"DeThi1.txt",true))
                    {
                        writer.WriteLine(txtNoidungMutiple.Text);
                        writer.WriteLine(richDapAnMutiple.Text);
                        writer.WriteLine(richDapAnDungMutiple.Text);
                    }
                }
                catch
                {

                }
                MessageBox.Show("Da them 1 cau hoi vao TEST 1");
            }
            else if (rdIncomplete.Checked)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(@"DeThi2.txt", true))
                    {
                        writer.WriteLine(txtNoidungMutiple.Text);
                        writer.WriteLine(richDapAnMutiple.Text);
                        writer.WriteLine(richDapAnDungMutiple.Text);
                    }
                }
                catch
                {

                }
                MessageBox.Show("Da them 1 cau hoi vao TEST 2");
            }
            else if (rdConservation.Checked)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(@"DeThi3.txt", true))
                    {
                        writer.WriteLine(txtNoidungMutiple.Text);
                        writer.WriteLine(richDapAnMutiple.Text);
                        writer.WriteLine(richDapAnDungMutiple.Text);
                    }
                }
                catch
                {

                }
                MessageBox.Show("Da them 1 cau hoi vao TEST 3");
            }
            else
            {
                MessageBox.Show("Vui long check vao Cau Hoi");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                lbChuDoiMau.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)); ;
        }

        private void rdTEST1_CheckedChanged(object sender, EventArgs e)
        {
            lbChuDoiMau.Text = rdTEST1.Text;
        }

        private void rdIncomplete_CheckedChanged(object sender, EventArgs e)
        {
            lbChuDoiMau.Text = rdIncomplete.Text;
        }

        private void rdConservation_CheckedChanged(object sender, EventArgs e)
        {
            lbChuDoiMau.Text = rdConservation.Text;
        }
    }
}
