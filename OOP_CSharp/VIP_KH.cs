using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public class VIP_KH : KH
    {
        public override void Input(string ID, string ten, int tuoi)
        {
            this.ID = ID;
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.Giamgia = 0.2;
        }
        public bool CheckID(string idvip)
        {
            if (idvip == this.ID)
            {
                return true;
            }
            return false;
        }
        public override void Info()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("ID: " + this.ID);
            Console.WriteLine("Name: " + this.Ten);
            Console.WriteLine("Age: " + this.Tuoi);
            Console.WriteLine("Discount: " + this.Giamgia * 100 + "%");
            Console.WriteLine("------------------------------------------------");

        }

        public override double Discount()
        {
            return Giamgia;
        }
        ~VIP_KH() { }
    }
}