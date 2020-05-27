using System;

namespace GetTypeAnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringa = "ainput: 1";
            int intSmallLetterA = 97;
            char chara = 'a';
            Console.WriteLine(intSmallLetterA);//print 97

            char intToChar = (char)intSmallLetterA;
            Console.WriteLine(intToChar); //print a

            Console.WriteLine(Char.GetNumericValue(stringa, 0)); //always print -1

            char letterA = Convert.ToChar(intSmallLetterA);
            Console.WriteLine(letterA);// print a

            Console.WriteLine("moq primer {0} + {1}", chara, chara.GetType()); //print a + System.Char
            Console.WriteLine("moq primer {0} + {1}", Convert.ToInt32(chara), Convert.ToInt32(chara).GetType()); //print 97 + System.Int32
        }
    }
}
