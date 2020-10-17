using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_characters_in_your_string
{
    /*
     
     The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.

     What if the string is empty? Then the result should be empty object literal, {}.

     */
    class Program
    {
        static void Main(string[] args)
        {

            var directory = new Dictionary<char, int>(2);
            while (true)
            {
            directory = Kata.Count(Console.ReadLine());
           
            foreach (var item in directory)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            }
            
            
        }

    }

    public  class Kata
    {
        public static Dictionary<char, int> Count(string str)
        {
            var dic = new Dictionary<char, int>();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i]==str[j])
                    {
                        count++;
                    }
                }
                if (!dic.ContainsKey(str[i]))
                {
                dic.Add(str[i],count);
                }
                count = 0;
            }
            return dic;
        }
    }
    public class Kata2
    {
        public static Dictionary<char, int> Count(string str)
        {
            return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
