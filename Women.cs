using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP
{
    internal class Women : Person
    {
        public Women(string name, DateTime birthDay, Decoration decoration, Gender gender = Gender.Female) : base(name, birthDay, gender)
        {



        }
        public enum Decoration
        {
            Clock,
            Earrings,
            Ring

        }

    }
}
