using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class WallsAndGatesSol
    {
        private static int[] directionX = new int[] { 0, 1, 0, -1 };
        private static int[] directionY = new int[] { 1, 0, -1, 0 };

        public static void Run()
        {

            int[][] rooms = new int[4][]{
                new int[]  {2147483647,-1,0,2147483647},
                 new int[] {2147483647,2147483647,2147483647,-1},
                 new int[] {2147483647,-1,2147483647,-1},
                 new int[] {0,-1,2147483647,2147483647}
            };
            WallsAndGates(rooms);
        }
        public static void WallsAndGates(int[][] rooms)
        {

            int r = rooms.Length;
            int c = rooms[0].Length;
            for (int i = 0; i < r; i++)
            {

                for (int j = 0; j < c; j++)
                {

                    if (rooms[i][j] == Int32.MaxValue)
                    {

                        rooms[i][j] = DistanceToNearestGate(rooms, i, j);
                    }
                }
            }
        }
        public static int DistanceToNearestGate(int[][] room, int row, int col)
        {


            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();

            q.Enqueue(new Tuple<int, int>(row, col));
            int[,] distance = new int[room.Length, room[0].Length];
            while (q.Any())
            {

                var result = q.Dequeue();
                int start_row = result.Item1;
                int start_col = result.Item2;


                for (int i = 0; i < 4; i++)
                {
                    int new_row = start_row + directionX[i];
                    int new_col = start_col + directionY[i];

                    if (IsSafe(room, new_row, new_col) && distance[new_row, new_col] == 0)
                    {

                        distance[new_row, new_col] = distance[start_row, start_col] + 1;

                        if (room[new_row][new_col] == 0)
                        {
                            return distance[new_row, new_col];

                        }
                        q.Enqueue(new Tuple<int, int>(new_row, new_col));
                    }

                }


            }

            return Int32.MaxValue;

        }
        public static bool IsSafe(int[][] room, int row, int col)
        {
            int r = room.Length;
            int c = room[0].Length;

            if (row < 0 || col < 0 || row >= r || col >= c || room[row][col] == -1)
            {
                return false;
            }

            return true;

        }


    }
}