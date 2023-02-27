using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class RoutePlanner
    {
        private static int[] directionX =new int[]{0,1,-1,0};
        private static int[] directionY =new int[]{1,0,0,-1};

        private static int rowLen = 0;
        private static int  colLen = 0;
        public static bool RouteExists(int fromRow, int fromColumn, int toRow, int toColumn,
                                          bool[,] mapMatrix)
        {
             rowLen = mapMatrix.GetLength(0); 
             colLen = mapMatrix.GetLength(0);
            if(!ValidatePath(fromRow, fromColumn, toRow, toColumn)) return false;
            if(mapMatrix[fromRow, fromColumn]== false) return false;
            if(fromRow == toRow && fromColumn == toColumn) return true;


            
            

            Stack<Tuple<int,int>> s  = new Stack<Tuple<int,int>>();

            s.Push(new Tuple<int, int>(fromRow, fromColumn));
            bool[,] visited = new bool[rowLen, colLen];
            visited[fromRow, fromColumn] = true;
            while(s.Any()){

                var result = s.Pop();
                int row = result.Item1;
                int col = result.Item2;

                 if(!mapMatrix[row, col]) continue;
                for (int i = 0; i < 4; i++)
                {
                    int new_row = row + directionX[i];
                    int new_col = col + directionY[i];

                    if(!IsSafe(new_row, new_col, visited)) continue;
                    
                    if(new_row == toRow && new_col == toColumn) return true;
                    visited[new_row,new_col] = true;
                    s.Push(new Tuple<int, int>(new_row, new_col));

                }

            }

            
            return false;

        }

        public static bool IsSafe(int row, int col, bool[,] visited){
            if(row<0 || col< 0 || row >=rowLen || col>= colLen || visited[row,col] ){
                    return false;
                }

                return true;
        }
        private static bool ValidatePath(int fromRow, int fromColumn, int toRow, int toColumn){

                if(fromRow<0 || fromColumn< 0 || toRow>=rowLen || toColumn>= colLen){
                    return false;
                }

                return true;

        }

        public static void Main()
        {
            bool[,] mapMatrix = {
            {true, false, false},
            {true, true, false},
            {false, true, true}
        };

            Console.WriteLine(RouteExists(0, 0, 2, 2, mapMatrix));
        }
    }
}