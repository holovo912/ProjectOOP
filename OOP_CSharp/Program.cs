namespace OOP_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema.LayThongTinVip(@"C:\\Users\\QuangTrieu's PC\\OneDrive\\Documents\\GitHub\\ProjectOOP\\ProjectOOP\\VIP.txt\");
            Cinema.LayThongTinAction(@"C:\\Users\\QuangTrieu's PC\\OneDrive\\Documents\\GitHub\\ProjectOOP\\ProjectOOP\\Action.txt\");
            Cinema.LayThongTinCartoon(@"C:\\Users\\QuangTrieu's PC\\OneDrive\\Documents\\GitHub\\ProjectOOP\\ProjectOOP\\Cartoon.txt\");
            Cinema.LayThongTinDrama(@"C:\\Users\\QuangTrieu's PC\\OneDrive\\Documents\\GitHub\\ProjectOOP\\ProjectOOP\\Drama.txt\");
            Cinema.LayThongTinHorror(@"C:\\Users\\QuangTrieu's PC\\OneDrive\\Documents\\GitHub\\ProjectOOP\\ProjectOOP\\Horror.txt\");
            Cinema.LayHetPhim();
            Cinema.RunSignIn();
            Cinema.RunShowPhim();
        }
    }
}
