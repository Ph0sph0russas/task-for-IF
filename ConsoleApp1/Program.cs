using System.Runtime.CompilerServices;

namespace Task1
{
    public class Logic
    {
        public static string Transformation(int costOfProduct)
        {
            int rubles = costOfProduct / 100;
            int ruPenny = costOfProduct % 100;
            string messageAnswer = "";
            if (((rubles >= 10 && rubles <= 20) || ((rubles % 10) >= 5 && (rubles % 10) <= 9) || (rubles % 10) == 0) && rubles != 0)
            {
                messageAnswer = rubles + " рублей ";
            }
            else if (rubles == 1 || rubles % 10 == 1)
            {
                messageAnswer = rubles + " рубль ";
            }
            else if ((rubles % 10) > 1 && (rubles % 10) < 5)
            {
                messageAnswer = rubles + " рубля ";
            }
            if (ruPenny == 0 && rubles != 0)
            {
                messageAnswer = messageAnswer + "ровно";
            }
            else if ((ruPenny >= 10 && ruPenny <= 20) || ((ruPenny % 10) >= 5 && (ruPenny % 10) <= 9) || (ruPenny % 10) == 0)
            {
                messageAnswer = messageAnswer + ruPenny + " копеек";
            }
            else if (ruPenny == 1 || ruPenny % 10 == 1)
            {
                messageAnswer = messageAnswer + ruPenny + " копейка";
            }
            else if ((ruPenny % 10) > 1 && (ruPenny % 10) < 5)
            {
                messageAnswer = messageAnswer + ruPenny + " копейки";

            }
            return messageAnswer;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int costOfProduct = int.Parse(Console.ReadLine());


            string messageAnswer = Logic.Transformation(costOfProduct);


            Console.WriteLine(messageAnswer);
        }
    }
}