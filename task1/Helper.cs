using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Helper
    {
        public static int[][] String_to_array(string[] str)
        {
            int[][] _new = new int[Convert.ToInt32(str[0])][];
            int number_of_products = Convert.ToInt32(str[1].ToString());
            int k = 0;
            for (int i = 1; i < str.Length; i++)
            {
                int l = 0;
                //Узнаем количество продуктов, т.к. они находятся только на нечетных строчках
                if (i % 2 != 0)
                {
                    number_of_products = Convert.ToInt32(str[i].ToString());
                    _new[k] = new int[number_of_products];
                    i++;
                }

                for (int j = 0; j < number_of_products; j++)
                {
                    string[] new_str = GetStrings(str[i], number_of_products);
                    _new[k][l] = Convert.ToInt32(new_str[j]);
                    l++;
                }
                k++;
            }
            return _new;
        }
        static string[] GetStrings(string str, int num)
        {
            string[] strings = new string[num]; int i = 0, k = 0; string number = "";

            while (i < str.Length)
            {
                if (str[i] != ' ')
                {
                    number += str[i];
                }
                else
                {
                    strings[k] = number;
                    k++;
                    number = "";
                }
                i++;
            }
            if (!number.Equals(""))
            {
                if (strings[k] == null)
                {
                    strings[k] = number;
                }
                else
                {
                    throw new Exception("массив полон, но осталось лишнее число");
                }
                number = "";
            }

            return strings;
        }
    }
}
