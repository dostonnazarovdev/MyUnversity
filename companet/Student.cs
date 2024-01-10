using MyUnversity;

public class Student
{
   
    public int id;
    public string name;
    public string surname;
    public int age;
    public DateTime birthDate;
    public int level;
    public Subject subjectId;






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
    public string SurName
    {
        get
        {
            return surname;
        }
        set
        {
            surname = value;
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }
    public int Level
    {
        get
        {
             return level;
        }
        set
        {
            if(level>0 && level<6){
                level=value;
            }
        }
    }
    public Subject SubjectId
    {
        get
        {
            return subjectId;
        }
        set
        {
            subjectId = value;
        }
    }




  
}