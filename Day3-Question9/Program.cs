namespace Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter the string");
                string string1 = Console.ReadLine();
                string[] strarr = string1.Split(" ");
                int flag = 0;
                for (int iterator = 0; iterator < (strarr.Length) - 1; iterator++)
                {
                    string stringOne = "";
                    string stringTwo = "";
                    char last = '\0';
                    char first = '\0';
                    stringOne = strarr[iterator];
                    stringTwo = strarr[iterator + 1];
                    last = stringOne[(stringOne.Length) - 1];
                    first = stringTwo[0];
                    Console.WriteLine(first);
                    Console.WriteLine(last);
                    if (last.Equals(first))
                    {
                        flag = 0;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }


        }
    }

