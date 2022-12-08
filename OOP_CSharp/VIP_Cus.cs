namespace OOP_CSharp
{
    public class VIP_Cus : Customer
    {
        public override void Input(string ID, string ten, int tuoi)
        {
            this.ID = ID;
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.Giamgia = 0.2;
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
        ~VIP_Cus() { }
    }
}