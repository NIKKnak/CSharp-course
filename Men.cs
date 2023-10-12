using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP
{
    internal class Men : Person
    {

        public Men(string name, DateTime birthDay, HairStile hairStile, Gender gender = Gender.Mail) : base(name, birthDay, gender)
        {
            


        }
        public enum HairStile
        {
            Blonb,
            Black,
            Bald
        }



    }
}
