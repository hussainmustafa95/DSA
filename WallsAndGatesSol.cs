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
        private static int cell = Int32.MaxValue;
        private static int gate = 0;
        private static int wall = -1;

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

        private static void WallsAndGateEfficient(int[][] rooms){

            int rLen = rooms.Length;
            int cLen = rooms[0].Length;

            Queue<Tuple<int,int>> q = new Queue<Tuple<int,int>>();

            for (int i = 0; i < rLen; i++)
            {
                for (int j = 0; j < cLen; j++)
                {
                    if(rooms[i][j]==gate){
                    q.Enqueue(new Tuple<int, int>(i,j));
                    }
                }
            }

            int[,] distance = new int[rLen,cLen];
            while(q.Any()){
                var result = q.Dequeue();
                int row = result.Item1;
                int col = result.Item2;


                for (int i = 0; i < 4; i++)
                {
                    
                    var new_row = row + directionX[i];
                    var new_col = col + directionY[i];


                    if(!IsSafe(rooms,new_row, new_col) || rooms[new_row][new_col] != cell )
                    {
                        continue;
                    }


                    rooms[new_row][new_col]  = rooms[row][col] +1; 

                    q.Enqueue(new Tuple<int, int>(new_row,new_col));
                }


            }
        }
        private static void WallsAndGates(int[][] rooms)
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
        private static int DistanceToNearestGate(int[][] room, int row, int col)
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
        private static bool IsSafe(int[][] room, int row, int col)
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