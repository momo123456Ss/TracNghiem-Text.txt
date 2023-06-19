using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNhom
{
    internal class ThongTinCaNhan
    {
        string name, ngaySinh, tonGiao, diaChi,gioiTinh;
        public ThongTinCaNhan(string name, string ngaySinh,string gioiTinh, string tonGiao, string diaChi)
        {
            this.name = name;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh; 
            this.tonGiao = tonGiao;
            this.diaChi = diaChi;
        }

        public string Name { get => name; set => name = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string TonGiao { get => tonGiao; set => tonGiao = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
