using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public class NOR_KH : KH
    {
        public NOR_KH() : base() { }
        public override void Input(string ID, string ten, int tuoi)
        {
            this.ID = ID;
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.Giamgia = 0.1;
        }
        public override double Discount()
        {
            return Giamgia;
        }
        ~NOR_KH() { }
    }
}