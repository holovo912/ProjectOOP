using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace OOP_CSharp
{
    public class Action : Phim
    {
        public Action() : base()
        { }
        public override bool CheckTuoi(KH temp)
        {
            Tag = 1;
            GiaVe = 80000;
            if (temp.Tuoi < 16)
                return false;
            return true;
        }
        ~Action() { }
    }
}