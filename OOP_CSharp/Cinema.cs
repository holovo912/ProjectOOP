using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Data;

namespace OOP_CSharp
{
    public static class Cinema
    {
        public static List<Phim> dsphim;
        public static List<Phim> dsphimtotal;
        public static int num_phim = num_action + num_cartoon + num_drama + num_horror;
        public static List<VIP_KH> dsvip;
        public static int num_vip = 5;
        public static List<Cartoon> dscartoon;
        public static int num_cartoon = 2;
        public static List<Action> dsaction;
        public static int num_action = 2;
        public static List<Drama> dsdrama;
        public static int num_drama = 2;
        public static List<Horror> dshorror;
        public static int num_horror = 2;
        public static int num_total = 0;
        public static int cost_total = 0;
        public static List<int> seat;
        public static int key = 0;
        public static int key2 = 0;
        public static int nor_type = 0;
        public static int age = 18;
        public static string idnor;
        public static string namenor;
        public static double dis = 0;
        public static KH cus = new KH();

        // Lấy thông tin từ file
        public static void LayThongTinVip(string path)
        {
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            for (int i = 0; i < num_vip; i++)
            {
                VIP_KH a = new VIP_KH();
                string iD = s.ReadLine();
                string Ten = s.ReadLine();
                int Tuoi = s.Read();
                a.Input(iD, Ten, Tuoi);
                dsvip.Add(a);
            }
            s.Close();
            f.Close();
        }

        public static void LayThongTinAction(string path)
        {
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            for (int i = 0; i < num_action; i++)
            {
                Action ac = new Action();
                string tenphim = s.ReadLine();
                int Gio = s.Read();
                int Phut = s.Read();
                int Gio_End = s.Read();
                int Phut_End = s.Read();
                List<int> CNgoi = new List<int>();
                for (int j = 0; j < 28; j++)
                {
                    int tmp = s.Read();
                    CNgoi.Add(tmp);
                }
                ac.Input(tenphim, Gio, Gio_End, Phut, Phut_End, CNgoi);
                dsaction.Add(ac);
            }
            s.Close();
            f.Close();
        }

        public static void LayThongTinHorror(string path)
        {
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            for (int i = 0; i < num_action; i++)
            {
                Horror ho = new Horror();
                string tenphim = s.ReadLine();
                int Gio = s.Read();
                int Phut = s.Read();
                int Gio_End = s.Read();
                int Phut_End = s.Read();
                List<int> CNgoi = new List<int>();
                for (int j = 0; j < 28; j++)
                {
                    int tmp = s.Read();
                    CNgoi.Add(tmp);
                }
                ho.Input(tenphim, Gio, Gio_End, Phut, Phut_End, CNgoi);
                dshorror.Add(ho);
            }
            s.Close();
            f.Close();
        }

        public static void LayThongTinDrama(string path)
        {
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            for (int i = 0; i < num_drama; i++)
            {
                Drama dra = new Drama();
                string tenphim = s.ReadLine();
                int Gio = s.Read();
                int Phut = s.Read();
                int Gio_End = s.Read();
                int Phut_End = s.Read();
                List<int> CNgoi = new List<int>();
                for (int j = 0; j < 28; j++)
                {
                    int tmp = s.Read();
                    CNgoi.Add(tmp);
                }
                dra.Input(tenphim, Gio, Gio_End, Phut, Phut_End, CNgoi);
                dsdrama.Add(dra);
            }
            s.Close();
            f.Close();
        }

        public static void LayThongTinCartoon(string path)
        {
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            for (int i = 0; i < num_drama; i++)
            {
                Cartoon ca = new Cartoon();
                string tenphim = s.ReadLine();
                int Gio = s.Read();
                int Phut = s.Read();
                int Gio_End = s.Read();
                int Phut_End = s.Read();
                List<int> CNgoi = new List<int>();
                for (int j = 0; j < 28; j++)
                {
                    int tmp = s.Read();
                    CNgoi.Add(tmp);
                }
                ca.Input(tenphim, Gio, Gio_End, Phut, Phut_End, CNgoi);
                dscartoon.Add(ca);
            }
            s.Close();
            f.Close();
        }

