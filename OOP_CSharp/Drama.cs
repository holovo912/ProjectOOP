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
        public override bool CheckTuoi(KH temp)
        {
            Tag = 3;
            GiaVe = 60000;
            if (temp.Tuoi < 14)
                return false;
            return true;
        }
        ~Drama() { }
    }
}