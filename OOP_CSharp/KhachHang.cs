using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp
{
    public class KhachHang
    {
        private string ten;
        private string sdt;
        private string maphim;
        private int chongoi;
        public KhachHang()
        {

        }
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string MaPhim { get => maphim; set => maphim = value; }
        public int ChoNgoi { get => chongoi; set => chongoi = value; }
        public void Nhap()
        {
            Ten = Console.ReadLine();
            Sdt = Console.ReadLine();
        }
        ~KhachHang(){ }
    }
}
