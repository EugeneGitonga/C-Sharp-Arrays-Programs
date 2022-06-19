using System;

class ArrayOneComplete
{
   public static void Main(string[] args)
   {
      int[] num = new int[10];
      double sum = 0, avg;
      int i;

      for(i = 0;i < 10;i++)
      {
         Console.Write("Enter number {0}:> ", i + 1);
         num[i] = Convert.ToInt32(Console.ReadLine());
         sum = sum + num[i];
      }
      
      avg = sum / 10;

      Console.WriteLine("\nThe average is " + avg);
   }
}