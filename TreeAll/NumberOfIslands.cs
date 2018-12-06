using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAll
{
    /*
     * Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

        Example 1:

        Input:
        11110
        11010
        11000
        00000

        Output: 1
        Example 2:

        Input:
        11000
        11000
        00100
        00011

        Output: 3
     */
    public static class NumberOfIslands
    {
        static bool[,] visited;
        static int numIsland = 0;
        public static int NumIslands(char[,] grid)
        {

            var rows = grid.GetLength(0);
            var column = grid.GetLength(1);
            visited = new bool[rows, column];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == '1' && !visited[i, j])
                    {
                        CheckIfthereAdjecentIsland(grid, i, j);
                        numIsland++;
                    }
                }
            }
            return numIsland;
        }

        private static void CheckIfthereAdjecentIsland(char[,] grid, int i, int j)
        {
            try
            {

            
            if (i < 0 || i >= grid.GetLength(0)) return;
            if (j < 0 || j >= grid.GetLength(1))
            {
                return;
            }

            if (visited[i, j])
            {
                return;
            }
            if (grid[i, j] != '1')
            {
                return;
            }
            visited[i, j] = true;
            CheckIfthereAdjecentIsland(grid, i - 1, j);
            CheckIfthereAdjecentIsland(grid, i + 1, j);
            CheckIfthereAdjecentIsland(grid, i, j - 1);
            CheckIfthereAdjecentIsland(grid, i, j + 1);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
