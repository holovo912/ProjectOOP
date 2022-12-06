namespace OOP_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema.LayThongTinVip("..\\..\\..\\VIP.txt");
            Cinema.LayThongTinAction("..\\..\\..\\Action.txt");
            Cinema.LayThongTinCartoon("..\\..\\..\\Cartoon.txt");
            Cinema.LayThongTinDrama("..\\..\\..\\Drama.txt");
            Cinema.LayThongTinHorror("..\\..\\..\\Horror.txt");
            Cinema.LayHetPhim();
            Cinema.RunSignIn();
            Cinema.RunShowPhim();
            Cinema.RunTotal();
        }
    }
}
