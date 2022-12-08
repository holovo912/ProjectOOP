using System.Collections.Generic;

namespace OOP_CSharp
{
    public class Action : Phim
    {
        public Action() : base() { }
        public Action(string tenphim, int gio, int gio_end, int phut, int phut_end,  List<int> ChoNgoi, string tag_name) : base(tenphim, gio, gio_end, phut, phut_end, ChoNgoi, tag_name)
        {
            this.Phut = phut;
            this.Phut_end = phut_end;
            this.Tenphim = tenphim;
            this.ChoNgoi = ChoNgoi;
            this.Gio = gio;
            this.Gio_end = gio_end;
        }
        ~Action() { }
        public override void Input(string tenphim, int gio, int gio_end, int phut, int phut_end, List<int> ChoNgoi)
        {
            base.Input(tenphim, gio, gio_end, phut, phut_end, ChoNgoi);
            this.Giave = 80000;
            this.Tag = 1;
            this.Phong = 1;
        }
        public override bool CheckTuoi(int tuoi)
        {
            if (tuoi < 16)
                return false;
            return true;
        }
    }
}