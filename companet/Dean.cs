using System.Reflection.Metadata.Ecma335;

public class Dean : Person
{
      private string faculty;
     public DateTime CreatedDate { get; set; }
     public string Faculty
    {
        get
        {
            return faculty;
        }
        set
        {
            faculty = value;
        }
    }
  
}