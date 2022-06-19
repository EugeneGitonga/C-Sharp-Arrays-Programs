using System;

class ArrayHighestTwo
{
   public static void Main(string[] args)
   {
      double sum = 0, avg, highest, lowest;
      int i, total_number;

      Console.Write("\nHow many students are you working with? ");
      total_number = Convert.ToInt32(Console.ReadLine());

      double[] marks = new double[total_number];

      for(i = 0;i < total_number;i++)
      {
         Console.Write("Enter marks for student {0}:> ", i + 1);
         marks[i] = Convert.ToInt32(Console.ReadLine());
      }

      highest = lowest = marks[0];

      for(i = 0;i < total_number;i++)
      {
         sum = sum + marks[i];
         if(marks[i] > highest)
            highest = marks[i];
         else if(marks[i] < lowest)
            lowest = marks[i];
      }
      avg = sum / total_number;

      Console.WriteLine("\nThe total is " + sum);
      Console.WriteLine("The average is " + avg);
      Console.WriteLine("The highest mark is " + highest);
      Console.WriteLine("The lowest mark is " + lowest);
   }
}