        public static void LayHetPhim()
        {
            for (int i = 0; i < dsaction.Count(); i++)
            {
                dsphim.Add(dsaction[i]);
            }
            for (int i = 0; i < dshorror.Count(); i++)
            {
                dsphim.Add(dshorror[i]);
            }
            for (int i = 0; i < dsdrama.Count(); i++)
            {
                dsphim.Add(dsdrama[i]);
            }
            for (int i = 0; i < dscartoon.Count(); i++)
            {
                dsphim.Add(dscartoon[i]);
            }
        }

        public static void RunSignIn()
        {
            while (key == 0)
            {
                Console.Write("You are Normal(1) or VIP(2) customer? (press 1 or 2): ");
                key = Convert.ToInt32(Console.Read());
                if (key == 1)
                {
                    NOR_KH nor = new NOR_KH();
                    bool checknor = true;
                    while (checknor == true)
                    {
                        checknor = false;
                        Console.Write("Create your ID (0: return): ");
                        idnor = Console.ReadLine();
                        if (idnor == "0")
                        {
                            key = 0;
                            break;
                        }
                        for (int i = 0; i < num_vip; i++)
                        {
                            if (dsvip[i].CheckID(idnor))
                            {
                                Console.Clear();
                                Console.Write("ID exist, please create another ID");
                                checknor = true;
                            }
                        }
                    }
                    if (key != 0)
                    {
                        Console.Write("Enter your name: ");
                        namenor = Console.ReadLine();
                        Console.Write("Enter your age: ");
                        age = Console.Read();
                        nor.Input(idnor, namenor, age);
                        dis = nor.Discount();
                        nor_type = 1;
                        Console.Clear();
                        cus = nor;
                        break;
                    }
                    Console.Clear();
                }
                else if (key == 2)
                {
                    string idVip;
                    bool checkvip = true;
                    while (checkvip == true)
                    {
                        Console.Write("Enter your VIP ID (0: return): ");
                        idVip = Console.ReadLine();
                        if (idVip == "0")
                        {
                            key = 0;
                            Console.Clear();
                            break;
                        }
                        for (int i = 0; i < num_vip; i++)
                        {
                            if (dsvip[i].CheckID(idVip))
                            {
                                Console.Clear();
                                Console.WriteLine("Successfully accessed! ");
                                cus = dsvip[i];
                                dis = dsvip[i].Discount();
                                nor_type = 3;
                                key = 3;
                                checkvip = false;
                                break;
                            }
                        }
                        if (key != 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Wrong ID, please type again or call: 19000091! ");

                        }

                    }
                }
            }
            cus.Info();
        }

        public static void ShowAllPhim()
        {
            Console.WriteLine("-------------------------------------------------------");
            for (int i = 0; i < num_phim; i++)
            {
                Console.Write((i + 1) + ": ");
                dsphim[i].Infor();
            }
            Console.WriteLine("-------------------------------------------------------");
        }

        public static void ShowAction()
        {
            Console.WriteLine("-------------------------------------------------------");
            for (int i = 0; i < num_action; i++)
            {
                Console.Write((i + 1) + ": ");
                dsaction[i].Infor();
            }
            Console.WriteLine("-------------------------------------------------------");
        }

        public static void ShowCartoon()
        {
            Console.WriteLine("-------------------------------------------------------");
            for (int i = 0; i < num_cartoon; i++)
            {
                Console.Write((i + 1) + ": ");
                dscartoon[i].Infor();
            }
            Console.WriteLine("-------------------------------------------------------");
        }

        public static void ShowHorror()
        {
            Console.WriteLine("-------------------------------------------------------");
            for (int i = 0; i < num_horror; i++)
            {
                Console.Write((i + 1) + ": ");
                dshorror[i].Infor();
            }
            Console.WriteLine("-------------------------------------------------------");
        }

        public static void ShowDrama()
        {
            Console.WriteLine("-------------------------------------------------------");
            for (int i = 0; i < num_drama; i++)
            {
                Console.Write((i + 1) + ": ");
                dsdrama[i].Infor();
            }
            Console.WriteLine("-------------------------------------------------------");
        }

