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
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("ID: " + this.ID);
            Console.WriteLine("Name: " + this.Ten);
            Console.WriteLine("Age: " + this.Tuoi);
            Console.WriteLine("Discount: " + this.Giamgia * 100 + "%");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }
        public virtual double Discount()
        {
            return this.Giamgia;
        }
    }
}