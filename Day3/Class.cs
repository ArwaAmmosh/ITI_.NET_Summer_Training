using System;
namespace class1;
public class Class1
{
    struct employee
    {

        int Ssn;
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
            if (_age < 23 || _age > 45) throw new Exception("Age must be between 23 and 24");
            else age = _age;
        }
        public void SetAddress(string _address)
        {
            if (_address != "cairo" && _address != " alex " && _address != "giza") throw new Exception("invalid address");
            else address = _address;
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
            return $"employee SSn: {this.Ssn},\n" +
                    $"employee fname: {this.Fname},\n" +
                   $"employee lname: {this.Lname},\n" +
                   $" age: {this.age},\n" +
                    $" address: {this.address}";
        }
           public void consolePrint()
        {
            Console.WriteLine( $"employee SSn: {this.Ssn},\n employee fname: {this.Fname},\n employee lname: {this.Lname},\n age: {this.age},\n address: {this.address}");
        }
    }
static void Main(string[] args){
    Console.WriteLine("1-one employee \n2-groupe of employee");
    int m= int.Parse(Console.ReadLine());
    if(m==1)
  { employee emp=new employee();
    Console.WriteLine("Enter employee Ssn:");
    emp.SetSsn(int.Parse(Console.ReadLine()));
      Console.WriteLine("Enter employee Fname:");
    emp.SetFName(Console.ReadLine());
      Console.WriteLine("Enter employee Lname:");
    emp.SetLName(Console.ReadLine());
    do{
               try
              {
                  Console.WriteLine("Enter employee age:");
                  emp.SetAge(int.Parse(Console.ReadLine()));
               }
               catch (Exception ex)
              {
                   Console.WriteLine(ex.Message);
               }
            } while (emp.GetAge() < 23 || emp.GetAge() > 45);
do{
               try
              {
                  Console.WriteLine("Enter employee address:");
                  emp.SetAddress(Console.ReadLine());
               }
               catch (Exception ex)
              {
                   Console.WriteLine(ex.Message);
               }
            } while (emp.getaddress()!="cairo" && emp.getaddress() !="giza" && emp.getaddress()!="alx");

emp.consolePrint();}
else if(m==2){
Console.WriteLine("enter the the number of the group :");
int n= int.Parse(Console.ReadLine());
employee[] empa=new employee[n];
for(int i=0;i<n;i++){
        Console.WriteLine("Enter employee Ssn:");
    int Ssn=int.Parse(Console.ReadLine());
      Console.WriteLine("Enter employee Fname:");
    string FName=Console.ReadLine();
      Console.WriteLine("Enter employee Lname:");
   string LName=Console.ReadLine();
   int age =0;
   string address="";
    do{
               try
              {
                  Console.WriteLine("Enter employee age:");
                  age=int.Parse(Console.ReadLine());
               }
               catch (Exception ex)
              {
                   Console.WriteLine(ex.Message);
               }
            } while (age< 23 || age > 45);
do{
               try
              {
                  Console.WriteLine("Enter employee address:");
                  address=Console.ReadLine();
               }
               catch (Exception ex)
              {
                   Console.WriteLine(ex.Message);
               }
            } while (address!="cairo" && address!="giza" && address!="alx");
            empa[i].SetAddress(address);
            empa[i].SetAge(age);
            empa[i].SetLName(LName);
            empa[i].SetSsn(Ssn);
            empa[i].SetFName(FName);


}
for(int i=0;i<n;i++){
    empa[i].consolePrint();
}

}


}}