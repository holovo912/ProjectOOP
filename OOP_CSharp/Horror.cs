using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public class Horror : Phim
    {
        public Horror() : base()
        { }
        public override bool CheckTuoi(KH temp)
        {
            Tag = 4;
            GiaVe = 80000;
            return true;
        }
        ~Horror() { }
    }
}