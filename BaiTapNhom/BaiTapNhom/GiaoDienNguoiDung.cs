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
using System.Collections;
namespace BaiTapNhom
{
    public partial class GiaoDienNguoiDung : Form
    {
        double soLanKiemTra = 0;
        double diemTrungBinh;
        static double soCauHoiTEST1 = 20;
        static double soCauHoiTEST2 = 15;
        static double soCauHoiTEST3 = 5;
        static double soLuongVanBanDeThi2 = 3;
        bool check = false;
        double soCauDung = 0;
        string name;
        string tenNguoi, Pass, anhDaiDien;
        string hoten, ngaysinh, tongiao, diachi,gioitinh;
        List<ThongTinCaNhan> qlThongTin = new List<ThongTinCaNhan>();
        List<CauHoi> qlCauHoi = new List<CauHoi>();
        List<CauHoi> TMP = new List<CauHoi>();
        List<Incomplete> incompletes = new List<Incomplete>();
        List<Incomplete> TMP_Incomple = new List<Incomplete>();
        List<Conservation> conservations = new List<Conservation>();
        List<Conservation> TMP_Conservation = new List<Conservation>();
        ComboBox[] comboBoxes = new ComboBox[20];
        List<KetQuaHocTap> kq = new List<KetQuaHocTap>();
        private void btReturn_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panelThongTinUser.Show() ;
            
            btNopBai.Hide();
            btBatDauThi.Show();
            
        }

        private void btSuaThongTin_Click(object sender, EventArgs e)
        {
            panelSuaThongTin.Show();
            lbThongTinUse.Hide();
            pnDiemTrungBinh.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThongTin_Click(object sender, EventArgs e)
        {
            panelSuaThongTin.Hide();
            pnDiemTrungBinh.Hide();
            GiaoDienNguoiDung_Load(sender, e);
            lbThongTinUse.Show();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            foreach (ThongTinCaNhan info in qlThongTin)
            {
                if (info.Name == name)
                {
                    info.Name = txtHoTenSuaDoi.Text;
                    info.NgaySinh = txtNgaySinhSuaDoi.Text;
                    info.GioiTinh = txtGioiTinhSuaDoi.Text;
                    info.TonGiao = txtTonGiaoSuaDoi.Text;
                    info.DiaChi = txtDiaChiSuaDoi.Text;
                    
                }

            }
            List<ThongTinCaNhan> list = qlThongTin.ToList();

            try
            {
                using(StreamWriter writer = new StreamWriter(@"UserInfor.txt",false))
                {
                    
                    foreach (ThongTinCaNhan tn in list)
                    {
                        writer.Write(tn.Name + "\n" + tn.NgaySinh + "\n" + tn.GioiTinh + "\n" + tn.TonGiao + "\n" + tn.DiaChi + "\n");
                    }
                    list.Clear();
                    qlThongTin.Clear();
                }
            }
            catch
            {

            }
            
            MessageBox.Show("Da Cap Nhat", "Thong Bao");
        }

        private void rdTest1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Show();
            comboBox2.Show();
            comboBox3.Show();
            comboBox4.Show();
            comboBox5.Show(); 
            comboBox6.Show();
            comboBox7.Show();
            comboBox8.Show();
            comboBox9.Show();
            comboBox10.Show();
            comboBox11.Show();
            comboBox12.Show();
            comboBox13.Show();
            comboBox14.Show();
            comboBox15.Show();
            comboBox16.Show();
            comboBox17.Show();
            comboBox18.Show();
            comboBox19.Show();
            comboBox20.Show();
            richTxTDeThi.Clear();
            try
            {
                using (StreamReader reader = new StreamReader(@"DeThi1.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string noiDung = reader.ReadLine();
                        string[] dapAn = new string[4];
                        for (int i = 0; i < 4; i++)
                        {

                            dapAn[i] = reader.ReadLine();
                        }
                        string dapAnDung = reader.ReadLine();
                        CauHoi ch = new CauHoi(noiDung, dapAn, dapAnDung);
                        qlCauHoi.Add(ch);
                    }
                }
            }
            catch
            {

            }
            int count = 0;
            var rnd = new Random();

            TMP = qlCauHoi.OrderBy(item => rnd.Next()).ToList();
            foreach (CauHoi ch in TMP)
            {
                if (count == 20)
                {
                    continue;
                }
                else
                {
                    count++;
                    richTxTDeThi.Text += "\n" + count + "." + ch.NoiDung + "\n";
                    for (int i = 0; i < 4; i++)
                    {
                        richTxTDeThi.Text += ch.DapAn[i] + "\t";
                    }
                    richTxTDeThi.Text += "\n";
                }
            }
         
            qlCauHoi.Clear();
        }

