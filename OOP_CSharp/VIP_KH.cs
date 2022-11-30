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
            this.ten = ten;
            this.tuoi = tuoi;
            this.giamgia = 0.2;
        }
        public void CheckID(string idvip)
        {
            if(idvip == this.ID)
            {
                return true;
            }
            return false;
        }
        public override void Infor()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("ID: " + this.ID);
            Console.WriteLine("Name: " + this.ten);
            Console.WriteLine("Age: " + this.tuoi);
            Console.WriteLine("Discount: " + this.giamgia * 100 + "%");
            Console.WriteLine("------------------------------------------------");

        }

        public override double Discount()
        {
            return giamgia;
        }
        ~VIP_KH() { }
    }
}