using System;

class ArrayHighest
{
   public static void Main(string[] args)
   {
      double[] marks = new double[10];
      double sum = 0, avg, highest, lowest;
      int i;

      for(i = 0;i < 10;i++)
      {
         Console.Write("Enter marks for student {0}:> ", i + 1);
         marks[i] = Convert.ToInt32(Console.ReadLine());
      }

      highest = lowest = marks[0];

      for(i = 0;i < 10;i++)
      {
         sum = sum + marks[i];
         if(marks[i] > highest)
            highest = marks[i];
         else if(marks[i] < lowest)
            lowest = marks[i];
      }
      avg = sum / 10;

      Console.WriteLine("\nThe total is " + sum);
      Console.WriteLine("The average is " + avg);
      Console.WriteLine("The highest mark is " + highest);
      Console.WriteLine("The lowest mark is " + lowest);
   }
}