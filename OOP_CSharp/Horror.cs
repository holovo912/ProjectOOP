﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public class Horror : Phim
    {
        public Horror() : base()
        { }
        public Horror(string tenphim, int gio, int gio_end, int phut, int phut_end,  List<int> ChoNgoi, string tag_name) : base(tenphim, gio, gio_end, phut, phut_end, ChoNgoi, tag_name)
        {
            this.Phut = phut;
            this.Phut_end = phut_end;
            this.Tenphim = tenphim;
            this.ChoNgoi = ChoNgoi;
            this.Gio = gio;
            this.Gio_end = gio_end;
        }

        ~Horror() { }

        public override void Input(string tenphim, int gio, int gio_end, int phut, int phut_end, List<int> ChoNgoi)
        {
            base.Input(tenphim, gio, gio_end, phut, phut_end, ChoNgoi);
            this.Giave = 80000;
            this.Tag = 3;
            this.Phong = 3;
        }

        public override bool CheckTuoi(int tuoi)
        {
            if (tuoi < 18)
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
    }
}