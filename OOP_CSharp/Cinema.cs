using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OOP_CSharp
{
    public static class Cinema
    {
        protected List<Phim> dsphim;
        protected int num_phim = num_action + num_cartoon + num_drama + num_horror;;
        protected List<VIP_KH> dsvip = new List<VIP_KH>();
        protected int num_vip = 5;
        protected List<Cartoon> dscartoon;
        protected num_cartoon = 2;
        protected List<Action> dsaction;
        protected num_action = 2;
        protected List<Drama> dsdrama;
        protected num_drama = 2;
        protected List<Horror> dshorror;
        protected num_horror = 2;


        // Lấy thông tin từ file
        public static void LayThongTinVip()
        {

        }

        public static void LayThongTinAction()
        {

        }

        public static void LayThongTinHorror()
        {

        }

        public static void LayThongTinDrama()
        {

        }

        public static void LayThongTinCartoon()
        {

        }
        ~Cinema() { }
    }
}