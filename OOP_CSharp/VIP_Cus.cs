using System.Collections.Generic;

namespace OOP_CSharp
{
    public class VIP_Cus : Customer
    {
        public VIP_Cus() : base() { }
        public override void Input(string ID, string ten, int tuoi)
        {
            this.ID = ID;
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.Giamgia = 0.2;
        }
        ~VIP_Cus() { }
    }
}