        private void rdTest2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Show();
            comboBox2.Show();
            comboBox3.Show();
            comboBox4.Show();
            comboBox5.Show();
            comboBox6.Show();
            comboBox7.Show();
            comboBox8.Show();
            comboBox9.Show();
            comboBox10.Show();
            comboBox11.Show();
            comboBox12.Show();
            comboBox13.Show();
            comboBox14.Show();
            comboBox15.Show();
            comboBox16.Hide();
            comboBox17.Hide();
            comboBox18.Hide();
            comboBox19.Hide();
            comboBox20.Hide();
            richTxTDeThi.Clear();
            try
            {
                using (StreamReader reader = new StreamReader(@"DeThi2.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string noiDung = reader.ReadLine();
                        string[] dapAn = new string[15];
                        for (int i = 0; i < 15; i++)
                        {

                            dapAn[i] = reader.ReadLine();
                        }
                        string[] dapAnDung = new string[15];
                        for (int i = 0; i < 15; i++)
                        {

                            dapAnDung[i] = reader.ReadLine();
                        }
                        string doKho = reader.ReadLine();
                        Incomplete ch = new Incomplete(noiDung, dapAn, dapAnDung,doKho);
                        incompletes.Add(ch);
                    }
                }
            }
            catch
            {

            }
            int count = 0;
            var rnd = new Random();

