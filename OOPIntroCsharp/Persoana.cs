namespace OOPIntroCsharp
{
    public class Persoana:IHasExport
    {
        protected int yearOfBirth;
        protected string name;
        public Persoana()
        {
            yearOfBirth = 2000;
            name = "Default Person";
        }

        public Persoana(int yearOfBirth, string name)
        {
            this.yearOfBirth = yearOfBirth;
            this.name = name;
        }

        public virtual void ConsoleWrite()
        {
            System.Console.WriteLine(name + " - " + yearOfBirth);
        }

        public void Export() { }
    }
}