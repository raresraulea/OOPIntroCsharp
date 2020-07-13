using System;

namespace OOPIntroCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoana p1 = new Persoana();
            Persoana p2 = new Persoana(2005, "Rares");
            p1.ConsoleWrite();
            p2.ConsoleWrite();

            Student s1 = new Student();
            Student s2 = new Student("Toni", 1980, "Inginerie Sibiu");
            s1.ConsoleWrite();
            s2.ConsoleWrite();

            Elev e1 = new Elev();
            Elev e2 = new Elev("Elev custom", 2015, "Brukenthal", 9.8);
            Elev e3 = new Elev("Goga", 9.5);
            e1.ConsoleWrite();
            e2.ConsoleWrite();
            e3.ConsoleWrite();
        }
    }
}
