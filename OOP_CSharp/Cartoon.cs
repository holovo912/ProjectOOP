using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public class Cartoon : Phim
    {
        public Cartoon() : base()
        { }
        public Cartoon(string tenphim, int gio, int gio_end, int phut, int phut_end,  List<int> ChoNgoi) : base(tenphim, gio, gio_end, phut, phut_end, ChoNgoi)
        {

        }

        ~Cartoon() { }

        public override void Input(string tenphim, int gio, int gio_end, int phut, int phut_end, List<int> ChoNgoi)
        {
            base.Input();
            this.giave = 40000;
            this.tag = 2;
            this.phong = 2;
        }

        public override bool CheckTuoi(int tuoi)
        {
            if (tuoi < 16)
                return false;
            return true;
        }

        public override void Infor()
        {
            base.Infor();
        }

        public override void Seat()
        {
            base.Seat();
        }
        ~Cartoon() { }
    }
}