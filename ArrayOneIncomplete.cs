using System;

class ArrayOneIncomplete
{
   public static void Main(string[] args)
   {
      int[] num = new int[10];
      double sum, avg;
      int i;

      for(i = 0;i < 10;i++)
      {
         Console.Write("Enter number {0}:> ", i + 1);
         num[i] = Convert.ToInt32(Console.ReadLine());
      }
      //The code below is to be be modified.
      sum = num[0] + num[1] + num[2] + num[3] + num[4] + num[5] + num[6]+ num[7] + num[8] + num[9];
      avg = sum / 10;

      Console.WriteLine("\nThe average is " + avg);
   }
}