using System;

namespace PrintInReverseOrderArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //input = a b c
            string[] names = Console.ReadLine().Split();

            for (int i = 0; i < names.Length / 2; i++)
            {
                //temp = names[0] = "a"
                //names[0] = names[2] = "c"
                //names[2] = temp = "a"

                string temp = names[i];
                names[i] = names[names.Length - i - 1];
                names[names.Length - i - 1] = temp;
            }

            Console.WriteLine(String.Join(" ", names));
        }
    }
}
