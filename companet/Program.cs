namespace MyUnversity
{
    public class Program
    {
        static void Main(string[] args)
        {
            UnveristyManger unveristyManger = new UnveristyManger();



            Subject javaSub = unveristyManger.createSubject("java", 3);
            Subject engSub = unveristyManger.createSubject("english", 4);
            Subject hisSub = unveristyManger.createSubject("History", 2);
            Subject ielSub = unveristyManger.createSubject("IELTS", 4);

            Subject tempSub = unveristyManger.getSubjectId(1);
            Console.WriteLine(tempSub.Name);

            Subject tempSubject = unveristyManger.getSubjectByName("english");
            Console.WriteLine(tempSubject.Name);

            Dean tempDean = unveristyManger.createDean("Aziz", "Azizov", 25, "2022.12.12", "Matimatika", 2200000);
            Console.WriteLine(tempDean.Name + ", " + tempDean.Surname + ", " + tempDean.Age + ", " + tempDean.BirthDate + ", " + tempDean.Faculty + ", " + tempDean.Salary);




        }


    }
}