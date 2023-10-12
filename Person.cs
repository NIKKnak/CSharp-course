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
        public Person[] Children { get; set; }


       

        public Person(string name, DateTime birthDay, Gender gender)
        { 
        
            this.Name = name;
            this.BirthDay = birthDay;
            this.Gender = gender;

        
        }
        public void PrintPerson()
        {
            Console.WriteLine($"Имя: {Name}, ДР:{BirthDay}, Пол:{Gender}");
        }

        public void AddFamilyInfo(Person mother, Person father, params Person[] children)
        {
            this.Mother = mother;
            this.Father = father;
            this.Children = children;
        }

        public void PrintFamelyInfo()
        {
            if (Father != null)
            {
                Console.WriteLine("Father");
                Father.PrintPerson();
            }
            
            if (Mother != null)
            {
                Console.WriteLine("Mother");
                Mother.PrintPerson();
            }
            if (Children != null && Children.Length>0)
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

    }

    public enum Gender
    {
        Mail,
        Female
    }

   



}
