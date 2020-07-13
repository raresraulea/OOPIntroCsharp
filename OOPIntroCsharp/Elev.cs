namespace OOPIntroCsharp
{
    public class Elev:Persoana
    {
        private string scoala;
        private double mediaAnilor;

        public Elev() : base(2020, "Elev Default")
        {
            this.scoala = "Scoala default";
            this.mediaAnilor = 5;
        }

        public Elev(string scoala, double mediaAnilor):base(2020, "Elev SemiCustom")
        {
            this.scoala = scoala;
            this.mediaAnilor = mediaAnilor;
        }
        public Elev(string name, int yearOfBirth, string scoala, double mediaAnilor) : base(yearOfBirth, name)
        {
            this.scoala = scoala;
            this.mediaAnilor = mediaAnilor;
        }

        public override void ConsoleWrite()
        {
            System.Console.WriteLine(name + " - " + scoala + " - " + mediaAnilor);
        }
    }
}