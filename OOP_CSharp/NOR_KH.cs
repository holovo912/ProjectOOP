using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public class NOR_KH : KH
    {
        public NOR_KH() : base() { }
        public override void Nhap()
        {
            GiamGia = 0.1;
            base.Nhap();
        }
        ~NOR_KH() { }
    }
}