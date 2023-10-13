using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsharpOOP
{

    internal class Person
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }
        public Person Mother { get; set; }
        public Person Father { get; set; }
        public Person GrandMother { get; set; }
        public Person GrandFather { get; set; }

        public Person[] Children { get; set; }





        public Person(string name, DateTime birthDay, Gender gender)
        {

            this.Name = name;
            this.BirthDay = birthDay;
            this.Gender = gender;


        }
        public virtual void PrintPerson()
        {
            Console.WriteLine($"Имя: {Name}, ДР:{BirthDay}, Пол:{Gender}");
        }

        public virtual void AddFamilyInfo(Person mother, Person father, Person grandMother, Person grandFather, params Person[] children)
        {
            this.Mother = mother;
            this.Father = father;
            this.GrandMother = grandMother;
            this.GrandFather = grandFather;
            this.Children = children;
        }

        public void PrintFamelyInfo()
        {
            PrintSimbol();
            Console.WriteLine();
            if (Father != null)
            {
                Console.WriteLine("Father");
                Father.PrintPerson();
            }

            PrintSimbol();
            Console.WriteLine();
            if (Mother != null)
            {
                Console.WriteLine("Mother");
                Mother.PrintPerson();
            }

            PrintSimbol();
            Console.WriteLine();
            if (GrandFather != null)
            {
                Console.WriteLine("GrandFather");
                GrandFather.PrintPerson();
            }

            PrintSimbol();
            Console.WriteLine();
            if (GrandMother != null)
            {
                Console.WriteLine("GrandMother");
                GrandMother.PrintPerson();
            }

            PrintSimbol();
            Console.WriteLine();
            if (Children != null && Children.Length > 0)
            {
                if (this.BirthDay.Year >= 18)
                {
                    Console.WriteLine("Adult сhild");
                    foreach (var child in Children)
                    {

                        child.PrintPerson();
                    }

                }
                else
                {
                    Console.WriteLine("Minor child");
                    foreach (var child in Children)
                    {

                        child.PrintPerson();
                    }
                }
            }

           


        }

        public void PrintSimbol()
        {
            for (int i = 0; i < 70; i++)
            {
                Console.Write("-");
            }
            Console.Write("|");
        }






    }

    public enum Gender
    {
        Mail,
        Female
    }





}
