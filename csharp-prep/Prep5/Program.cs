using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PronptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);


        static void DisplayWelcome(){
            Console.WriteLine("Wlcome to hte Program!");
        }

        static String PromptUserName(){
            Console.Write("What is your name?: ");
            String name = Console.ReadLine();
            return name;
        }

        static int PronptUserNumber(){
            int number = 0;
            Console.Write("What is your favorite number?: ");
            number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number){

            int square = number * number;
            return square;
        }

        static void DisplayResult(String name, int square){
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

    }
}