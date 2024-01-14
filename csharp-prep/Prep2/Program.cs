using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        String letter = "";
        String sing = "";

        Console.Write("Please, enter your grade here: ");
        string gradeStudent = Console.ReadLine();

        int grade = int.Parse(gradeStudent);

        if (grade >= 90){

            letter = "A";
            
        }

        else if (grade >= 80 && grade < 90){
            letter = "B";
            

        }

        else if (grade >= 70 && grade < 80){
            letter = "C";
            
        }

        else if (grade >= 60 && grade < 70){
            letter = "D";
           
        }

        else if (grade < 60){
            letter = "F";
            
        }
        else {
            Console.WriteLine("Grade not valid");
        }

       

       

        int totalSing = grade % 10;

        if (totalSing >=7){
            sing = "+";
        }
        else {
            sing = "-";
        }

        if (letter == "A" && totalSing >7) {
            sing = " ";
        }
        else if (letter == "F" && totalSing <= 3){
            sing = " ";
        }

         Console.WriteLine($" Your Grade is {letter}{sing}");

         if (grade >= 70){
            Console.WriteLine("Congratulations! you are in.");
        }

        


        
    }
}