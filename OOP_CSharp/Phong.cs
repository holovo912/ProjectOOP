using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OOP_CSharp
{
    public class Phong
    {
        private int soghe;
        List<int> ChoNgoi = new List<int>();
        public int SoGhe { get => soghe; set => soghe = value; }
        public Phong()
        {
            List<int> ChoNgoi = new List<int>();
        }
        public void TaoGhe()
        {
            Console.WriteLine("OK Ghe");
            SoGhe = 21;
            for (int i = 1; i <= SoGhe; i++)
            {
                ChoNgoi.Add(i);
            }                
        }
        public void LayThongTin()
        {

        }
        ~Phong() { }
    }
}