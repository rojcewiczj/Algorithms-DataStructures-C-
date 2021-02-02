using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    public class Boats
    {
        public static int[] people = new int[] { 3, 1, 4, 5, 2, 7};

        public static int limit = 7;


        public static int NumRescueBoats()
        {
            Array.Sort(people);

            int Boats = 0;

            int i = 0;
            int j = people.Length - 1;
            while(i <= j)
            {
                Console.WriteLine(i);
                if(people[i] + people[j] > limit)
                {
                    Boats += 2;
                    i++;
                    j--;
                }
                else
                {
                    Boats += 1;
                    j--;
                    i++;
                }
            }

            return Boats;
        }
    }
}
