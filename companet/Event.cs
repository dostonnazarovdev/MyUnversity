public class Event
{
     private int id;
     private string name;
     private int professorId;
     private Professor professor;
     private DateTime createDate;



     public int Id
     {
          get
          {
               return id;
          }

          set
          {
               id = value;
          }
     }
     public string Name
     {
          get
          {
               return name;
          }

          set
          {
               name = value;
          }
     }
     public int ProfessorId
     {
          get
          {
               return professorId;
          }

          set
          {
               professorId = value;
          }
     }
     public Professor Professor
     {
          get
          {
               return professor;
          }
          set
          {
               professor = value;
          }
     }
     public DateTime CreateDate
     {
          get
          {
               return createDate;
          }
          set
          {
               createDate = value;
          }
     }
}