            TMP_Incomple = incompletes.OrderBy(item => rnd.Next()).ToList();
            foreach (Incomplete ch in TMP_Incomple)
            {
                if (count == 1)
                {
                    continue;
                }
                else
                {
                    count++;
                    richTxTDeThi.Text += "\n" + count + "." + ch.NoiDung + "\n";
                    for (int i = 0; i < 15; i++)
                    {
                        richTxTDeThi.Text += ch.DapAn[i] + "\n";
                    }
                    richTxTDeThi.Text += "\n";
                }
            }
            incompletes.Clear();
        }

        private void rdTest3_CheckedChanged(object sender, EventArgs e)
        {
            richTxTDeThi.Clear();
            comboBox1.Show();
            comboBox2.Show();
            comboBox3.Show();
            comboBox4.Show();
            comboBox5.Show();
           
            comboBox6.Hide();
            comboBox7.Hide();
            comboBox8.Hide();
            comboBox9.Hide();
            comboBox10.Hide();
            comboBox11.Hide();
            comboBox12.Hide();
            comboBox13.Hide();
            comboBox14.Hide();
            comboBox15.Hide();
            comboBox16.Hide();
            comboBox17.Hide();
            comboBox18.Hide();
            comboBox19.Hide();
            comboBox20.Hide();
            try
            {
                using (StreamReader reader = new StreamReader(@"DeThi3.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string noiDung = reader.ReadLine();
                        string[] dapAn = new string[5];
                        for (int i = 0; i < 5; i++)
                        {

                            dapAn[i] = reader.ReadLine();
                        }
                        string[] dapAnDung = new string[5];
                        for (int i = 0; i < 5; i++)
                        {

                            dapAnDung[i] = reader.ReadLine();
                        }
                        string doKho = reader.ReadLine();
                        Conservation ch = new Conservation(noiDung, dapAn, dapAnDung, doKho);
                        conservations.Add(ch);
                    }
                }
            }
            catch
            {

            }
            int count = 0;
            var rnd = new Random();
            TMP_Conservation = conservations.OrderBy(item => rnd.Next()).ToList();
            foreach (Conservation ch in TMP_Conservation)
            {
                if (count == 1)
                {
                    continue;
                }
                else
                {
                    count++;
                    richTxTDeThi.Text += "\n" + count + "." + ch.NoiDung + "\n";
                    for (int i = 0; i < 5; i++)
                    {
                        richTxTDeThi.Text += ch.DapAn[i] + "\n";
                    }
                    richTxTDeThi.Text += "\n";
                }
            }
            conservations.Clear();
        }

        private void btKetQuaUser_Click(object sender, EventArgs e)
        {
            pnDiemTrungBinh.Show();
            lbDiemTrungBinh.Text = "";
            soLanKiemTra = 0;
            diemTrungBinh = 0;
            kq.Clear();
            listViewKetQuaHocTap.Clear();
            listViewKetQuaHocTap.View = View.Details;
            listViewKetQuaHocTap.Columns.Add("Ho Ten",140,HorizontalAlignment.Center);
            listViewKetQuaHocTap.Columns.Add("Bai Kiem Tra", 140, HorizontalAlignment.Center);
            listViewKetQuaHocTap.Columns.Add("Ngay Gio", 220, HorizontalAlignment.Center);
            listViewKetQuaHocTap.Columns.Add("Diem So", 130, HorizontalAlignment.Center);
            try
            {
                using(StreamReader reader = new StreamReader(@"DiemTrungBinh.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string ngayGio = reader.ReadLine();
                        string baiKiemTra = reader.ReadLine();
                        string hoTen = reader.ReadLine();
                        string diemSo = reader.ReadLine();
                        KetQuaHocTap hocTap = new KetQuaHocTap(ngayGio,baiKiemTra,hoTen, diemSo);
                        kq.Add(hocTap);
                    }
                }
            }
            catch
            {
                MessageBox.Show("","",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
            foreach (KetQuaHocTap kq in kq)
            {
                if (kq.HoTen == lbUserName.Text)
                {
                    soLanKiemTra++;
                    ListViewItem item = new ListViewItem(kq.HoTen);
                    
                    item.SubItems.Add(kq.BaiKiemTra);
                    item.SubItems.Add(kq.NgayGioKiemTra);
                    item.SubItems.Add(kq.DiemSo);
                    listViewKetQuaHocTap.Items.Add(item);
                    diemTrungBinh += Double.Parse(kq.DiemSo);
                }               
            }
            lbDiemTrungBinh.Text += "Diem trung binh: " + String.Format("{0:0.00}",(diemTrungBinh / soLanKiemTra)*10);
        }

        

        private void listViewKetQuaHocTap_Click(object sender, EventArgs e)
        {

            listViewKetQuaHocTap.Sorting = SortOrder.Ascending;
        }

        private void rdTest4_CheckedChanged(object sender, EventArgs e)
        {
            richTxTDeThi.Clear();
            try
            {
                using (StreamReader reader = new StreamReader(@"DeThi1.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string noiDung = reader.ReadLine();
                        string[] dapAn = new string[4];
                        for (int i = 0; i < 4; i++)
                        {

                            dapAn[i] = reader.ReadLine();
                        }
                        string dapAnDung = reader.ReadLine();
                        CauHoi ch = new CauHoi(noiDung, dapAn, dapAnDung);
                        qlCauHoi.Add(ch);
                    }
                }
            }
            catch
            {

            }
            int count = 0;
            var rnd = new Random();
            TMP = qlCauHoi.OrderBy(item => rnd.Next()).ToList();
            
            foreach (CauHoi ch in TMP)
            {
                if (count == 20)
                {
                    break;
                }
                else
                {
                    count++;
                    richTxTDeThi.Text += "\n" + count + "." + ch.NoiDung + "\n";
                    for (int i = 0; i < 4; i++)
                    {
                        richTxTDeThi.Text += ch.DapAn[i] + "\t";
                    }
                    richTxTDeThi.Text += "\n";
                }
                
            }
            qlCauHoi.Clear();
        }

       
        public GiaoDienNguoiDung()
        {
            InitializeComponent();
        }

       

        private void btNopBai_Click(object sender, EventArgs e)
        {
           
            if (rdTest1.Checked)
            {
                
                if (comboBox1.Text.Equals(TMP[0].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox2.Text.Equals(TMP[1].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox3.Text.Equals(TMP[2].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox4.Text.Equals(TMP[3].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox5.Text.Equals(TMP[4].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox6.Text.Equals(TMP[5].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox7.Text.Equals(TMP[6].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox8.Text.Equals(TMP[7].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox9.Text.Equals(TMP[8].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox10.Text.Equals(TMP[9].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox11.Text.Equals(TMP[10].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox12.Text.Equals(TMP[11].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox13.Text.Equals(TMP[12].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox14.Text.Equals(TMP[13].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox15.Text.Equals(TMP[14].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox16.Text.Equals(TMP[15].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox17.Text.Equals(TMP[16].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox18.Text.Equals(TMP[17].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox19.Text.Equals(TMP[18].DapAnDung))
                {
                    soCauDung++;
                }
                if (comboBox20.Text.Equals(TMP[19].DapAnDung))
                {
                    soCauDung++;
                }
                
                try
                {
                    using (StreamWriter w = new StreamWriter(@"DiemTrungBinh.txt",true))
                    {
                        w.WriteLine(DateTime.Now);
                        w.WriteLine("TEST 1");
                        w.WriteLine(lbUserName.Text);
                        double point = soCauDung / soCauHoiTEST1;
                        w.WriteLine(point);
                    }
                }
                catch
                {
                    MessageBox.Show("DiemTrungBinh Error");
                }
                //MessageBox.Show(soCauDung.ToString());
   
            }
            else if (rdTest2.Checked)
            {
                
                    if (comboBox1.Text.Equals(TMP_Incomple[0].DapAnDung[0]))
                    {
                        soCauDung++;
                    }
                    if (comboBox2.Text.Equals(TMP_Incomple[0].DapAnDung[1]))
                    {
                        soCauDung++;
                    }
                    if (comboBox3.Text.Equals(TMP_Incomple[0].DapAnDung[2]))
                    {
                        soCauDung++;
                    }
                    if (comboBox4.Text.Equals(TMP_Incomple[0].DapAnDung[3]))
                    {
                        soCauDung++;
                    }
                    if (comboBox5.Text.Equals(TMP_Incomple[0].DapAnDung[4]))
                    {
                        soCauDung++;
                    }
                    if (comboBox6.Text.Equals(TMP_Incomple[0].DapAnDung[5]))
                    {
                        soCauDung++;
                    }
                    if (comboBox7.Text.Equals(TMP_Incomple[0].DapAnDung[6]))
                    {
                        soCauDung++;
                    }
                    if (comboBox8.Text.Equals(TMP_Incomple[0].DapAnDung[7]))
                    {
                        soCauDung++;
                    }
                    if (comboBox9.Text.Equals(TMP_Incomple[0].DapAnDung[8]))
                    {
                        soCauDung++;
                    }
                    if (comboBox10.Text.Equals(TMP_Incomple[0].DapAnDung[9]))
                    {
                        soCauDung++;
                    }
                    if (comboBox11.Text.Equals(TMP_Incomple[0].DapAnDung[10]))
                    {
                        soCauDung++;
                    }
                    if (comboBox12.Text.Equals(TMP_Incomple[0].DapAnDung[11]))
                    {
                        soCauDung++;
                    }
                    if (comboBox13.Text.Equals(TMP_Incomple[0].DapAnDung[12]))
                    {
                        soCauDung++;
                    }
                    if (comboBox14.Text.Equals(TMP_Incomple[0].DapAnDung[13]))
                    {
                        soCauDung++;
                    }
                    if (comboBox15.Text.Equals(TMP_Incomple[0].DapAnDung[14]))
                    {
                        soCauDung++;
                    }
                
                try
                {
                    using (StreamWriter w = new StreamWriter(@"DiemTrungBinh.txt", true))
                    {
                        w.WriteLine(DateTime.Now);
                        w.WriteLine("TEST 2");
                        w.WriteLine(lbUserName.Text);
                        double point = soCauDung / soCauHoiTEST2;
                        w.WriteLine(point);
                    }
                }
                catch
                {
                    MessageBox.Show("DiemTrungBinh Error");
                }
            }
            else if (rdTest3.Checked)
            {
                if (comboBox1.Text.Equals(TMP_Conservation[0].DapAnDung[0]))
                {
                    soCauDung++;
                }
                if (comboBox2.Text.Equals(TMP_Conservation[0].DapAnDung[1]))
                {
                    soCauDung++;
                }
                if (comboBox3.Text.Equals(TMP_Conservation[0].DapAnDung[2]))
                {
                    soCauDung++;
                }
                if (comboBox4.Text.Equals(TMP_Conservation[0].DapAnDung[3]))
                {
                    soCauDung++;
                }
                if (comboBox5.Text.Equals(TMP_Conservation[0].DapAnDung[4]))
                {
                    soCauDung++;
                }
                try
                {
                    using (StreamWriter w = new StreamWriter(@"DiemTrungBinh.txt", true))
                    {
                        w.WriteLine(DateTime.Now);
                        w.WriteLine("TEST 3");
                        w.WriteLine(lbUserName.Text);
                        double point = soCauDung / soCauHoiTEST3;
                        w.WriteLine(point);
                    }
                }
                catch
                {
                    MessageBox.Show("DiemTrungBinh Error");
                }

            }
            soCauDung = 0;
            richTxTDeThi.Clear();
            MessageBox.Show("Nop bai roi", "Thong bao", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btBatDauThi_Click(object sender, EventArgs e)
        {
            btBatDauThi.Hide();
            btNopBai.Show();
            panel2.Show();
            panelThongTinUser.Hide();
            
            
        }

        public GiaoDienNguoiDung(string name,string pass , string path)
        {
            this.name = name;
            this.Pass = pass;
            this.anhDaiDien = path;
            InitializeComponent();
        }
        private void GiaoDienNguoiDung_Load(object sender, EventArgs e)
        {
            
            Image anh = new Bitmap(anhDaiDien);
            lbUserName.Text = name;
            picUser.BackgroundImage = anh;
            btNopBai.Hide();
            panel2.Hide();
            panelSuaThongTin.Hide();
            pnDiemTrungBinh.Hide();
            try
            {
               
                using(StreamReader reader = new StreamReader(@"UserInfor.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        hoten = reader.ReadLine();
                        ngaysinh = reader.ReadLine();
                        gioitinh = reader.ReadLine();
                        tongiao = reader.ReadLine();
                        diachi = reader.ReadLine();
                        ThongTinCaNhan info = new ThongTinCaNhan(hoten, ngaysinh,gioitinh, tongiao, diachi);
                        qlThongTin.Add(info);
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("file error", "Thong Bao");
            }
            foreach (ThongTinCaNhan info in qlThongTin)
            {
                if (info.Name == name)
                {
                    lbThongTinUse.Text = "\nHo Ten: " + info.Name
                        + "\n\nNgaySinh: " + info.NgaySinh + "\n\nGioiTinh: " + info.GioiTinh
                        + "\n\nTonGiao: " + info.TonGiao
                        + "\n\nDiaChi: " + info.DiaChi;
                    txtHoTenSuaDoi.Text = info.Name;
                    txtNgaySinhSuaDoi.Text = info.NgaySinh;
                    txtGioiTinhSuaDoi.Text = info.GioiTinh;
                    txtTonGiaoSuaDoi.Text = info.TonGiao;
                    txtDiaChiSuaDoi.Text = info.DiaChi;
                }
                
            }
        }

    }
}
