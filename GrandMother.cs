using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CsharpOOP.GrandMother;
using static CsharpOOP.Men;

namespace CsharpOOP
{
    internal class GrandMother : Person
    {
        public Glasses glasses {  get; set; }
        public GrandMother(string name, DateTime birthDay, Glasses glasses, Gender gender = Gender.Female) : base(name, birthDay, gender)
        {



        }
        public enum Glasses
        {
            Bleck,
            Clear


        }

        public override void PrintPerson()
        {
            Console.WriteLine($"Имя: {Name}, ДР:{BirthDay}, Очки:{glasses}, Пол:{Gender}");
        }

       


    }
}
