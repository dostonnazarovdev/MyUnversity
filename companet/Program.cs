namespace MyUnversity
{
    public class Program
    {
        static void Main(string[] args)
        {
            UnveristyManger unveristyManger = new UnveristyManger();
            unveristyManger.Name = "MIT";
            unveristyManger.Address = "USA";

            Subject javaSub = unveristyManger.createSubject("java", 5);
            Subject engSub = unveristyManger.createSubject("english", 4);
            Subject hisSub = unveristyManger.createSubject("History", 2);
            Subject ielSub = unveristyManger.createSubject("IELTS", 4);

            // Subject tempSub = unveristyManger.getSubjectId(1);
            // Console.WriteLine(tempSub.Name + " , " + tempSub.Semester);

            // Subject tempSubject = unveristyManger.getSubjectByName("english");
            // Console.WriteLine(tempSubject.Name + " , " + tempSubject.Semester);

            Dean tempDean = unveristyManger.createDean("Sobir", "Azizov", 25, "2022.12.12", "Matimatika", 2200000);
            Dean tempDean1 = unveristyManger.createDean("Abror", "Baxmalov", 23, "2024.11.12", "English", 23400000);
            Dean tempDean2 = unveristyManger.createDean("jobir", "Baxmalov", 23, "2024.11.12", "Fizika", 23400000);
            // Console.WriteLine(tempDean.Name + ", " + tempDean.Surname + ", " + tempDean.Age + ", " + tempDean.BirthDate + ", " + tempDean.Faculty + ", " + tempDean.Salary);
            // Console.WriteLine(tempDean1.Name + ", " + tempDean1.Surname + ", " + tempDean1.Age + ", " + tempDean1.BirthDate + ", " + tempDean1.Faculty + ", " + tempDean1.Salary);
            // Console.WriteLine(tempDean2.Name + ", " + tempDean2.Surname + ", " + tempDean2.Age + ", " + tempDean2.BirthDate + ", " + tempDean2.Faculty + ", " + tempDean2.Salary);


            // Dean tempDean3 = unveristyManger.getDeanById(tempDean.Id);
            // Console.WriteLine(tempDean3.Id+", "+ tempDean3.Name + ", " + tempDean3.Surname + ", " + tempDean3.Age + ", " + tempDean3.BirthDate + ", " + tempDean3.Faculty + ", " + tempDean3.Salary + ", " + tempDean3.CreatedDate);



           

         DateTime deanCreateDate =  unveristyManger.getDeanEmployeedDateById(tempDean.Id);
        // System.Console.WriteLine(deanCreateDate);

         Dean dean =  unveristyManger.getDeanByFaculty("English");
         System.Console.WriteLine(dean.Name+", "+dean.Surname);



        }


    }
}