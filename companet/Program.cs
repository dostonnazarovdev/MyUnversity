namespace MyUnversity
{
    public class Program
    {
        static void Main(string[] args)
        {
            UnveristyManger unveristyManger = new UnveristyManger();



            Subject javaSub = unveristyManger.createSubject("java",5);
            Subject engSub = unveristyManger.createSubject("english", 4);
            Subject hisSub = unveristyManger.createSubject("History", 2);
            Subject ielSub = unveristyManger.createSubject("IELTS", 4);

            Subject tempSub = unveristyManger.getSubjectId(1);
            //Console.WriteLine(tempSub.Name);

            Subject tempSubject = unveristyManger.getSubjectByName("english");
            //Console.WriteLine(tempSubject.Name);

            Dean tempDean = unveristyManger.createDean("Aziz", "Azizov", 25, "2022.12.12", "Matimatika", 2200000);
            Dean tempDean1 = unveristyManger.createDean("Abror", "Baxmalov", 23, "2024.11.12", "English", 23400000);
            //Console.WriteLine(tempDean.Name + ", " + tempDean.Surname + ", " + tempDean.Age + ", " + tempDean.BirthDate + ", " + tempDean.Faculty + ", " + tempDean.Salary);

            Dean tempDean3 = unveristyManger.getDeanById(1);
          //  Console.WriteLine(tempDean3.Name + ", " + tempDean3.Surname + ", " + tempDean3.Age + ", " + tempDean3.BirthDate + ", " + tempDean3.Faculty + ", " + tempDean3.Salary);
           System.Console.WriteLine(tempDean3.Name);

          Console.WriteLine( unveristyManger.getDeanByFaculty("English"));



        }


    }
}