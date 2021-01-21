using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class GasStation
    {
        public static int[] gas = new int[] { 2, 3, 4 };

        public static int[] cost = new int[] { 3, 4, 3 };

       

        public static int move(int i)
        {
            if (i + 1 > gas.Length - 1)
            {
                return 0;
            }
            else
            {
                return i + 1;
            }
        }
        public static int fill_up(int current_gas, int current_station)
        {   
            return current_gas + current_station;
        }
        public static bool empty_or_not(int gas_after_cost)
        {
            if(gas_after_cost > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int gas_used(int current_gas, int current_cost)
        {
                return current_gas - current_cost;
            
           
        }
        public static bool circled_or_not(int current_index, int start)
        {
            if(current_index == start)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int final_check(bool not_circled, int start)
        {
            if (not_circled)
            {
                return -1;
            }
            else
            {
                return start;
            }
        }
        public static int setting_the_start()
        {
            for(int i = 0; i < cost.Length; i++)
            {
                if(gas[i] > cost[i])
                {
                    return i;
                    
                }
            }
            return -1;
        }
        public static bool valid_start(int start)
        {
            if (start != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int setting_starting_gas(bool gas_not_empty, int start)
        {
            if (gas_not_empty)
            {
                return gas[start];
            }
            else
            {
                return 0;
            }
        }
        public static int Find()
        {   
            
            int start;
            start = setting_the_start();
            bool gas_not_empty = valid_start(start);
            int current_gas = setting_starting_gas(gas_not_empty,start);
            int i = start;
            bool not_circled = true;
           
            while (not_circled && gas_not_empty)
            {
              
                current_gas = gas_used(current_gas, cost[i]); 
                gas_not_empty = empty_or_not(current_gas);
                i = move(i);
                current_gas = fill_up(current_gas, gas[i]);
                not_circled = circled_or_not(i, start);
            }


            return final_check(not_circled, start);

        }

    }
}
