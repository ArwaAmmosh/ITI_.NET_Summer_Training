using System;
namespace class1;
public class Class1
{
    #region Print Function
    static void PrintArray(int[] array)
	{
        for (int i=0;i<array.Length;i++)
        {
           Console.WriteLine($"the {i+1} element : {array[i]}");
        }
	}
    #endregion
    static void Main(string[] args)
	{
        #region Read Array And print it
        int[] array =new int[10];
        for (int i=0;i<10;i++)
        {   Console.Write("enter value :  ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        PrintArray(array);
        #endregion
        #region max min values
        int min  =array[0];
           int max  =array[0];
        for(int i = 1; i < 10; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
            if (max < array[i]) {

                max = array[i];
            }
        }
        Console.WriteLine($"The maximum value : {max} \n the minimum value : {min}");
        #endregion
        #region sort array
            for (int i=0;i<10;i++) { 
                for(int j=9;j>i;j--) {
                if (array[j] < array[j - 1])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                }
                }
                }
         PrintArray(array);
        #endregion
        #region search for value
        int[] arra ={-1 , 33 ,11 , 1 , 2 , 33 , -5 , 7 , 8 , 9};
        int search = 2;
        int indexvalue=0;
        for (int i = 0; i < 10; i++)
        {
            if (arra[i]==search)
            {
                indexvalue= i;
                break;
            }
        }
        Console.WriteLine($"the index of value {search} :{indexvalue}");
        #endregion
        #region checked & unchecked & try catch
        int k = int.MaxValue;
        try
        {
            k++;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        #endregion
    }

}
