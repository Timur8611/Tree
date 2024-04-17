using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class Person
    {
        public Person() { }
        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, int age)

        {
            Name = name;
            Age = age;
        }
        private string Name { get; }
        private int Age { get; }
        public Person MAM { get; private set; }
        public Person PAP { get; private set; }
        public Person WifeOrHusbent { get; private set; } = null;
        public Person[] Children { get; private set; }
        public void FamilyInfo(Person mother, Person father, Person wifeorhusbant, params Person[]children)
        {
            MAM = mother;
            PAP = father;
            WifeOrHusbent = wifeorhusbant;
            Children = children;

        }
        public static void PrintME(Person person)
        {
            Console.Write($"Name : {person.Name}");    
        }
       
       
        public bool IsChildFree(Person person)
        {
            bool isChildfree = false;
            if (person.Children.Length <= 0)
            {
                isChildfree = true;
                return isChildfree;

            }
            else {return isChildfree;}


        }
    }
}
