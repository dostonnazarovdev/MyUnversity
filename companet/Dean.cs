using System.Reflection.Metadata.Ecma335;

public class Dean
{
    private int id;
    private string name;
    private string surname;
    private int age;
    private string birthDate;
    private string faculty;
    private double salary;

  


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
    public string Surname
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
    public string BirthDate
    {
        get
        {
            return birthDate;
        }
        set
        {
            birthDate = value;
        }
    }
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
    public double Salary
    {
        get
        {
            return salary;
        }
        set
        {
            salary = value;
        }
    }
    public DateTime CreatedDate { get; set; }

  
}