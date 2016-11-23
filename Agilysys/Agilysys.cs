using System;
using System.Linq;

namespace AgilysysProject
{
    public class Agilysys
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 1, 2, 3 };
            var clean_array = remove_duplicates(array);

            foreach (var item in clean_array)
                Console.WriteLine(item);
            Console.ReadLine();
        }


        public static int[] remove_duplicates(int[] array_of_entries) {
            var distinct_array = array_of_entries.Distinct().ToArray();
            return distinct_array;
        }
    }
}
