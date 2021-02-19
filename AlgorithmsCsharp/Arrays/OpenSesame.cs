using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class OpenSesame
    {



        public static int[] prices = new int[] { 98, 35, 94, 48, 19, 53, 32, 35, 11, 50, 27, 6, 83, 70, 24, 90, 21, 61, 65, 42 };

        

        public static void find()
        {
            int maxProfit = 0;
            int currentBuy = prices[0];

            int currentSell = prices[0];

            for(int i = 0; i< prices.Length; i++)
            {
                if(prices[i] < currentBuy)
                {
                    currentBuy = prices[i];
                    currentSell = prices[i + 1];
                    if(currentSell - currentBuy > maxProfit)
                    {
                        maxProfit = currentSell - currentBuy;
                    }
                }
                else if(prices[i] > currentSell)
                {
                    currentSell = prices[i];
                    if(currentSell - currentBuy > maxProfit)
                    {
                        maxProfit = currentSell - currentBuy;
                    }
                }
            }





            Console.WriteLine(maxProfit);
        }

     }
    
}
