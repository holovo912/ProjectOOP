using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Data;
using System.Diagnostics.Tracing;
using System.CodeDom;

namespace OOP_CSharp
{
    public static class Cinema
    {
        public static List<Phim> dsphim = new List<Phim>();
        public static List<Phim> dsphimtotal = new List<Phim>();
        public static int num_phim = num_action + num_cartoon + num_drama + num_horror;
        public static List<VIP_KH> dsvip = new List<VIP_KH>();
        public static int num_vip = 5;
        public static List<Cartoon> dscartoon = new List<Cartoon>();
        public static int num_cartoon = 2;
        public static List<Action> dsaction = new List<Action>();
        public static int num_action = 2;
        public static List<Drama> dsdrama = new List<Drama>();
        public static int num_drama = 2;
        public static List<Horror> dshorror = new List<Horror>();
        public static int num_horror = 2;
        public static int num_total = 0;
        public static int cost_total = 0;
        public static List<int> seat = new List<int>();
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
            try
            {
                for (int i = 0; i < num_vip; i++)
                {
                    VIP_KH a = new VIP_KH();
                    string iD = s.ReadLine();
                    string Ten = s.ReadLine();
                    string Tuoi = s.ReadLine();
                    a.Input(iD, Ten, Convert.ToInt32(Tuoi));
                    dsvip.Add(a);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            s.Close();
            f.Close();
        }


        public static void LayThongTinAction(string path)
        {
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            try
            {
                for (int i = 0; i < num_action; i++)
                {
                    Action ac = new Action();
                    string tenphim = s.ReadLine();
                    string Gio = s.ReadLine();
                    string Phut = s.ReadLine();
                    string Gio_End = s.ReadLine();
                    string Phut_End = s.ReadLine();
                    List<int> CNgoi = new List<int>();
                    for (int j = 0; j < 28; j++)
                    {
                        string tmp = s.ReadLine();
                        CNgoi.Add(Convert.ToInt32(tmp));
                    }
                    ac.Input(tenphim, Convert.ToInt32(Gio), Convert.ToInt32(Gio_End), Convert.ToInt32(Phut), Convert.ToInt32(Phut_End), CNgoi);
                    dsaction.Add(ac);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            s.Close();
            f.Close();
        }

        public static void LayThongTinHorror(string path)
        {
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            try
            {
                for (int i = 0; i < num_action; i++)
                {
                    Horror ho = new Horror();
                    string tenphim = s.ReadLine();
                    string Gio = s.ReadLine();
                    string Phut = s.ReadLine();
                    string Gio_End = s.ReadLine();
                    string Phut_End = s.ReadLine();
                    List<int> CNgoi = new List<int>();
                    for (int j = 0; j < 28; j++)
                    {
                        string tmp = s.ReadLine();
                        CNgoi.Add(Convert.ToInt32(tmp));
                    }
                    ho.Input(tenphim, Convert.ToInt32(Gio), Convert.ToInt32(Gio_End), Convert.ToInt32(Phut), Convert.ToInt32(Phut_End), CNgoi);
                    dshorror.Add(ho);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            s.Close();
            f.Close();
        }

        public static void LayThongTinDrama(string path)
        {
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            try
            {
                for (int i = 0; i < num_action; i++)
                {
                    Drama dra = new Drama();
                    string tenphim = s.ReadLine();
                    string Gio = s.ReadLine();
                    string Phut = s.ReadLine();
                    string Gio_End = s.ReadLine();
                    string Phut_End = s.ReadLine();
                    List<int> CNgoi = new List<int>();
                    for (int j = 0; j < 28; j++)
                    {
                        string tmp = s.ReadLine();
                        CNgoi.Add(Convert.ToInt32(tmp));
                    }
                    dra.Input(tenphim, Convert.ToInt32(Gio), Convert.ToInt32(Gio_End), Convert.ToInt32(Phut), Convert.ToInt32(Phut_End), CNgoi);
                    dsdrama.Add(dra);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            s.Close();
            f.Close();
        }

        public static void LayThongTinCartoon(string path)
        {
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            try
            {
                for (int i = 0; i < num_action; i++)
                {
                    Cartoon ca = new Cartoon();
                    string tenphim = s.ReadLine();
                    string Gio = s.ReadLine();
                    string Phut = s.ReadLine();
                    string Gio_End = s.ReadLine();
                    string Phut_End = s.ReadLine();
                    List<int> CNgoi = new List<int>();
                    for (int j = 0; j < 28; j++)
                    {
                        string tmp = s.ReadLine();
                        CNgoi.Add(Convert.ToInt32(tmp));
                    }
                    ca.Input(tenphim, Convert.ToInt32(Gio), Convert.ToInt32(Gio_End), Convert.ToInt32(Phut), Convert.ToInt32(Phut_End), CNgoi);
                    dscartoon.Add(ca);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
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
            Console.WriteLine("  -----------------------------------------------");
            Console.WriteLine("  | Online Movie Tickets Booking by HLV and DQT |");
            Console.WriteLine("  -----------------------------------------------");
            while (key == 0)
            {
                Console.Write("You are Normal(1) or VIP(2) customer? (press 1 or 2): ");
                key = Convert.ToInt32(Console.ReadLine());
                while(key > 2 || key < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong, please press again!");
                    Console.Write("You are Normal(1) or VIP(2) customer? (press 1 or 2): ");
                    key = Convert.ToInt32(Console.ReadLine());
                }
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
                                Console.WriteLine("ID exist, please create another ID");
                                checknor = true;
                            }
                        }
                    }
                    if (key != 0)
                    {
                        Console.Write("Enter your name: ");
                        namenor = Console.ReadLine();
                        Console.Write("Enter your age: ");
                        age = Convert.ToInt32(Console.ReadLine());
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
            PrintTag();
            for (int i = 0; i < dsphim.Count(); i++)
            {
                Console.Write("|  " + Convert.ToString(i + 1).PadLeft(2) + "  ");
                dsphim[i].Infor();
            }
            Console.WriteLine("------------------------------------------------------------");

        }

        public static void ShowAction()
        {
            PrintTag();

            for (int i = 0; i < num_action; i++)
            {
                Console.Write("|  " + Convert.ToString(i + 1).PadLeft(2) + "  ");

                dsaction[i].Infor();
            }
            Console.WriteLine("------------------------------------------------------------");

        }

        public static void ShowCartoon()
        {
            PrintTag();


            for (int i = 0; i < num_cartoon; i++)
            {
                Console.Write("|  " + Convert.ToString(i + 1).PadLeft(2) + "  ");

                dscartoon[i].Infor();
            }
            Console.WriteLine("------------------------------------------------------------");

        }

        public static void ShowHorror()
        {
            PrintTag();


            for (int i = 0; i < num_horror; i++)
            {
                Console.Write("|  " + Convert.ToString(i + 1).PadLeft(2) + "  ");

                dshorror[i].Infor();
            }
            Console.WriteLine("------------------------------------------------------------");

        }

        public static void ShowDrama()
        {
            PrintTag();

            for (int i = 0; i < num_drama; i++)
            {
                Console.Write("|  " + Convert.ToString(i + 1).PadLeft(2) + "  ");

                dsdrama[i].Infor();
            }
            Console.WriteLine("------------------------------------------------------------");
        }
        public static void PrintRunToTal()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("| Num  |  Seat  |   Tag   |      Name       |     Time     |  Room  |");
            Console.WriteLine("---------------------------------------------------------------------");

        }

        public static void PrintTag()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| Num  |   Tag   |      Name       |     Time     |  Room  |");
            Console.WriteLine("------------------------------------------------------------");
        }

        public static void ShowByTime(int gio, int phut)
        {
            Console.WriteLine("---------------------------------------------------------------------");
            for (int i = 0; i < dsphim.Count(); i++)
            {
                if (dsphim[i].CheckTime(gio, phut) == true)
                {
                    Console.Write("|  " + Convert.ToString(i + 1).PadLeft(2) + "  ");
                    dsphim[i].Infor();
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");


        }

        public static void RunMenu()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("| Action: 80000 VND | Cartoon: 40000 VND |");
            Console.WriteLine("| Drama: 60000 VND  | Horror: 80000 VND  |");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("| 0: Total          | 1: Show All        |");
            Console.WriteLine("| 7: Delete Seat    | 2: Tag Action      |");
            Console.WriteLine("|                   | 3: Tag Cartoon     |");
            Console.WriteLine("|                   | 4: Tag Drama       |");
            Console.WriteLine("|                   | 5: Tag Horror      |");
            Console.WriteLine("|                   | 6: Show by Time    |");
            Console.WriteLine("------------------------------------------");
        }

        public static void RunTotal()
        {
            Console.Clear();
            cost_total = 0;
            PrintRunToTal();
            for (int i = 0; i < dsphimtotal.Count(); i++)
            {
                string tmp = "(" + Convert.ToString(seat[i]) + ")";
                Console.Write("|  " + Convert.ToString(i + 1).PadLeft(2) + "  |  " + tmp.PadLeft(6));
                dsphimtotal[i].Infor();
                cost_total += dsphimtotal[i].GetGiaVe();
            }
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Please pay: " + cost_total * (1 - dis) + " VND");
        }

        public static void RunShowPhim()
        {
            while (true)
            {
                RunMenu();
                Console.Write("Enter your choice: ");
                key = Convert.ToInt32(Console.ReadLine());
                if (key == 0)
                {
                    return;
                }
                if (key == 1)
                {
                    ShowAllPhim();
                    Console.Write("Choose movie you want (0: return): ");
                    key2 = Convert.ToInt32(Console.ReadLine());
                    if (key2 == 0 || key2 > dsphim.Count())
                    {
                        Console.Clear();
                        cus.Info();
                    }
                    else if (dsphim[key2 - 1].CheckTuoi(age) == false)
                    {
                        Console.Clear();
                        Console.WriteLine("The movie is resticted for your age, choose another movie");
                        cus.Info();
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.Write("|  " + Convert.ToString(key2).PadLeft(2) + "  ");
                        dsphim[key2 - 1].Infor();
                        Console.WriteLine("------------------------------------------------------------");
                        Console.Write("How many seats you want to pick?: ");
                        int seats;
                        seats = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < seats; i++)
                        {
                            dsphim[key2 - 1].Seat();
                            int temp = dsphim[key2 - 1].ChooseSeat();
                            seat.Add(temp);
                            dsphimtotal.Add(dsphim[key2 - 1]);
                            num_total++;
                        }
                        Console.Clear();
                        Console.WriteLine("Choosed successfully!");
                    }
                }
                if (key == 2)
                {
                    ShowAction();
                    Console.Write("Choose movie you want (0: return): ");
                    key2 = Convert.ToInt32(Console.ReadLine());
                    if (key2 == 0 || key2 > num_action)
                    {
                        Console.Clear();
                        cus.Info();
                    }
                    else if (dsphim[key2 - 1].CheckTuoi(age) == false)
                    {
                        Console.Clear();
                        Console.WriteLine("The movie is resticted for your age, choose another movie");
                        cus.Info();
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.Write("|  " + Convert.ToString(key2).PadLeft(2) + "  ");
                        dsphim[key2 - 1].Infor();
                        Console.WriteLine("------------------------------------------------------------");
                        Console.Write("How many seats you want to pick?: ");
                        int seats;
                        seats = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < seats; i++)
                        {
                            dsphim[key2 - 1].Seat();
                            int temp = dsphim[key2 - 1].ChooseSeat();
                            seat.Add(temp);
                            dsphimtotal.Add(dsphim[key2 - 1]);
                            num_total++;
                        }
                        Console.Clear();
                        Console.WriteLine("Choosed successfully!");
                    }
                }
                if (key == 3)
                {
                    ShowCartoon();
                    Console.Write("Choose movie you want (0: return): ");
                    key2 = Convert.ToInt32(Console.ReadLine());
                    if (key2 == 0 || key2 > num_cartoon)
                    {
                        Console.Clear();
                        cus.Info();
                    }
                    else if (dsphim[key2 - 1].CheckTuoi(age) == false)
                    {
                        Console.Clear();
                        Console.WriteLine("The movie is resticted for your age, choose another movie");
                        cus.Info();
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.Write("|  " + Convert.ToString(key2).PadLeft(2) + "  ");
                        dsphim[key2 - 1].Infor();
                        Console.WriteLine("------------------------------------------------------------");
                        Console.Write("How many seats you want to pick?: ");
                        int seats;
                        seats = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < seats; i++)
                        {
                            dsphim[key2 - 1].Seat();
                            int temp = dsphim[key2 - 1].ChooseSeat();
                            seat.Add(temp);
                            dsphimtotal.Add(dsphim[key2 - 1]);
                            num_total++;
                        }
                        Console.Clear();
                        Console.WriteLine("Choosed successfully!");
                    }
                }
                if (key == 4)
                {
                    ShowDrama();
                    Console.Write("Choose movie you want (0: return): ");
                    key2 = Convert.ToInt32(Console.ReadLine());
                    if (key2 == 0 || key2 > num_drama)
                    {
                        Console.Clear();
                        cus.Info();
                    }
                    else if (dsphim[key2 - 1].CheckTuoi(age) == false)
                    {
                        Console.Clear();
                        Console.WriteLine("The movie is resticted for your age, choose another movie");
                        cus.Info();
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.Write("|  " + Convert.ToString(key2).PadLeft(2) + "  ");
                        dsphim[key2 - 1].Infor();
                        Console.WriteLine("------------------------------------------------------------");
                        Console.Write("How many seats you want to pick?: ");
                        int seats;
                        seats = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < seats; i++)
                        {
                            dsphim[key2 - 1].Seat();
                            int temp = dsphim[key2 - 1].ChooseSeat();
                            seat.Add(temp);
                            dsphimtotal.Add(dsphim[key2 - 1]);
                            num_total++;
                        }
                        Console.Clear();
                        Console.WriteLine("Choosed successfully!");
                    }
                }
                if (key == 5)
                {
                    ShowHorror();
                    Console.Write("Choose movie you want (0: return): ");
                    key2 = Convert.ToInt32(Console.ReadLine());
                    if (key2 == 0 || key2 > num_horror)
                    {
                        Console.Clear();
                        cus.Info();
                    }
                    else if (dsphim[key2 - 1].CheckTuoi(age) == false)
                    {
                        Console.Clear();
                        Console.WriteLine("The movie is resticted for your age, choose another movie");
                        cus.Info();
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.Write("|  " + Convert.ToString(key2).PadLeft(2) + "  ");
                        dsphim[key2 - 1].Infor();
                        Console.WriteLine("------------------------------------------------------------");
                        Console.Write("How many seats you want to pick?: ");
                        int seats;
                        seats = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < seats; i++)
                        {
                            dsphim[key2 - 1].Seat();
                            int temp = dsphim[key2 - 1].ChooseSeat();
                            seat.Add(temp);
                            dsphimtotal.Add(dsphim[key2 - 1]);
                            num_total++;
                        }
                        Console.Clear();
                        Console.WriteLine("Choosed successfully!");
                    }
                }
                if (key == 6)
                {
                    int hour;
                    Console.Write("Hour: ");
                    hour = Convert.ToInt32(Console.ReadLine());
                    int minus;
                    Console.Write("Minus: ");
                    minus = Convert.ToInt32(Console.ReadLine());
                    ShowByTime(hour, minus);
                    Console.Write("Choose movie you want (0: return): ");
                    key2 = Convert.ToInt32(Console.ReadLine());
                    if (key2 != 0)
                    {
                        bool check = dsphim[key2 - 1].CheckTime(hour, minus);
                        while (check == false)
                        {
                            Console.Write("Invalid, please choose again! ");
                            Console.Write("Choose movie you want (0: return): ");
                            key2 = Convert.ToInt32(Console.ReadLine());
                            if (key2 == 0)
                            {
                                check = true;
                            }
                            else
                            {
                                check = dsphim[key2 - 1].CheckTime(hour, minus);
                            }
                        }
                    }
                    if (key2 == 0 || key2 > dsphim.Count())
                    {
                        Console.Clear();
                        cus.Info();
                    }
                    else if (dsphim[key2 - 1].CheckTuoi(age) == false)
                    {
                        Console.Clear();
                        Console.WriteLine("The movie is resticted for your age, choose another movie");
                        cus.Info();
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.Write("|  " + Convert.ToString(key2).PadLeft(2) + "  ");
                        dsphim[key2 - 1].Infor();
                        Console.WriteLine("------------------------------------------------------------");
                        Console.Write("How many seats you want to pick?: ");
                        int seats;
                        seats = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < seats; i++)
                        {
                            dsphim[key2 - 1].Seat();
                            int temp = dsphim[key2 - 1].ChooseSeat();
                            seat.Add(temp);
                            dsphimtotal.Add(dsphim[key2 - 1]);
                            num_total++;
                        }
                        Console.Clear();
                        Console.WriteLine("Choosed successfully!");
                    }
                }
                if (key == 7)
                {
                    Console.Clear();
                    cost_total = 0;
                    for (int i = 0; i < dsphimtotal.Count(); i++)
                    {
                        string tmp = "(" + Convert.ToString(seat[i]) + ")";
                        Console.Write("|  " + Convert.ToString(i + 1).PadLeft(2) + "  |  " + tmp.PadLeft(6));
                        dsphimtotal[i].Infor();
                        cost_total += dsphimtotal[i].GetGiaVe();
                    }
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine("Total: " + cost_total * (1 - dis) + " VND");
                    Console.Write("Choose movie you want to delete (0: return): ");
                    key2 = Convert.ToInt32(Console.ReadLine());
                    if (key2 == 0 || key2 > dsphimtotal.Count())
                    {
                        Console.Clear();
                        cus.Info();
                    }
                    else
                    {
                        num_total--;
                        dsphimtotal[key2 - 1].UpdateSeat(seat[key2 - 1]);
                        dsphimtotal.RemoveAt(key2 - 1);
                        Console.Clear();
                        Console.WriteLine("Deleted successfully!");
                    }
                }
            }
        }
    }
}