using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_CSharp
{
    public class Phim
    {
        private string idphim;
        private string tenphim;
        private int gio;
        private int phut;
        private int giave;
        private int tag;
        public Phim()
        {
        }
        public string IdPhim { get => idphim; set => idphim = value; }
        public string TenPhim { get => tenphim; set => tenphim = value; }
        public int Gio { get => gio; set => gio = value; }
        public int Phut { get => phut; set => phut = value; }
        public int GiaVe { get => giave; set => giave = value; }
        public int Tag { get => tag; set => tag = value; }

        public virtual bool CheckTuoi(KH temp)
        {
            return true;
        }
        ~Phim() { }
    }
}
