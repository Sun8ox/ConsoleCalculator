using System;

namespace ConsoleKalkulačka
{
        public class CalculatorV2
        {
                public CalculatorV2()
                {

            //  -----------------------
            // | 5 + 5                 |
            // |-----------------------|
            // |   9   |   8   |   7   |
            // |-----------------------|
            // |   6   |   5   |   4   |
            // |-----------------------|
            // |   3   |   2   |   1   |
            // |-----------------------|
            // |   +   |   0   |   -   |
            // |-----------------------|
            // |   /   |   *   |   =   |
            //  -----------------------
            //
            // Made by Sun8ox in 2024


            string output = "";
            int keyclicked = -1;

            double total = 0.0;

            List<char> characters = new List<char>();

            while (true)
            {
                output = "";
                keyclicked = -1;

                Console.Clear();

                if (Console.KeyAvailable)
                {
                    var readKey = Console.ReadKey();

                    var key = readKey.KeyChar;

                    if(readKey.Key == ConsoleKey.Escape)
                    {
                        characters.Clear();
                        Console.Clear();
                    }

                    if (readKey.Key == ConsoleKey.Backspace)
                    {
                        if(characters.Count > 0)
                        {
                            characters.RemoveAt(characters.Count - 1);
                            Console.Clear();
                            output = "";
                        }
                    }

                    if (key == '9'){
                        keyclicked = 9;
                        characters.Add('9');
                    }
                    else if (key == '8')
                    {
                        keyclicked = 8;
                        characters.Add('8');
                    }
                    else if (key == '7')
                    {
                        keyclicked = 7;
                        characters.Add('7');
                    }
                    else if (key == '6')
                    {
                        keyclicked = 6;
                        characters.Add('6');
                    }
                    else if (key == '5')
                    {
                        keyclicked = 5;
                        characters.Add('5');
                    }
                    else if (key == '4')
                    {
                        keyclicked = 4;
                        characters.Add('4');
                    }
                    else if (key == '3')
                    {
                        keyclicked = 3;
                        characters.Add('3');
                    }
                    else if (key == '2')
                    {
                        keyclicked = 2;
                        characters.Add('2');
                    }
                    else if (key == '1')
                    {
                        keyclicked = 1;
                        characters.Add('1');
                    }
                    else if (key == '0')
                    {
                        keyclicked = 0;
                        characters.Add('0');
                    }
                    else if (key == '+')
                    {
                        keyclicked = 10;
                        characters.Add('+');
                    }
                    else if (key == '-')
                    {
                        keyclicked = 11;
                        characters.Add('-');
                    }
                    else if (key == '*')
                    {
                        keyclicked = 12;
                        characters.Add('*');
                    }
                    else if (key == '/')
                    {
                        keyclicked = 13;
                        characters.Add('/');
                    }
                    else if (key == '=')
                    {
                        keyclicked = 69;
                        characters.Add('=');

                        if(characters.Count > 3)
                        {

                            
                        


                        /*
                                                 string number = "";
                                                 foreach(char charr in characters)
                                                {
                                                    if(charr != '=' && charr != '+' && charr != '-' && charr != '/' && charr != '*')
                                                    {
                                                        number += charr;
                                                    }
                                                    else if (charr == '+')
                                                    {
                                                        total += double.Parse(number);
                                                        number = "";
                                                    }
                                                    else if (charr == '-')
                                                    {
                                                        total -= double.Parse(number);
                                                        number = "";
                                                    }
                                                    else if (charr == '*')
                                                    {
                                                        total *= double.Parse(number);
                                                        number = "";
                                                    }
                                                    else if (charr == '/')
                                                    {
                                                        total /= double.Parse(number);
                                                        number = "";
                                                    }
                                                    else if(charr == '=')
                                                    {

                                                    }

                                                } 
                         */

                        List<double> numbers = new List<double>();
                        List<char> operators = new List<char>();

                        string number = "";

                        foreach(char charr in characters)
                        {
                            if (charr != '=' && charr != '+' && charr != '-' && charr != '/' && charr != '*')
                            {
                                number += charr;
                            } else
                            {
                                    if(number != "")
                                    {

                                        numbers.Add(double.Parse(number));

                                        number = "";

                                        if(charr != '=')
                                        {
                                            operators.Add(charr);
                                        }
                                    } else
                                    {
                                        output = "Error!";
                                        characters.RemoveAt(characters.Count - 1);
                                    }
                                }
                        }

                        // Code from first calculator

                        int useOperator = 0;

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            double numberr = numbers[i];

                            if (i == 0)
                            {
                                total = numbers[i];
                            }
                            else
                            {
                                if (useOperator >= operators.Count)
                                {
                                    break;
                                }

                                var operatorr = operators[useOperator];

                                if (operatorr == '+')
                                {
                                    total += numberr;
                                }
                                else if (operatorr == '-')
                                {
                                    total -= numberr;
                                }
                                else if (operatorr == '*')
                                {
                                    total *= numberr;
                                }
                                else if (operatorr == '/')
                                {
                                    total /= numberr;
                                }
                                useOperator++;
                            }
                        }

                        // end


                        characters.Clear();
                        characters = total.ToString().ToCharArray().ToList();
                        output = "";


                        output = total.ToString();

                        } else
                        {
                            output = "Error!";
                            characters.RemoveAt(characters.Count - 1);
                        }
                    }

                }
                foreach(char charr in characters)
                {
                    output += charr;
                }

                for(int i = 0; i < (50 - output.Length); i++)
                {
                    output += " ";
                }

                if(output.Length > 21)
                {
                    output = output.Remove(21);
                }

                Console.Write(" ----------------------- \n");
                Console.Write("| " + output +          " | \n");
                Console.Write("|-----------------------| \n");

                // First row
                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("9");
                if (keyclicked == 9)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 8)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("8");
                if (keyclicked == 8)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("7");
                if (keyclicked == 7)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");
                Console.Write("\n|-----------------------| \n");
                // First row end

                // Second row
                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("6");
                if (keyclicked == 6)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("5");
                if (keyclicked == 5)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("4");
                if (keyclicked == 4)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");
                Console.Write("\n|-----------------------| \n");
                // Second row end

                // Third row
                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("3");
                if (keyclicked == 3)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("2");
                if (keyclicked == 2)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("1");
                if (keyclicked == 1)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");
                Console.Write("\n|-----------------------| \n");
                // Third row end

                // Fourth row
                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("+");
                if (keyclicked == 10)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("0");
                if (keyclicked == 0)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 11)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("-");
                if (keyclicked == 11)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");
                Console.Write("\n|-----------------------| \n");
                // Fourth row end

                // Fifth row
                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 12)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("*");
                if (keyclicked == 12)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 13)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("/");
                if (keyclicked == 13)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");

                Console.Write("   ");
                if (keyclicked == 69)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write("=");
                if (keyclicked == 69)
                {
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.Write("|");
                // Fifth row end

                Console.Write("\n ----------------------- \n");


                Thread.Sleep(250);
            }



        }
    }
}