using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person("Timur", 29);
            Person mother = new Person("Asiya", 50);
            Person father = new Person("Meruj", 55);
            Person wife = new Person("Tata", 37);
            Person child = new Person("Alise", 12);
            Person grandmamM = new Person("Alevtina", 71);
            Person grandpapM = new Person("Jemil", 72);
            Person grandpapP = new Person("Aramais", 92);
            Person grandmamP = new Person("Gulnara", 92);
            Person wifeMom = new Person("Karina", 70);
            Person wifeFather = new Person("Garik", 71);

            me.FamilyInfo(mother, father, wife, child);
            mother.FamilyInfo(grandmamM, grandpapM, father, me);
            father.FamilyInfo(grandmamP, grandpapP, mother, me);
            child.FamilyInfo(wife, me, null);
            wife.FamilyInfo(wifeMom, wifeFather, child);

            Person.PrintME(grandmamP);
            Person.PrintME(grandpapP);
            Console.Write("\t");
            Person.PrintME(grandmamM);
            Person.PrintME(grandpapM);
            Console.WriteLine();
            Person.PrintME(father);
            Person.PrintME(mother);
            Console.WriteLine();
            Person.PrintME(me);
            Person.PrintME(wife);
            Console.WriteLine();
            Person.PrintME(child);  
        }
    }
}
