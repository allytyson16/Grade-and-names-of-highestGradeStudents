using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

					
public class Program
{
	public static void Main()
	{
      
            /*
        * 
        *  Write a program that allows a teacher to enter in an amount of students. For each
        *  student ask the teacher to enter in their name and final score for the class. When
        *  the teacher is done entering the data, print the highest grade in the class, and the average grade
        *  for the class.
        * 
        * */

            Console.Write("Enter number of students in class - ");
            int amountOfStudents = int.Parse(Console.ReadLine());

            double highestGrade = 0;
            double averageGrade = 0;
            string highestGradesName = "";

            string[] studentNames = new string[amountOfStudents];
            double[] grades = new double[amountOfStudents];

            for(int i = 0; i < amountOfStudents; i++)
            {
                Console.Write("Enter student #{0} name - ", i + 1);
                string name = Console.ReadLine();
                studentNames[i] = name;

                Console.Write("Enter student #{0} grade - ", i + 1);
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
                averageGrade += grade;

                if(grade > highestGrade)
                {
                    highestGrade = grade;
                    highestGradesName = name;
                }
            }

            averageGrade /= amountOfStudents;
            Console.WriteLine("The average grade of the class is {0}.", averageGrade);
            Console.WriteLine("The highest grade of the class is {0}, and their name was {1}", highestGrade, highestGradesName);
    }
}
	
