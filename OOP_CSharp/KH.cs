using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public class KH
    {
        private string ten;
        private string iD;
        private int tuoi;
        private double giamgia;

        public string Ten { get => ten; set => ten = value; }
        public string ID { get => iD; set => iD = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public double Giamgia { get => giamgia; set => giamgia = value; }

        public KH()
        {

        }

        ~KH() { }

        public virtual void Input(string ID, string ten, int tuoi)
        {
            
        }

        public virtual void Info()
        {
            string tmp = "|";
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|" + " ID: " + this.ID.PadRight(35) + tmp);
            Console.WriteLine("|" + " Name: " + this.Ten.PadRight(33) + tmp);
            Console.WriteLine("|" + " Age: " + Convert.ToString(this.Tuoi).PadRight(34) + tmp);
            Console.WriteLine("|" + " Discount: " + (this.Giamgia * 100 + "%").PadRight(29) + tmp);
            Console.WriteLine("------------------------------------------");
        }
        public virtual double Discount()
        {
            return this.Giamgia;
        }
    }
}