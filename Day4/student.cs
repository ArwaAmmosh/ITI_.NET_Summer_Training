using System;
namespace class1;
public class student
{       int Ssn;
        string Fname;
        string Lname;
        int age;
        string address;
        public void SetSsn(int _Ssn)
        {
            Ssn = _Ssn;
        }
        public void SetFName(string _fname)
        {
            Fname = _fname;
        }
        public void SetLName(string _name)
        {
            Lname = _name;
        }
        public void SetAge(int _age)
        {
          age = _age;
        }
        public void SetAddress(string _address)
        {
             address = _address;
        }
         public string GetFName()
        {
            return Fname;
        }
         public string GetLName()
        {
            return Lname;
        }
        public int GetAge() 
              { 
                return age; }  
        public string getaddress(){
            return address;
        }
        public int getSsn(){
            return Ssn;

        }
        public string Print()
        {
            return $"student SSn: {this.Ssn},\n" +
                    $"student fname: {this.Fname},\n" +
                   $"student lname: {this.Lname},\n" +
                   $" age: {this.age},\n" +
                    $" address: {this.address}";
        }
           public void consolePrint()
        {
            Console.WriteLine( $"student SSn: {this.Ssn},\n student fname: {this.Fname},\n student lname: {this.Lname},\n age: {this.age},\n address: {this.address}");
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
    stud.SetSsn(int.Parse(Console.ReadLine()));
      Console.WriteLine("Enter student Fname:");
    stud.SetFName(Console.ReadLine());
      Console.WriteLine("Enter student Lname:");
    stud.SetLName(Console.ReadLine());

                  Console.WriteLine("Enter student age:");
                  stud.SetAge(int.Parse(Console.ReadLine()));
             
  
                  Console.WriteLine("Enter student address:");
                  stud.SetAddress(Console.ReadLine());
               

stud.consolePrint();}
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
            studa[i].SetAddress(address);
            studa[i].SetAge(age);
            studa[i].SetLName(LName);
            studa[i].SetSsn(Ssn);
            studa[i].SetFName(FName);


}
for(int i=0;i<n;i++){
    studa[i].consolePrint();
}
}}}