        public static void RunShowPhim()
        {
            Console.WriteLine("|0: Total | 1: Show All | 2: Show Action | 3: Show Cartoon | 4: Show Drama | 5: Show Horror |");
            Console.WriteLine("Enter your choice: ");
            key = Console.Read();
            if(key == 0)
            {
                Console.Clear();
                for (int i = 0; i < num_total; i++)
                {
                    string tmp = "| Seat(" + Convert.ToString(seat[i]) + ")";
                    Console.Write("|" + (i + 1) + ": " + tmp.PadLeft(11));
                    dsphimtotal[i].Infor();
                    cost_total += dsphimtotal[i].GetGiaVe();
                }
                Console.Write("Total: " + cost_total*(1-dis) + " VND");
                return;
            }
            else if(key == 1)
            {
                ShowAllPhim();
                Console.Write("Choose movie you want: ");
                key2 = Console.Read();
                if (dsphim[key2 - 1].CheckTuoi(age) == false)
                {
                    Console.Clear();
                    Console.WriteLine("The movie is resticted for your age, choose another movie");
                    cus.Info();
                }
                else
                {
                    dsphim[key2 - 1].Infor();
                    dsphim[key2 - 1].Seat();
                    int temp = dsphim[key2 - 1].ChooseSeat();
                    seat.Add(temp);
                    dsphimtotal.Add(dsphim[key2 - 1]);
                    num_total++;
                    Console.Clear();
                    Console.WriteLine("Choosed successfully!");
                }
            }
            else if (key == 2)
            {
                ShowAction();
                Console.Write("Choose movie you want: ");
                if (dsphim[key2 - 1].CheckTuoi(age) == false)
                {
                    Console.Clear();
                    Console.WriteLine("The movie is resticted for your age, choose another movie");
                    cus.Info();
                }
                else
                {
                    dsphim[key2 - 1].Infor();
                    dsphim[key2 - 1].Seat();
                    int temp = dsphim[key2 - 1].ChooseSeat();
                    seat.Add(temp);
                    dsphimtotal.Add(dsphim[key2 - 1]);
                    num_total++;
                    Console.Clear();
                    Console.WriteLine("Choosed successfully!");
                }
            }
            else if(key == 3)
            {
                ShowCartoon();
                Console.Write("Choose movie you want: ");
                if (dsphim[key2 - 1].CheckTuoi(age) == false)
                {
                    Console.Clear();
                    Console.WriteLine("The movie is resticted for your age, choose another movie");
                    cus.Info();
                }
                else
                {
                    dsphim[key2 - 1].Infor();
                    dsphim[key2 - 1].Seat();
                    int temp = dsphim[key2 - 1].ChooseSeat();
                    seat.Add(temp);
                    dsphimtotal.Add(dsphim[key2 - 1]);
                    num_total++;
                    Console.Clear();
                    Console.WriteLine("Choosed successfully!");
                }
            }
            else if(key == 4)
            {
                ShowDrama();
                Console.Write("Choose movie you want: ");
                if (dsphim[key2 - 1].CheckTuoi(age) == false)
                {
                    Console.Clear();
                    Console.WriteLine("The movie is resticted for your age, choose another movie");
                    cus.Info();
                }
                else
                {
                    dsphim[key2 - 1].Infor();
                    dsphim[key2 - 1].Seat();
                    int temp = dsphim[key2 - 1].ChooseSeat();
                    seat.Add(temp);
                    dsphimtotal.Add(dsphim[key2 - 1]);
                    num_total++;
                    Console.Clear();
                    Console.WriteLine("Choosed successfully!");
                }
            }
            else if(key == 5)
            {
                ShowHorror();
                Console.Write("Choose movie you want: ");
                if (dsphim[key2 - 1].CheckTuoi(age) == false)
                {
                    Console.Clear();
                    Console.WriteLine("The movie is resticted for your age, choose another movie");
                    cus.Info();
                }
                else
                {
                    dsphim[key2 - 1].Infor();
                    dsphim[key2 - 1].Seat();
                    int temp = dsphim[key2 - 1].ChooseSeat();
                    seat.Add(temp);
                    dsphimtotal.Add(dsphim[key2 - 1]);
                    num_total++;
                    Console.Clear();
                    Console.WriteLine("Choosed successfully!");
                }
            }
        }
    }
}