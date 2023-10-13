using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CsharpOOP.GrandFather;
using static CsharpOOP.GrandMother;

namespace CsharpOOP
{
    internal class GrandFather : Person
    {

        public Beard beard {  get; set; }
        public GrandFather(string name, DateTime birthDay, Beard beard, Gender gender = Gender.Female) : base(name, birthDay, gender)
        {



        }
        public enum Beard
        {
            Long,
            Short
        }



        public override void PrintPerson()
        {
            Console.WriteLine($"Имя: {Name}, ДР:{BirthDay}, Борода:{beard}, Пол:{Gender}");
        }




    }
}
