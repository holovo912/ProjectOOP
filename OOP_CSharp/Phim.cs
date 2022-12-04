using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp
{
    public class Phim
    {
        private string tenphim;
        private int gio;
        private int gio_end;
        private int phut;
        private int phut_end;
        private int giave;
        private int tag;
        private int phong;
        private List<int> choNgoi;
        private string tag_name;

        public string Tenphim { get => tenphim; set => tenphim = value; }
        public int Gio { get => gio; set => gio = value; }
        public int Gio_end { get => gio_end; set => gio_end = value; }
        public int Phut { get => phut; set => phut = value; }
        public int Phut_end { get => phut_end; set => phut_end = value; }
        public int Giave { get => giave; set => giave = value; }
        public int Tag { get => tag; set => tag = value; }
        public int Phong { get => phong; set => phong = value; }
        public List<int> ChoNgoi { get => choNgoi; set => choNgoi = value; }
        public string Tag_name { get => tag_name; set => tag_name = value; }

        public Phim()
        {

        }

        public Phim(string tenphim, int gio, int gio_end, int phut, int phut_end, List<int> choNgoi, string tag_name)
        {
            this.Tenphim = tenphim;
            this.Gio = gio;
            this.Gio_end = gio_end;
            this.Phut = phut;
            this.Phut_end = phut_end;
            this.ChoNgoi = choNgoi;
            this.Tag_name = tag_name;
        }

        


        public virtual void Input(string tenphim, int gio, int gio_end, int phut, int phut_end, List<int> ChoNgoi)
        {
            this.Tenphim = tenphim;
            this.Gio = gio;
            this.Phut = phut;
            this.Phut_end = phut_end;
            this.Gio_end = gio_end;
            this.ChoNgoi = ChoNgoi;
        }

        public virtual bool CheckTuoi(int tuoi)
        {
            return true;
        }

        public virtual void Infor()
        { 
            if (this.Tag == 1)
                this.Tag_name = "Action";
            else if (this.Tag == 2)
                this.Tag_name = "Cartoon";
            else if (this.Tag == 3)
                this.Tag_name = "Drama";
            else if (this.Tag == 4)
                this.Tag_name = "Horror";
            Console.Write("| ");
            Console.Write(this.Tag_name.PadLeft(11));
            Console.Write(this.Tenphim.PadLeft(14));
            Console.Write(" " + this.Gio);
            Console.Write(":" + this.Phut);
            Console.Write(" -- " + this.Gio_end);
            Console.Write(":" + this.Phut_end);
            Console.Write("   Room: " + this.Phong);
            Console.Write(" |");
            Console.WriteLine(" ");
        }

        public virtual void Seat()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-                ==============                 -");
            Console.WriteLine("-                ==  Screen  ==                 -");
            Console.WriteLine("-                ==============                 -");
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("     ");
                for (int j = 1; j <= 28 / 4; j++)
                {
                    Console.Write("  ");
                    Console.Write(ChoNgoi[count] + "  ");
                    count++;
                }
                Console.WriteLine("       ");
            }
            Console.WriteLine("-------------------------------------------------");
        }

        public virtual int GetGiaVe()
        {
            return this.Giave;
        }

        public virtual bool CheckSeat(int i)
        {
            if (ChoNgoi[i - 1] == 0)
                return false;
            return true;
        }

        public virtual int ChooseSeat()
        {

            Console.WriteLine("Choose seat: ");
            int i = Convert.ToInt32(Console.ReadLine());
            while (i <= 0 || i > 28)
            {
                Console.WriteLine("Invalid seat, please choose again !!!");
                Console.Write("Choose seat: ");
                i = Convert.ToInt32(Console.ReadLine());
            }
            while (ChoNgoi[i - 1] == 0)
            {
                Console.WriteLine("Seat choosen, choose another seat !!!");
                Console.Write("Choose seat: ");
                i = Convert.ToInt32(Console.ReadLine());
            }
            ChoNgoi[i - 1] = 0;
            return i;
        }
        ~Phim() { }
    }
}
