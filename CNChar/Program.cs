using System;

namespace CNChar
{
    class Program
    {
        static void Main(string[] args)
        {
            var tran = new Translator();
            Console.WriteLine("请输入汉字:\n");
            while (true)
            {
                Console.WriteLine(tran.GetChineseSpell(Console.ReadLine()));
            }
        }
    }
}


