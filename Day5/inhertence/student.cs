using System;
namespace class1.inhertence;
public class student : person
{  
    private int schoolyear;
    private string classn;
    public int Schoolyear{
        set {
            schoolyear=value;
        }
        get{
            return schoolyear;
        }
    }
    public string Classsn{
     set{
        classn=value;
     }
     get{
        return classn;
     }
    }
    public student (int _id,string _fname,string _lname,string _address,int _age,int _schoolyear,string _Classn):base (_id,_fname,_lname,_address,_age)
    {
        Schoolyear=_schoolyear;
        Classsn=_Classn;
    }
    public void printstudent(){
       Console.WriteLine($"Student : {print()} SchoolYear : {Schoolyear} Class : {Classsn}");
    }

}