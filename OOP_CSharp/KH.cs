using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public class KH
    {
        private string ten { get ; set ; }
        private int tuoi;
        private double giamgia;
        public KH()
        {
        }
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public double GiamGia { get => giamgia; set => giamgia = value; }
        public virtual void Nhap()
        {
            Console.Write("Enter your name: ");
            Ten = Console.ReadLine();
            Console.Write("Your age: ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
        }
        ~KH() { }

    }
}