using System;

namespace cse210_01
{
    class Program
    {
        // Tic-Tac-Toe by Lucy Eldredge
        static void PrintBoard(string one, string two, string three, string four, string five, string six, string seven, string eight, string nine)
        {
            Console.WriteLine($"{one}|{two}|{three}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{four}|{five}|{six}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{seven}|{eight}|{nine}");
        }

        static string CheckIfWon(string one, string two, string three, string four, string five, string six, string seven, string eight, string nine, int i)
        {
            if ((one == "x" && two == "x" && three == "x") || (four == "x" && five == "x" && six == "x") || (seven == "x" && eight == "x" && nine == "x") || (one == "x" && four == "x" && seven == "x") || (two == "x" && five == "x" && eight == "x") || (three == "x" && six == "x" && nine == "x") || (one == "x" && five == "x" && nine == "x") || (three == "x" && five == "x" && seven == "x"))
            {
                return "x";
            }
            else if ((one == "o" && two == "o" && three == "o") || (four == "o" && five == "o" && six == "o") || (seven == "o" && eight == "o" && nine == "o") || (one == "o" && four == "o" && seven == "o") || (two == "o" && five == "o" && eight == "o") || (three == "o" && six == "o" && nine == "o") || (one == "o" && five == "o" && nine == "o") || (three == "o" && five == "o" && seven == "o"))
            {
                return "o";
            }
            else if (i == 10)
            {
                return "tie";
            }
            else
            {
                return "false";
            }
        }

        static void Main(string[] args)
        {
            string one = "1";
            string two = "2";
            string three = "3";
            string four = "4";
            string five = "5";
            string six = "6";
            string seven = "7";
            string eight = "8";
            string nine = "9";

            string winCheck = "false";
            bool answerCheck = true;
            int i = 2;

            while (winCheck == "false")
            {
                PrintBoard(one, two, three, four, five, six, seven, eight, nine);
                if (i % 2 == 0)
                {
                    while (answerCheck == true)
                    {
                        Console.Write("x's turn to choose a square (1-9): ");
                        string answer = Console.ReadLine();
                        answerCheck = false;

                        if (answer == "1" && one != "o")
                            {one = "x";}
                        else if (answer == "2" && two != "o")
                            {two = "x";}
                        else if (answer == "3" && three != "o")
                            {three = "x";}
                        else if (answer == "4" && four != "o")
                            {four = "x";}
                        else if (answer == "5" && five != "o")
                            {five = "x";}
                        else if (answer == "6" && six != "o")
                            {six = "x";}
                        else if (answer == "7" && seven != "o")
                            {seven = "x";}
                        else if (answer == "8" && eight != "o")
                            {eight = "x";}
                        else if (answer == "9" && nine != "o")
                            {nine = "x";}
                        else
                            {Console.WriteLine("Invalid input");
                            answerCheck = true;}
                    }
                }
                else
                {
                    while (answerCheck == true)
                    {
                        Console.Write("o's turn to choose a square (1-9): ");
                        string answer = Console.ReadLine();
                        answerCheck = false;

                        if (answer == "1" && one != "x")
                            {one = "o";}
                        else if (answer == "2" && two != "x")
                            {two = "o";}
                        else if (answer == "3" && three != "x")
                            {three = "o";}
                        else if (answer == "4" && four != "x")
                            {four = "o";}
                        else if (answer == "5" && five != "x")
                            {five = "o";}
                        else if (answer == "6" && six != "x")
                            {six = "o";}
                        else if (answer == "7" && seven != "x")
                            {seven = "o";}
                        else if (answer == "8" && eight != "x")
                            {eight = "o";}
                        else if (answer == "9" && nine != "x")
                            {nine = "o";}
                        else
                            {Console.WriteLine("Invalid input");
                            answerCheck = true;}
                    }
                }
                i++;
                answerCheck = true;
                winCheck = CheckIfWon(one, two, three, four, five, six, seven, eight, nine, i);
            }
            PrintBoard(one, two, three, four, five, six, seven, eight, nine);
            if (winCheck == "x")
            {
                Console.WriteLine("Congratulations! X has won! Thanks for playing :D");
            }
            else if (winCheck == "o")
            {
                Console.WriteLine("Congratulations! O has won! Thanks for playing :D");
            }
            else if (winCheck == "tie")
            {
                Console.WriteLine("It's a tie! Try again");
            }
        }
    }
}
