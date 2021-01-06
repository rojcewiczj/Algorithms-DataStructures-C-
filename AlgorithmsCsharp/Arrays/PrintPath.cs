using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCsharp.Arrays
{
    class PrintPath
    {
        public static List<List<string>> Matrix = new List<List<string>>();

        public static int n = 10;

        public static int start_x = 0;

        public static int start_y = 0;

        public static int goal_x = 5;

        public static int goal_y = 7;


        public static void insert()
        {
            for (int i = 0; i < n; i++)
            {
                List<string> row = new List<string>();
                Matrix.Add(row);
                for (int j = 0; j < n; j++)
                {
                    if (i != 9 && j == 4)
                    {
                        Matrix[i].Add("X");
                    }
                    else
                    {
                        Matrix[i].Add(".");
                    }
                    Console.Write(" {0} ", Matrix[i][j]);
                }

                Console.WriteLine("");
            }
        }

        public static void traverse()
        {
            List<string> path = new List<string>();
            int x = start_x;
            int y = start_y;
            bool x_switch = false;
            bool y_switch = true;
            path.Add(string.Format("{0},{1}", x, y));

            while(x != goal_x || y != goal_y)
            {   
                if (Matrix[x].Contains("X") && y == start_y)
                {   

                       if(x < n - 1) { 
                        x += 1;
                       }
                        Console.WriteLine(x);
                    Console.WriteLine(Matrix[x].Contains("X"));
                    
                }
                else if ( y != goal_y)
                {  
                    if(path.Count == 1)
                    {
                        path.Add(string.Format("{0},{1}", x, y));
                    }
                    y += 1;


                }
                else
                {
                    if(path.Count == 2)
                    {
                        path.Add(string.Format("{0},{1}", x, y));
                    }
                    if (x < goal_x)
                    {
                        x -= 1;
                    }
                    else
                    {
                        x += 1;
                    }
                }

            }
            path.Add(string.Format("{0},{1}", x, y));
            
            foreach(string location in path)
            {
                Console.WriteLine(location);
            }



        }


    }
}
