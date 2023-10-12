using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP
{






    public class FamilyMember
    {
        public FamilyMember Mother { get; set; }
        public FamilyMember Father { get; set; }
        public string Name { get; set; }
        public Gender Sex { get; set; }
        public FamilyMember[] Children { get; set; }

    }


    /*public enum Gender
    {
        Mail,
        Female
    }*/




    public class AbultFamelyMember : FamilyMember
    {
        public FamilyMember[] Children { get; set; }

    }






}
