using System;
using System.Collections.Generic;

namespace OOPIntroCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoana p1 = new Persoana();
            Persoana p2 = new Persoana(2005, "Rares");
            //p1.ConsoleWrite();
            //p2.ConsoleWrite();

            Student s1 = new Student();
            Student s2 = new Student("Toni", 1980, "Inginerie Sibiu");
            //s1.ConsoleWrite();
            //s2.ConsoleWrite();

            Elev e1 = new Elev();
            Elev e2 = new Elev("Elev custom", 2015, "Brukenthal", 9.8);
            Elev e3 = new Elev("Goga", 9.5);
            //e1.ConsoleWrite();
            //e2.ConsoleWrite();
            //e3.ConsoleWrite();

            List<IHasExport> myList = new List<IHasExport>();
            myList.Add(p1);
            myList.Add(p2);
            myList.Add(s1);
            myList.Add(s2);
            myList.Add(e1);
            myList.Add(e2);
            myList.Add(e3);

            foreach (IHasExport item in myList)
                item.ConsoleWrite();
        }

    }
}
