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
        public override bool CheckTuoi(KH temp)
        {
            Tag = 2;
            GiaVe = 40000;
            return true;
        }
        ~Cartoon() { }
    }
}