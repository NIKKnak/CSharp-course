using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsharpOOP
{

    public abstract class Person : IFamily
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }
        public Person Mother { get; set; }
        public Person Father { get; set; }
        public Person GrandMother { get; set; }
        public Person GrandFather { get; set; }

        public Person[] Children { get; set; }

        // Индексаторы
        public Person[] Famely;
        public int Count => 1 + (Famely?.Length ?? 0);

        public Person this[int index]
        {
            get
            {
                if (index == 0) return this;
                if (Famely is null) return null;
                if (Famely.Length >= index) return Famely[index - 1];
                return null;
            }
        }






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

            int famelyCount = 0;

            famelyCount += Father == null ? 0 : 1;
            famelyCount += Mother == null ? 0 : 1;
            famelyCount += Children.Length;

            if (famelyCount > 0)
            {
                Famely = new Person[famelyCount];
            }
            else return;

            int counter = 0;


            if (Father != null)
            {
                Famely[counter] = Father;
                counter++;
            }
            if (Mother != null)
            {
                Famely[counter] = Mother;
                counter++;
            }
            foreach (var child in Children)
            {
                Famely[counter] = child;
                counter++;

            }


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

        /*
        public int CompareTo(object? obj)
        {
            if (obj == null)
                return -1;
            return this.BirthDay.CompareTo(obj as Person).BirthDay);
        }*/
    }

    public enum Gender
    {
        Mail,
        Female
    }





}
