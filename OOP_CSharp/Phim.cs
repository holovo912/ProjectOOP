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
        protected string tenphim;
        protected int gio;
        protected int gio_end;
        protected int phut;
        protected int phut_end;
        protected int giave;
        protected int tag;
        protected int phong;
        protected List<int> ChoNgoi;
        public Phim()
        {
        
        }

        ~Phim() { }


        public virtual void Input(string tenphim, int gio, int gio_end, int phut, int phut_end,  List<int> ChoNgoi)
        {
            this.tenphim = tenphim;
            this.gio = gio;
            this.phut = phut;
            this.phut_end = phut_end;
            this.gio_end = gio_end;
            this.ChoNgoi = ChoNgoi;
        }

        public virtual bool CheckTuoi(int tuoi)
        {
            return true;
        }

        public void Infor()
        {
            string tag_name;
            if (this.tag == 1)
			    tag_name = "Action";
		    if (this.tag == 2)
			    tag_name = "Cartoon";
		    if (this.tag == 3)
			    tag_name = "Drama";
		    if (this.tag == 4)
			    tag_name = "Horror";
		    Console.WriteLine("| " + tag_name.PadLeft(11));
            Console.Write(this.tenphim.PadLeft(14));
            Console.Write(" " + this.gio); 
            Console.Write(": " + this.phut);   
            Console.Write("-- " + this.gio_end);   
            Console.Write(": " + this.phut_end);
            Console.Write("   Room: " + this.phong);
            Console.Write(" |");
            Console.WriteLine(" ");     
        }

        public void Seat()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-                ==============                 -");
            Console.WriteLine("-                ==  Screen  ==                 -");
            Console.WriteLine("-                ==============                 -");
            int count = 0;
            for(int i = 0; i < 4; i++)
            {
                Console.Write("-             ");
                for(int j = 1; j <= 28/4; j++)
                {
                    Console.Write("  ");
                    Console.Write(ChoNgoi[count]);
                    Console.Write(" ");
                    count++;
                }
                Console.WriteLine("             -");
            }
            Console.WriteLine("-------------------------------------------------");
        }

        public int GetGiaVe()
        {
            return this.giave;
        }

        public bool CheckSeat(int i)
        {
            if (ChoNgoi[i - 1] == 0)
			    return false;
		    return true;
        }

        public int ChooseSeat()
        {
            int i;
            Console.WriteLine("Choose seat: ");
            Console.ReadLine(i);
            while(i <= 0 || i > 28)
            {
                Console.WriteLine("Invalid seat, please choose again !!!");
                Console.Write("Choose seat: ");
                Console.ReadLine(i);
            }
            while (ChoNgoi[i - 1] == 0)
            {
                Console.WriteLine("Seat choosen, choose another seat !!!");
			    Console.Write("Choose seat: ");
			    Console.ReadLine(i);
            }
            ChoNgoi[i - 1] = 0;
		    return i;
        }
    }
}
