using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNhom
{
    internal class KetQuaHocTap
    {
        string ngayGioKiemTra;
        string baiKiemTra;
        string hoTen;
        string diemSo;
        public KetQuaHocTap(string ngayGioKiemTra,string baiKiemTra,string hoTen, string diemSo)
        {
            this.ngayGioKiemTra = ngayGioKiemTra;
            this.diemSo = diemSo;
            this.hoTen = hoTen;
            this.baiKiemTra = baiKiemTra;
        }

        public string NgayGioKiemTra { get => ngayGioKiemTra; set => ngayGioKiemTra = value; }
        public string DiemSo { get => diemSo; set => diemSo = value; }
        public string BaiKiemTra { get => baiKiemTra; set => baiKiemTra = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
    }
}
