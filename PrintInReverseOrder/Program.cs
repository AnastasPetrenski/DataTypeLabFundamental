using System;

namespace PrintInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            //input Nasko
            string userName = Console.ReadLine();
            string password = string.Empty;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += "" + (userName[i]);
            }
            //password = oksaN
            Console.Write(password);
            Console.WriteLine();
            string single = string.Empty;
            int toInt = 0;
            string newNumber = string.Empty;
            for (int x = 0; x < userName.Length; x++)
            {

                char singleLetter = password[x];
                single += singleLetter;
                toInt = password[x];
                newNumber += "" + toInt; 
            }
            Console.WriteLine(single);
            Console.WriteLine(newNumber);

        }
    }
}
