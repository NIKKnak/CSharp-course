using System.Net.Sockets;

namespace CsharpOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Men men = new Men("Nik",DateTime.Parse("01.01.2000"),Men.HairStile.Black);
            GrandFather grandFather = new GrandFather("Alex",DateTime.Parse("01.01.1990"),GrandFather.Beard.Short);
            Women women = new Women("Julia", DateTime.Parse("02.06.2000"),Women.Decoration.Clock);
            GrandMother grandMother = new GrandMother("Mari", DateTime.Parse("12.12.1991"),GrandMother.Glasses.Bleck);


            Men son1 = new Men("Nik", DateTime.Parse("01.01.2000"), Men.HairStile.Black);
            Men son2 = new Men("Nik", DateTime.Parse("01.01.2000"), Men.HairStile.Black);

            



            men.AddFamilyInfo(women, men,grandMother,grandFather,son1,son2);
            //men.PrintFamelyInfo();

            for (int i = 0; i < men.Count; i++)
            {
                men[i].PrintPerson();
            }



        }
    }
}