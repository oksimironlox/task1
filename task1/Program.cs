using System.Collections.Immutable;
using System.IO;

namespace task1
{
    internal class Program
    {
        static string Path = @"..\..\..\..\test.txt";
        static int[][] Test;
        static int[] result;

        static void ReadFile(string path)
        {
            string[] file = File.ReadAllLines(path);
            Test = Helper.String_to_array(file);
            result = new int[Convert.ToInt32(file[0].ToString())];
        }

        static void Processing()
        {
            int lenght = Test.Length;
            
            for (int i = 0; i < lenght; i++) 
            {
                int[] arr = Test[i];
                Array.Sort(arr);
                int quantity = 1, sum = 0;

                if(arr.Length == 1) 
                {
                    sum += arr[0];
                }
                else 
                {
                    for (int j = 1; j < arr.Length; j++)
                    {
                        if (arr[j] != arr[j - 1] || j == arr.Length - 1)
                        {
                            if (j == arr.Length - 1)
                            {
                                quantity++;
                            }
                            int whole_part = quantity / 3 * 2;
                            int remains = quantity % 3;
                            sum += (whole_part + remains) * arr[j - 1];
                            quantity = 1;
                        }
                        else
                        {
                            quantity++;
                        }

                    }
                }
                result[i] = sum;
            }
        }

        static void Main(string[] args)
        {
            ReadFile(@"..\..\..\..\test.txt");
            Processing();

            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

       
    }

    
}