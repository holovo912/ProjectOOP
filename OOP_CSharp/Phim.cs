using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp
{
    public class Phim
    {
        private List<KhachHang> dskhachhang = new List<KhachHang>();
        private string idphim;
        private string tenphim;
        private int gio;
        private int phut;
        private int giave;
        public List<KhachHang> DSKhachHang { get => dskhachhang; set => dskhachhang = value; }
        public string IdPhim { get => idphim; set => idphim = value; }
        public string TenPhim { get => tenphim; set => tenphim = value; }
        public int Gio { get => gio; set => gio = value; }
        public int Phut { get => phut; set => phut = value; }
        public int GiaVe { get => giave; set => giave = value; }

        public Phim()
        {
            List<KhachHang> DSKhachHang = new List<KhachHang>();
        }
        public void Nhap()
        {
            KhachHang temp = new KhachHang();
            temp.Nhap();
            DSKhachHang.Add(temp);
        }
        ~Phim() { }
    }
}
