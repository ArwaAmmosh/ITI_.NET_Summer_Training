using System;
namespace class1;
public class Class
{
    static void swap(int[]arr,int index1,int index2){
        int temp =arr[index1];
        arr[index1]=arr[index2];
        arr[index2]=temp;
    }
static void Main(string[] args){
    int index1,index2;
    Console.WriteLine("Enter the length of the array :");
     int length= int.Parse(Console.ReadLine());
     int [] array=new int[length];
     for(int i=0;i<length;i++){
        Console.Write($"the {i+1} element:");
        array[i]=int.Parse(Console.ReadLine());
     }
     Console.WriteLine("------------------------------------\nSwaping Values :\n");
     do{
     Console.WriteLine("Enter the first index : ");
      index1=int.Parse(Console.ReadLine());
     }while(index1<0&&index1>=length);
    do{Console.WriteLine("Enter the second  index : ");
      index2=int.Parse(Console.ReadLine());}
     while(index2<0&&index2>=length && index2!=index1);
     swap(array,index1,index2);
     Console.WriteLine("------------------------------------\n Array after Swaping :\n");
       for(int i=0;i<length;i++){
        Console.WriteLine($"the {i+1} element: {array[i]}");
        
     }
     
     
}


}