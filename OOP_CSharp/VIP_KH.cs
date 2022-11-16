using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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
            FileStream fs = new FileStream("C:\\Users\\QuangTrieu's PC\\OneDrive\\Documents\\GitHub\\ProjectOOP\\VIP.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            this.IdVIP = rd.ReadToEnd();
        }
      
        ~VIP_KH() { }
    }
}