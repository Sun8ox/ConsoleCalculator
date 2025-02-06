internal class Program
{
    private static void Main(string[] args)
    {
        
        List<double> numbers = new List<double>();
        List<char> operators = new List<char>();

        bool calculate = false;

        Console.WriteLine("Which calculator do u want to use?");
        Console.WriteLine("Click 1 for old one");
        Console.WriteLine("Click 2 for new one");
        var clicked1 =  Console.ReadKey();

        if(clicked1.Key == ConsoleKey.D2)
        {
            new ConsoleKalkulačka.CalculatorV2();
            return;
        }
        else if(clicked1.Key == ConsoleKey.D1)
        {
            Console.Clear();
        }
        else
        {
            Console.Clear();
        }

        while (true)
        {
            Console.Write("Enter number => ");

            try
            {
                numbers.Add(double.Parse(Console.ReadLine()));
            }
            catch (Exception)
            {
                Console.WriteLine("Pls enter only numbers :)");
            }

            if (operators.Count > 0)
            {
                Console.WriteLine("Click \"=\" to calculate!");
            }

            try
            {

                while (!calculate)
                {
                    Console.Write("Enter operator => ");
                    char clicked = Console.ReadKey().KeyChar;

                    if (clicked == '=')
                    {
                        calculate = true;
                        break;
                    }

                    if (clicked == '+' || clicked == '-' || clicked == '*' || clicked == '/')
                    {
                        operators.Add(clicked);
                        Console.Write("\n");
                        break;
                    } else
                    {
                        Console.Write("\n");
                        Console.WriteLine("Invalid character! Only + - * and / are allowed!");
                    }
                }

                if (calculate)
                {
                    break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Pls enter only operators :)");
            }


        }
/*
        foreach(double number in numbers)
        {
            Console.Write(number + ",");
        }
*/
        
        

       

        Console.Write("\n");

        double total = 0.0;
        int useOperator = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            double number = numbers[i];

            if(i == 0)
            {
                total = numbers[i];
            } else
            {
                if (useOperator >= operators.Count)
                {
                    break;
                }

                var operatorr = operators[useOperator];

                if (operatorr == '+')
                {
                    //Console.Write(total + "+" + number + "=" + (total + number) + "\n");
                    total += number;
                }
                else if (operatorr == '-')
                {
                    //Console.Write(total + "-" + number + "=" + (total - number) + "\n");
                    total -= number;
                }
                else if (operatorr == '*')
                {
                    total *= number;
                    Console.WriteLine("Warning! This calculator doesnt not support priorities cuz im too lazy to implement that :/");
                }
                else if (operatorr == '/')
                {
                    total /= number;
                    Console.WriteLine("Warning! This calculator doesnt not support priorities cuz im too lazy to implement that :/");
                }
                useOperator++;
            }
        }

        Console.Write("Output => " + total);
        Console.ReadKey();


    }

}