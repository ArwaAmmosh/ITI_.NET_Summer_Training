using System;
namespace class1;
public class person
{  
protected int id;
protected string fname;
protected string  lname;
protected string address;
protected int  age;

public int Id{
    set {
        id=value;
    }
    get{
        return id;
    }
}
 public int Age{
    set {
        age=value;
    }
    get{
        return age;
    }
} 
public string Lname{
    set{
        lname=value;
    }
    get {
        return lname;
    }
}
public string Fname{
    set{
        fname=value;
    }
    get {
        return fname;
    }
}
public string Address{
    set{
        address=value;
    }
    get {
        return address;
    }
}
public person(int _id,string _fname,string _lname,string _address,int _age)
{
    Id=_id;
    Lname=_lname;
    Fname=_fname;
    Address=_address;
    Age=_age;
}
public string print(){
return $"id : {Id} Fname : {Fname} Lname : {Lname} Address : {address} Age : {Age}";
}

}