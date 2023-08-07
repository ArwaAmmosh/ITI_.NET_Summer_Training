using System;
namespace Day6;
#region Questions
abstract class Questions
{
    private int num;
    private string body;
    private int mark;
    public int Num
    {
        get { return num; }
        set { num = value; }
    }
    public string Body
    {
        get { return body; }
        set { body = value; }
    }
    public int Mark
    {
        get { return mark; }
        set { mark = value; }
    }
    public Questions()
    {
        Console.WriteLine("Questions parameterless constructor");
    }
    public Questions(int num, string body, int mark)
    {
        this.Num = num;
        this.Body = body;
        this.Mark = mark;
    }

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
    public override string ToString()
    {

        string x = "";
            for (int i=0;i<Answers.Length;i++) {
                      x+=$"{i+1}) {Answers[i]}";
        }
        return $"{Num}) {Body} ? ({Mark} Mark(s)) {x}";



    }
    public override bool Equals(object? obj)
    {
        MCQ t = (MCQ)obj;
        bool x =true;
        for(int i = 0; i < this.Answers.Length; i++)
        {
            if (this.Answers[i] != t.Answers[i])
            {
                x = false;
            }

        }

        return this.Num == t.Num && this.Body == t.Body && this.Mark == t.Mark && x;
    }
}
#endregion
#region True,flase
internal class TF:Questions
{
    public TF() { }
    public TF(int num, string body, int mark) : base(num, body, mark){}
    public override string ToString() { 
        return $"{Num}) {Body} ? ({Mark})  True Or Flase";

    }
    public override bool Equals(object? obj)
    {
        TF t = (TF)obj;
        return this.Num == t.Num && this.Body == t.Body && this.Mark == t.Mark;
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
        MCQ mCQ2 = new MCQ(1, "1+3 =", 2, answers);
        Console.WriteLine(mCQ1.Equals(mCQ2));
        TF fr = new TF(1, "1+3 = 5", 2);
        Console.WriteLine(mCQ1.ToString());
        Console.WriteLine(fr.ToString());
    }
}