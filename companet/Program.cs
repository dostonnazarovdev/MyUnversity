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


            Code code = new Code();
            code.Name="code";
            System.Console.WriteLine(code.Name);

        }


    }
}