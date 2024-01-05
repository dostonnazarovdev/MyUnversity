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





      DateTime deanCreateDate = unveristyManger.getDeanEmployeedDateById(tempDean.Id);
      // System.Console.WriteLine(deanCreateDate);

      Dean dean = unveristyManger.getDeanByFaculty("English");
      //System.Console.WriteLine(dean.Name+", "+dean.Surname);

      Security securityTemp = unveristyManger.createSecurity("doston", "nazarov", 28, "2022.22.12", 5000000, "Mayor");
      Security securityTemp1 = unveristyManger.createSecurity("ali", "aliyev", 28, "2022.22.12", 5000000, "Mayor");
      Security securityTemp2 = unveristyManger.createSecurity("abror", "baxmalov", 28, "2022.22.12", 5000000, "Palkovnlik");

      //System.Console.WriteLine(securityTemp.Name+" "+ securityTemp.Surname+" "+securityTemp.Age+" "+securityTemp.BirthDate+" "+securityTemp.Salary+" "+securityTemp.MilitaryRank);

      Security[] securities = unveristyManger.getSecurityListByMilitaryRank("Mayor");
      //   foreach (var item in securities)
      //   {
      //    System.Console.WriteLine(item.Name + ", "+item.Age); 
      //   }

      // Professor professor = unveristyManger.createProfessor("Jamol","Jamolov",13,"2022.12.12",1230000,2);
      //Console.WriteLine(professor.Name + ", " + professor.Surname + ", " + professor.Age + ", " + professor.BirthDate + ", " + professor.Salary);

      Student student1 = unveristyManger.createStudent("ali", "aliyev", 19, DateTime.Now, 1);
      Student student2 = unveristyManger.createStudent("vali", "valiyev", 20, DateTime.Now, 2);
      Student student3 = unveristyManger.createStudent("eshmat", "eshmatov", 33, DateTime.Now, 3);

      // System.Console.WriteLine(student1.id + ", " + student1.name + ", " + student1.surname + ", " + student1.age + ", " + student1.birthDate + ", " + student1.level);
      // System.Console.WriteLine(student2.id + ", " + student2.name + ", " + student2.surname + ", " + student2.age + ", " + student2.birthDate + ", " + student2.level);
      // System.Console.WriteLine(Environment.NewLine);


      var studentOfSubject = unveristyManger.addSubjectToStudent(12, 1);
      var studentOfSubject1 = unveristyManger.addSubjectToStudent(11, 1);
      var studentOfSubject2 = unveristyManger.addSubjectToStudent(13, 1);
      //System.Console.WriteLine(studentOfSubject.id + ", " + studentOfSubject.name + ", " + studentOfSubject.surname + ", " + studentOfSubject.age + ", " + studentOfSubject.birthDate + ", " + studentOfSubject.level);

      Student[] students = unveristyManger.getStudentListByLevel(3);
      // for (int i = 0; i < students.Length; i++)
      // {
      //   System.Console.WriteLine(students[i].Name + ", " + students[i].SurName + ", " + students[i].Level);
      // }

      System.Console.WriteLine(Environment.NewLine);
      var studentArr = unveristyManger.getStudentListBySubjectId(1);
      foreach (var item in studentArr)
      {
        System.Console.WriteLine(item.id + ", " + item.name + ", " + item.surname+", level => "+item.level);
      }

    }


  }
}