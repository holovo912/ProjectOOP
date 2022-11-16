using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public class VIP_KH : KH
    {
        private string idvip;
        public string IdVIP { get => idvip; set => idvip = value; }
        public VIP_KH() : base() { }
        public override void Nhap()
        {
            GiamGia = 0.2;
            base.Nhap();
        }
        public void LayThongTin()
        {
            Console.WriteLine("OK VIP");
        }
        ~VIP_KH() { }
    }
}