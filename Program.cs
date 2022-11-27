namespace find_character_index_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1124, 2124, 10, 33456, 4345, 52354, 6345, 73245, 8546, 934, 10 };

            int foundindex;

            Console.WriteLine("Enter number witch your wand to know index in array:");
            int number = int.Parse(Console.ReadLine());

            foundindex = IndexFinder(array, number);
            Console.WriteLine("Your number index is:" + foundindex);
        }

        static int IndexFinder(int[] array, int findnumber) 
        {
            int index = default;
            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i]==findnumber)
                {
                    index = i;
                }
                else if (array[i]!=findnumber)
                    Console.WriteLine("This number not in array");
            }
                
            return index;
        }
    }
}