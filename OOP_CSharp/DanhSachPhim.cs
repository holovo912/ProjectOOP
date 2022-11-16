using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public class DanhSachPhim
    {
        public int test;
        private List<Phim> dsall;
        private List<Action> dsAction;
        private List<Cartoon> dsCartoon;
        private List<Drama> dsDrama;
        private List<Horror> dsHorror;

        public List<Phim> DsAll { get => dsall; set => dsall = value; }
        public List<Action> DsAction { get => dsAction; set => dsAction = value; }
        public List<Cartoon> DsCartoon { get => dsCartoon; set => dsCartoon = value; }
        public List<Drama> DsDrama { get => dsDrama; set => dsDrama = value; }
        public List<Horror> DsHorror { get => dsHorror; set => dsHorror = value; }
        public DanhSachPhim()
        {
            List<Phim> DsAll = new List<Phim>();
            List<Action> DsAction = new List<Action>();
            List<Cartoon> DsCartoon = new List<Cartoon>();
            List<Drama> DsDrama = new List<Drama>();
            List<Horror> DsHorror = new List<Horror>();
        }
        public void LayPhim()
        {
            test = 1;
            Console.WriteLine("OK Phim");
        }
        public void Show()
        {
            for (int i = 0; i < DsAll.Count; i++)
            {
                string[] cate = { "Action", "Cartoon", "Drama", "Horror" };
                Console.WriteLine(DsAll[i].TenPhim + "   " + cate[DsAll[i].Tag - 1]);
            }
        }
        ~DanhSachPhim() { }
    }
}