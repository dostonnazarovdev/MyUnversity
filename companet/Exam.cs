using MyUnversity;

public class Exam
{
    public int Id { get; set; }
    public int SubjectId { get; set; }
    public int StudentId { get; set; }
    public int Grade { get; set; }
    public Subject Subject { get; set; }
    public Student Student { get; set; }
    public DateTime CreatedDate { get; set; }
}