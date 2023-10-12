namespace CsharpOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Men men = new Men("Nik",DateTime.Parse("01.01.2000"),Men.HairStile.Black);
            Person women = new Person("Julia", DateTime.Now, Gender.Female);
            Person son1 = new Person("Maxim", DateTime.Parse("01.01.2000"), Gender.Mail);;
            Person son2 = new Person("Maxim", DateTime.Parse("01.01.2005"), Gender.Mail);;
            Person son3 = new Person("Maxim", DateTime.Parse("01.01.2010"), Gender.Mail);;


            men.AddFamilyInfo(women, men, son1,son2,son3);
            men.PrintFamelyInfo();




        }
    }
}