using System.Runtime.CompilerServices;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int costOfProduct = int.Parse(Console.ReadLine());
            int rubles = costOfProduct / 100;
            int ruPenny = costOfProduct % 100;
            if (rubles == 1 || rubles % 10 == 1)
            {
                Console.Write(rubles);
                Console.Write(" рубль ");
            }
            else if (((rubles >= 10 && rubles <= 20) || ((rubles % 10) >= 5 && (rubles % 10) <= 9) || (rubles % 10) == 0) && rubles != 0)
            {
                Console.Write(rubles);
                Console.Write(" рублей ");
            }
            else if ((rubles % 10) > 1 && (rubles % 10) < 5)
            {
                Console.Write(rubles);
                Console.Write(" рубля ");
            }
            if (ruPenny == 0 && rubles != 0)
            {
                Console.Write("ровно");
            }
            else if (ruPenny == 1 || ruPenny % 10 == 1)
            {
                Console.Write(ruPenny);
                Console.Write(" копейка");
            }
            else if ((ruPenny >= 10 && ruPenny <= 20) || ((ruPenny % 10) >= 5 && (ruPenny % 10) <= 9) || (ruPenny % 10) == 0)
            {
                Console.Write(ruPenny);
                Console.Write(" копеек");
            }
            else if ((ruPenny % 10) > 1 && (ruPenny % 10) < 5)
            {
                Console.Write(ruPenny);
                Console.Write(" копейки");
            }
        }
    }
}