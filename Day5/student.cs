/*using System;
namespace class1;
public class student
{     
   private int ssn;
        private string fname;
        private string lname;
       private int age;
       private string address;
       private static int counter =0;
       public student(){
        counter++;
       }
         public static int Counter
        {
            get { return counter; }
        }

     public int Ssn{
      set{
        this.ssn=value;
      }
      get{
        return ssn;
      }
     }
     
     public string FName{
      set{
        this.fname=value;
      }
      get{
        return fname;
      }
     }
     
     public string LName{
      set{
        this.lname=value;
      }
      get{
        return lname;
      }
     }
     
     public int Age{
      set{
        this.age=value;
      }
      get{
        return age;
      }
     }
     
     public string Address{
      set{
        this.address=value;
      }
      get{
        return address;
      }
     }
        public string Print()
        {
            return $"student SSn: {Ssn},\n" +
                    $"student fname: {FName},\n" +
                   $"student lname: {LName},\n" +
                   $" age: {Age},\n" +
                    $" address: {Address}";
        }
           public void consolePrint()
        {
            Console.WriteLine( $"student SSn: {Ssn},\nstudent fname: {FName},\nstudent lname: {LName},\nage: {age},\naddress: {Address}");
        } 
        public void check()
        {
          if (Counter%10==0){
            Console.WriteLine("# 10 student data has been entered ");
          }
        }
    }
public class program{
static void Main(string[] args){
    Console.WriteLine("1-one student \n2-groupe of students");
    int m= int.Parse(Console.ReadLine());
    if(m==1)
  { 
    student stud=new student();
    Console.WriteLine("Enter student Ssn:");
    stud.Ssn=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter student Fname:");
    stud.FName=Console.ReadLine();
      Console.WriteLine("Enter student Lname:");
    stud.LName=Console.ReadLine();

     Console.WriteLine("Enter student age:");
     stud.Age=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter student address:");
      stud.Address=Console.ReadLine();
      stud.consolePrint();
      stud.check();}
else if(m==2){
Console.WriteLine("enter the the number of the group :");
int n= int.Parse(Console.ReadLine());
student[] studa=new student[n];
for(int i=0;i<n;i++){
        Console.WriteLine("Enter student Ssn:");
    int Ssn=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter student Fname:");
    string FName=Console.ReadLine();
      Console.WriteLine("Enter student Lname:");
   string LName=Console.ReadLine();
   int age =0;
   string address="";
  
                  Console.WriteLine("Enter student age:");
                  age=int.Parse(Console.ReadLine());
                  Console.WriteLine("Enter student address:");
                  address=Console.ReadLine();
            studa[i].Address=address;
            studa[i].Age=age;
            studa[i].LName=LName;
            studa[i].Ssn=Ssn;
            studa[i].FName=FName;
 studa[i].check();

}
for(int i=0;i<n;i++){
    studa[i].consolePrint();
}

}

}}*/