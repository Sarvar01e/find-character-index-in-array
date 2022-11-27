using System.Xml;

namespace find_character_index_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1124, 2124, 10, 33456, 4345, 52354, 6345, 73245, 8546, 934, 10 };

            string foundindex;

            Console.WriteLine("Enter number witch your wand to know index in array:");
            int number = int.Parse(Console.ReadLine());

            foundindex = IndexFinder(array, number);
            Console.WriteLine(foundindex);

            Console.ReadLine();
   
        }

        static string IndexFinder(int[] array, int findnumber)
        {
            string index = "Your number is out of array";
            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i]==findnumber)
                {
                    index = "Your number index is:" + i;
                    break;
                }
            }                
            return index;
        }
    }
}