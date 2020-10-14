using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = "121212121";
            Console.WriteLine(DisplayNumbers(string1) == string1);

            var string2 = "111111111111111";
            Console.WriteLine(DisplayNumbers(string2) == "9161");

            var string3 = "44455";
            Console.WriteLine(DisplayNumbers(string3) == "3425");

            var string4 = "111222333";
            Console.WriteLine(DisplayNumbers(string4) == "313233");

            var string5 = "111022203330";
            Console.WriteLine(DisplayNumbers(string5) == "310320330");
        }

        public static string DisplayNumbers(string input)
        {
            var result = "";
            var currentNumber = 0;
            var numberSequence = 1;

            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (i + 1 >= input.Length)
                {
                    if (currentNumber != 0)
                    {
                        if (input[i] == input[i - 1])
                        {
                            result += numberSequence.ToString() + currentNumber.ToString();
                            break;
                        }
                    }
                    else
                    {
                        result += input[i].ToString();
                        break;
                    }
                }
                else
                {
                    if (input[i] == input[i + 1])
                    {
                        currentNumber = int.Parse(input[i].ToString());
                        numberSequence++;

                        if (numberSequence == 9)
                        {
                            result += numberSequence.ToString() + currentNumber.ToString();
                            numberSequence = 0;
                        }
                    }
                    else
                    {
                        if (currentNumber != 0)
                        {
                            result += numberSequence.ToString() + currentNumber.ToString();

                            currentNumber = 0;
                            numberSequence = 1;
                        }
                        else
                        {
                            result += input[i].ToString();
                            continue;
                        }
                    }
                }
            }

            Console.WriteLine(result);
            return result;
        }
    }
}
