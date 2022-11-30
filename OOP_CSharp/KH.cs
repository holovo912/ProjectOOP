using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public class KH
    {
        protected string ten;
        protected string ID;
        protected int tuoi;
        protected double giamgia;
        public KH()
        {

        }

        ~KH() { }

        public virtual void Input(string ID, string ten, int tuoi)
        {
            
        }

        public virtual void Info()
        {

        }
        public virtual double Discount()
        {
            return this.giamgia;
        }
    }
}