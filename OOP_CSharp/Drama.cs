using System.Collections.Generic;

namespace OOP_CSharp
{
    public class Drama : Phim
    {
        public Drama() : base() { }
        public Drama(string tenphim, int gio, int gio_end, int phut, int phut_end,  List<int> ChoNgoi, string tag_name) : base(tenphim, gio, gio_end, phut, phut_end, ChoNgoi, tag_name)
        {
            this.Phut = phut;
            this.Phut_end = phut_end;
            this.Tenphim = tenphim;
            this.ChoNgoi = ChoNgoi;
            this.Gio = gio;
            this.Gio_end = gio_end;
        }
        ~Drama() { }
        public override void Input(string tenphim, int gio, int gio_end, int phut, int phut_end, List<int> ChoNgoi)
        {
            base.Input(tenphim, gio, gio_end, phut, phut_end, ChoNgoi);
            this.Giave = 60000;
            this.Tag = 3;
            this.Phong = 3;
        }
        public override bool CheckTuoi(int tuoi)
        {
            if (tuoi < 14)
                return false;
            return true;
        }
    }
}