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

        public static int traverse()
        {
            int current_c = 0;
            List<string> visited = new List<string>();
            Queue<List<int>> queue = new Queue<List<int>>();
            List<int> start = new List<int> { start_x, start_y, current_c };
            queue.Enqueue(start);

            List<List<int>> moves = new List<List<int>>();
            List<int> down = new List<int> { 1, 0 };
            List<int> up = new List<int> { -1, 0 };
            List<int> right = new List<int> { 0, 1 };
            List<int> left = new List<int> { 0, -1 };

            moves.Add(down);
            moves.Add(up);
            moves.Add(right);
            moves.Add(left);

            while (queue.Count > 0)
            {
                List<int> current_location = queue.Dequeue();
             
                int current_x = current_location[0];
                int current_y = current_location[1];
                current_c = current_location[2];
                current_c += 1;
                Console.WriteLine(current_c);
                Console.WriteLine("current location : {0},{1} -- count : {2}", current_x, current_y, current_c);
                foreach(List<int> move in moves)
                {
                    int x = current_x;
                    int y = current_y;
                    Console.WriteLine("location : {0},{1}", x, y);
              
                    while (true)
                    {   
                        x = x + move[0];
                        y = y + move[1];
                        string local = string.Format("{0},{1}", x, y);
                      
                        
                        Console.WriteLine("location after moving: {0},{1}", x, y);
                        if (0 <= x && x < n && 0 <= y && y < n && Matrix[x][y] == ".")
                        {
                            
                            if (x == goal_x && y == goal_y)
                            {   Console.WriteLine(current_c);
                                Console.WriteLine("reached goal");
                                return current_c;
                            }
                            else if (!visited.Contains(local))
                            {
                              
                              
                                Console.WriteLine("adding {0} to visited", string.Format("{0},{1}", x, y));
                                visited.Add(string.Format("{0},{1}", x, y));
                                Console.WriteLine("adding {0},{1},{2} to the queue", x, y, current_c);
                                List<int> new_local = new List<int> { x, y, current_c };
                                queue.Enqueue(new_local);
                            }
                           
                        }
                        else
                        {
                            break;
                        }
                    }

                }
            }
            
            return -1;





        }




    }

    }

        

       