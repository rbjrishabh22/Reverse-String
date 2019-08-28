using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string strValue = "India is my country";
            string rev = "";
            int l = strValue.Length - 1;
            while (l >= 0)
            {
                rev = rev + strValue[l];
                l--;
            }
            Console.WriteLine("Befor reverse: {0}", strValue);
            Console.WriteLine("After reverse: {0}",rev);
            Console.ReadLine();
        }
    }
}
