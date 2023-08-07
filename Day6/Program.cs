using System;
namespace Day6;
#region Questions
abstract class Questions
{
    private int num ;
    private string body;
    private int mark;
    public int Num
    {
        get { return num;}
        set { num = value; }
    }
    public string Body
    {
        get { return body; }
        set { body = value; }
    }
    public int Mark
    {
        get { return mark;} 
        set { mark = value; }
    }
    public Questions()
    {
        Console.WriteLine("Questions parameterless constructor");
    }
    public Questions(int num, string body,int mark)
    {
        this.Num= num;
        this.Body = body;   
        this.Mark = mark;   
    }
  
    public virtual void show(){ }

}
#endregion
#region MCQ
internal class MCQ : Questions
{
    private string[] answers;
    public string[] Answers { 
        get { return answers; }
        set { answers = value; }
    }
    public MCQ() { }
    public MCQ(int num,string body,int mark,string[] answers):base(num,body,mark) 
    {
        Answers = answers;

    }
    public override void show()
    {
        Console.WriteLine($"{Num}) {Body} ? ({Mark} Mark(s))");
        for (int i=0;i<Answers.Length;i++) {
            Console.WriteLine($"{i+1}) {Answers[i]}");
        }


    }
}
#endregion
#region True,flase
internal class TF:Questions
{
    public TF() { }
    public TF(int num, string body, int mark) : base(num, body, mark){}
    public override void show() { 
        Console.WriteLine($"{Num}) {Body} ? ({Mark})  True Or Flase");
    }
}
#endregion
public class program
{
    static void Main(string[] args)
    {
        MCQ mCQ = new MCQ();
        TF tr = new TF();
        string[] answers = { "2", "5", "4" };
        MCQ mCQ1 = new MCQ(1, "1+3 =", 2, answers) ;
        TF fr= new TF(1, "1+3 = 5", 2);
        mCQ1.show();
        fr.show();
    }
}