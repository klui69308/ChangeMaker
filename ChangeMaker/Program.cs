using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> payment = new List<double>();
            Console.WriteLine("What is the price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many form of payment? ");
            int countOfPayment = Convert.ToInt16(Console.ReadLine());
            for(int i = 0; i < countOfPayment; i++)
            {
                Console.WriteLine("You payment: ");
                payment.Add(Convert.ToDouble(Console.ReadLine()));
            }
            List<int> list1 = ChangeMaker(price, payment);
            for(int i = list1.Count-1; i >= 0 ; i--)
            {
                if (i == 3)
                {
                    Console.Write("Quarter: ");
                    Console.WriteLine(list1[i]);
                }
                if (i == 2)
                {
                    Console.Write("Dime: ");
                    Console.WriteLine(list1[i]);
                }
                if (i == 1)
                {
                    Console.Write("Nickel: ");
                    Console.WriteLine(list1[i]);
                }
                if (i == 0)
                {
                    Console.Write("Penny: ");
                    Console.WriteLine(list1[i]);
                }
                
            }
        }
        public static List<int> ChangeMaker(double price, List<double> payment)
        {
            double totalPayment = 0;
            for (int i = 0; i < payment.Count; i++)
            {
                totalPayment += payment[i];
            }

            double change = 0;
            int quarter;
            int dime;
            int nickel;
            int penny;
            price = price * 100;
            totalPayment = totalPayment * 100;
            if (totalPayment < price)
            {
                change = totalPayment;
                quarter = Convert.ToInt32(Math.Floor(change / 25));
                dime = Convert.ToInt32(Math.Floor((change - quarter * 25) / 10));
                nickel = Convert.ToInt32(Math.Floor((change - quarter * 25 - dime * 10) / 5));
                penny = Convert.ToInt32(change - quarter * 25 - dime * 10 - nickel * 5);
            }
            else
            {
                change = totalPayment - price;
                quarter = Convert.ToInt32(Math.Floor(change / 25));
                dime = Convert.ToInt32(Math.Floor((change - quarter * 25) / 10));
                nickel = Convert.ToInt32(Math.Floor((change - quarter * 25 - dime * 10) / 5));
                penny = Convert.ToInt32(change - quarter * 25 - dime * 10 - nickel * 5);
            }
            List<int> numOfChange = new List<int>();
            numOfChange.Add(penny);
            numOfChange.Add(nickel);
            numOfChange.Add(dime);
            numOfChange.Add(quarter);
            return numOfChange;

        }
    }
}
