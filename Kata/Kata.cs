using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public static class Kata
    {

        public static string GetMiddle(string str)
        {
            int pos = (str.Length / 2);
            if (str.Length % 2 == 0)
            {
                return str[pos-1].ToString() + str[pos].ToString();
            }
            else
            {
                return str[pos].ToString();
            }
        }



        public static int[] SortArray(int[] array)
        {
            if (array.Count() == 0)
                return array;

            List<int> odd = array.Where(i => i % 2 == 1).ToList();
            odd.Sort();
            for (int i=0; i< array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    array[i] = odd.First();
                    odd.RemoveAt(0);
                }
            }
            return array;
        }

        public static int[] SortArrayBest(int[] array)
        {
            Queue<int> odds = new Queue<int>(array.Where(e => e % 2 == 1).OrderBy(e => e));

            return array.Select(e => e % 2 == 1 ? odds.Dequeue() : e).ToArray();
        }

        public static string GetReadableTime(int seconds)
        {
            int numHours = seconds>=3600?seconds / 3600:0;
            seconds = seconds - (numHours * 3600);

            int numMinutes = seconds>=60?seconds / 60:0;
            seconds = seconds - (numMinutes * 60);

            int numSeconds = seconds;
            
            return string.Concat((numHours > 10?numHours.ToString():string.Concat("0",numHours.ToString())) , ":" ,
                    (numMinutes > 10 ? numMinutes.ToString() : string.Concat("0", numMinutes.ToString())) , ":" ,
                    (numSeconds > 10 ? numSeconds.ToString() : string.Concat("0", numSeconds.ToString())));
        }
    }
}
