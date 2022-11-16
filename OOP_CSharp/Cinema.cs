using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public class Cinema
    {
        private DanhSachPhim dsphim;
        private int num_phim;
        private List<Phong> dsphong = new List<Phong>();
        private int num_phong;
        private List<VIP_KH> dsvip = new List<VIP_KH>();
        private int num_vip;
        public int num_Phim { get => num_phim; set => num_phim = value; }
        public int num_Phong { get => num_phong; set => num_phong = value; }
        public int num_Vip { get => num_vip; set => num_vip = value; }
        public List<Phong> DsPhong { get => dsphong; set => dsphong = value; }
        public List<VIP_KH> DsVIP { get => dsvip; set => dsvip = value; }
        public DanhSachPhim DsPhim { get => dsphim; set => dsphim = value; }
        public Cinema()
        {
            DanhSachPhim DsPhim = new DanhSachPhim();
            List<Phong> DsPhong = new List<Phong>();
            List<VIP_KH> DsVIP = new List<VIP_KH>();
        }
        // Lấy thông tin từ file
        public void Nhap()
        {
            num_Phong = 4;
            num_Vip = 3;

            // Khởi tạo ghế cho mỗi phòng
            for (int i = 1; i <= num_Phong; i++)
            {
                Phong temp = new Phong();
                temp.TaoGhe();
                DsPhong.Add(temp);
            }
            // Tạo giá trị tạm để lấy thông tin phim
            DanhSachPhim tmp = new DanhSachPhim();
            tmp.LayPhim();
            DsPhim = tmp;

            // Lấy thông tin khách hàng VIP
            for (int i = 1; i <= num_Vip; i++)
            {
                VIP_KH t = new VIP_KH();
                t.LayThongTin();
                DsVIP.Add(t);
            }
        }
        //a
        public void showPhim(int key)
        {
            DsPhim.Show();
        }
        // Chạy chương trình
        public void Run()
        {
            int key = 0;
            while (key == 0)
            {
                Console.Write("You are Normal or VIP customer ? (press 1 or 2): ");
                key = Convert.ToInt32(Console.ReadLine());
                if (key == 1)
                    break;
                if (key == 2)
                {
                    key = 0;
                    string idVIP;
                    Console.Write("Enter your ID: ");
                    idVIP = Console.ReadLine();
                    DsVIP[0].IdVIP = "hlv";
                    for (int i = 0; i < num_vip; i++)
                    {
                        if (idVIP == DsVIP[i].IdVIP)
                            key = 2;
                    }
                    if (key == 0)
                        Console.WriteLine("Wrong ID, please type again or call: 19000091");
                }
            }
            
        }
        ~Cinema() { }
    }
}