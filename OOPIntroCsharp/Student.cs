namespace OOPIntroCsharp
{
    public class Student:Persoana
    {
        private string facultate;
        public Student():base(1950, "Default Student")
        {
            this.facultate = "Facultate default";
        }

        public Student(string name, int yearOfBirth, string facultate):base(yearOfBirth,name)
        {
            this.facultate = facultate;
        }
        public override void ConsoleWrite()
        {
            System.Console.WriteLine(name + " - " + yearOfBirth + " - " + facultate);
        }
    }
}