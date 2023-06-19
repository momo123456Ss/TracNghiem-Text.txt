using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNhom
{
    internal class NguoiDung
    {
        string tenNguoiDung,passWord,anhDaiDien;
        public NguoiDung(string tenNguoiDung,string password,string path)
        {
            this.tenNguoiDung = tenNguoiDung;
            this.passWord = password;
            this.anhDaiDien = path;
        }

        public string TenNguoiDung { get => tenNguoiDung; set => TenNguoiDung = value; }
        public string AnhDaiDien { get => anhDaiDien; set => anhDaiDien = value; }
        public string PassWord { get => passWord; set => passWord = value; }
    }
}
