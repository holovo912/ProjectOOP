using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;

namespace OOP_CSharp
{
    public class Action : Phim
    {
        public Action() : base()
        { 

        }

        public Action(string tenphim, int gio, int gio_end, int phut, int phut_end,  List<int> ChoNgoi) : base(tenphim, gio, gio_end, phut, phut_end, ChoNgoi)
        {

        }

        ~Action() { }

        public override void Input(string tenphim, int gio, int gio_end, int phut, int phut_end, List<int> ChoNgoi)
        {
            base.Input();
            this.giave = 80000;
            this.tag = 1;
            this.phong = 1;
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
    }
}