using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CsharpOOP.Men;

namespace CsharpOOP
{
    internal class Women : Person
    {
        public Decoration decoration { get; set; }

        public Women(string name, DateTime birthDay, Decoration decoration, Gender gender = Gender.Female) : base(name, birthDay, gender)
        {



        }
        public enum Decoration
        {
            Clock,
            Earrings,
            Ring

        }

        public override void PrintPerson()
        {
            Console.WriteLine($"Имя: {Name}, ДР:{BirthDay}, Украшение:{decoration}, Пол:{Gender}");
        }

    }
}
