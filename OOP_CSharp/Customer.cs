using System;

namespace OOP_CSharp
{
    interface IInputID
    {
        void InputID(string id);
    }
    interface IDisCount
    {
        double Discount();
    }
    public class Customer : IInputID , IDisCount
    {
        private string ten;
        private string iD;
        private int tuoi;
        private double giamgia;

        public string Ten { get => ten; set => ten = value; }
        public string ID { get => iD; set => iD = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public double Giamgia { get => giamgia; set => giamgia = value; }
        public Customer() { }
        ~Customer() { }
        public virtual void Input(string ID, string ten, int tuoi)
        {

        }
        public void Info()
        {
            string tmp = "|";
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|" + " ID: " + this.ID.PadRight(35) + tmp);
            Console.WriteLine("|" + " Name: " + this.Ten.PadRight(33) + tmp);
            Console.WriteLine("|" + " Age: " + Convert.ToString(this.Tuoi).PadRight(34) + tmp);
            Console.WriteLine("|" + " Discount: " + (this.Giamgia * 100 + "%").PadRight(29) + tmp);
        }
        public double Discount()
        {
            return this.Giamgia;
        }
        public void InputID(string id)
        {
            ID = id;
        }
        public override bool Equals(object o)
        {
            if (o == null)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public static bool operator ==(Customer d1, VIP_Cus d2)
        {
            if (d1.ID == d2.ID) return true;
            return false;
        }
        public static bool operator !=(Customer d1, VIP_Cus d2)
        {
            if (d1.ID == d2.ID) return false;
            return true;
        }
    }
}