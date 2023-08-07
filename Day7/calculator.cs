/*using System;
namespace class2;
public class MyMath{
  static  double add(double num1,double num2){
        return num1+num2;
    }
     static double sub(double num1,double num2){
        return num1-num2;
    }
     static double mul(double num1,double num2){
        return num1*num2;
    }
    static int reminder(int num1,int num2){
        return num1%num2;
    }
      static double div(double num1,double num2){
        return num1/num2;
    }
}
public class Class2
{
    static void Main(string[] args){
    int choice;
    double num1;
    double num2 ,result=0;
    Console.WriteLine(" --> Calculator :\n1-Multiplication\n2-Summtion\n3-Subtraction\n4-Division\n5-Reminder\n Enter your choice :");
    choice=int.Parse(Console.ReadLine());
    Console.WriteLine("------------------------------------------------\n The Numbers:\n\n Enter the first number :");
    num1=double.Parse(Console.ReadLine());
    Console.WriteLine("Enter the second number : ");
    num2=double.Parse(Console.ReadLine());
    Console.WriteLine("------------------------------------------------\n The Result = ");
    switch(choice){
        case 1:
        result=MyMath.mul(num1,num2);
        break;
        case 2:
         result=MyMath.add(num1,num2);
        break;
        case 3:
         result=MyMath.sub(num1,num2);
         break;
        case 4:
         result=MyMath.div(num1,num2);

        break;
         case 5:
         int num11=Convert.ToInt32(num1);
         int num22=Convert.ToInt32(num2);
         result=MyMath.reminder(num11,num22);
        break;
                
    }
    Console.WriteLine(result);

    
}}*/