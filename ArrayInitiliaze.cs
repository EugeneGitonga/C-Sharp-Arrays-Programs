using System;

class ArrayInitiliaze
{
   public static void Main(string[] args)
   {
      int[] numbers = new int[10] {12,15,23,67,45,76,78,65,67,85};
      double sum = 0, avg;
      int i;

      for(i = 0;i < numbers.Length;i++)
      {
         sum = sum + numbers[i];
      }
      avg = sum / numbers.Length;

      Console.WriteLine("The elements in the array are:\n");
      for(i = 0;i < numbers.Length;i++)
         Console.Write("{0} ", numbers[i]);
      
      Console.WriteLine("\n\nTheir average is " + avg);
   }
}