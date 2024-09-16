using System;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //string black = "◼︎";
            //string white = "◻︎";
            string black = "X";
            string white = "O";


            int rows = 0;
            int columns = 0;

            //Get board size from user
            GetUserInput("How many columns?", ref columns);
            GetUserInput("How many rows?", ref rows);

            // Loop through the size values and print the board.
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((i + j) % 2 == 0)
                        PrintToConsole(black);
                    else
                        PrintToConsole(white);
                }
                Console.WriteLine();
            }
        }

        //While loop to make sure the user input is valid.
        static void GetUserInput(string userPrompt, ref int value)
        {
            while (true)
            {
                Console.WriteLine(userPrompt);
                if (int.TryParse(Console.ReadLine(), out value) && value > 0)
                    break;
                else
                    Console.WriteLine("Invalid Input, please pick a positive number");
            }
        }
        //Seperated the console log into its own function.
        static void PrintToConsole(string value)
        {
            Console.Write(value);
        }
    }
}
