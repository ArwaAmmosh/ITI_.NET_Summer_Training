using System;
namespace class1.inhertence;
public class teacher : person
{  
    private int salary;
    private string subject;
    public int Salary{
        set {
            salary=value;
        }
        get{
            return salary;
        }
    }
    public string Subject{
     set{
        subject=value;
     }
     get{
        return subject;
     }
    }
    public teacher (int _id,string _fname,string _lname,string _address,int _age,int _salary,string _subjects):base (_id,_fname,_lname,_address,_age)
    {
        Salary=_salary;
        Subject=_subjects;
    }
    public void printTeacher(){
       Console.WriteLine($"Teacher : {print()} salary : {Salary} Subjects : {Subject}");
    }

}