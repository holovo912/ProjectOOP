using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public class Drama : Phim
    {
        public Drama() : base()
        { }
        public Drama(string tenphim, int gio, int gio_end, int phut, int phut_end,  List<int> ChoNgoi) : base(tenphim, gio, gio_end, phut, phut_end, ChoNgoi)
        {

        }

        ~Drama() { }

        public override void Input(string tenphim, int gio, int gio_end, int phut, int phut_end, List<int> ChoNgoi)
        {
            base.Input();
            this.giave = 60000;
            this.tag = 3;
            this.phong = 3;
        }

        public override bool CheckTuoi(int tuoi)
        {
            if (tuoi < 14)
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
        ~Drama() { }
    }
}