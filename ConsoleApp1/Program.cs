using System.Data;
using System.Runtime.CompilerServices;

namespace Task1
{
    public class Logic
    {
        public static string rublesConvert(int costOfProduct)
        {
            int rubles = costOfProduct / 100;
            
            string messageAnswer = "";
            if (((rubles >= 10 && rubles <= 20) || ((rubles % 10) >= 5 && (rubles % 10) <= 9) || (rubles % 10) == 0) && rubles != 0)
            {
                messageAnswer = rubles + " рублей";
            }
            else if (rubles == 1 || rubles % 10 == 1)
            {
                messageAnswer = rubles + " рубль";
            }
            else if ((rubles % 10) > 1 && (rubles % 10) < 5)
            {
                messageAnswer = rubles + " рубля";
            }
            
            return messageAnswer;
        }
        public static string pennyConvert(int costOfProduct)
        {
            int ruPenny = costOfProduct % 100;
            string messageAnswer = "";
            if (ruPenny == 0)
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
        public static string convertNumberToMoneyString(int costOfProduct)
        {
            string rubMessage=Logic.rublesConvert(costOfProduct);
            string pennyMessage=Logic.pennyConvert(costOfProduct);
            string messageAnswer;
            if (rubMessage!="")
            {
                messageAnswer = rubMessage + " " + pennyMessage;
            }
            else
            {
                messageAnswer= pennyMessage;
            }

            return messageAnswer;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int costOfProduct = int.Parse(Console.ReadLine());

            string messageAnswer = Logic.convertNumberToMoneyString(costOfProduct);

            Console.WriteLine(messageAnswer);
        }
    }
}