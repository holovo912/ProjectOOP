using System.Collections.Generic;

namespace OOP_CSharp
{
    public class Cartoon : Phim
    {
        public Cartoon() : base() { }
        ~Cartoon() { }
        public Cartoon(string tenphim, int gio, int gio_end, int phut, int phut_end,  List<int> ChoNgoi, string tag_name) : base(tenphim, gio, gio_end, phut, phut_end, ChoNgoi, tag_name)
        {
            this.Phut = phut;
            this.Phut_end = phut_end;
            this.Tenphim = tenphim;
            this.ChoNgoi = ChoNgoi;
            this.Gio = gio;
            this.Gio_end = gio_end;
        }
        public override void Input(string tenphim, int gio, int gio_end, int phut, int phut_end, List<int> ChoNgoi)
        {
            base.Input(tenphim, gio, gio_end, phut, phut_end, ChoNgoi);
            this.Giave = 40000;
            this.Tag = 2;
            this.Phong = 2;
        }
        public override bool CheckTuoi(int tuoi)
        {
            return true;
        }
    }
}