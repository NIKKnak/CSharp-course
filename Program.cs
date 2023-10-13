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


            Person son1 = new Person("Maxim", DateTime.Parse("01.01.2000"), Gender.Mail);;
            Person son2 = new Person("Maxim", DateTime.Parse("01.01.2005"), Gender.Mail);;
           


            men.AddFamilyInfo(women, men,grandMother,grandFather,son1,son2);
            men.PrintFamelyInfo();
            



        }
    }
}