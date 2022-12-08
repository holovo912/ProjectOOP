namespace OOP_CSharp
{
    public class NOR_Cus : Customer
    {
        public NOR_Cus() : base() { }
        public override void Input(string ID, string ten, int tuoi)
        {
            this.ID = ID;
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.Giamgia = 0.1;
        }
        ~NOR_Cus() { }
    }
}