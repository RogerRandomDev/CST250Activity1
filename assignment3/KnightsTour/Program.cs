using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3._4
{
    class Program
    {
        static int BoardSize = 8;
        static int attemptedMoves = 0;
        static int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };
        static int[,] boardGrid = new int[BoardSize, BoardSize];

        static void Main(string[] args)
        {
            solveKT();
            Console.ReadLine();
        }

        static void solveKT()
        {
            // Initialize the boardGrid with -1 to represent unvisited squares
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    boardGrid[i, j] = -1;
                }
            }

            // Starting position of the knight
            int startX = 0; int startY = 0;

            // Mark the starting position as visited
            boardGrid[startX, startY] = 0;

            // Start the recursive backtracking
            if (solveKTUtil(startX, startY, 1))
            {
                Console.WriteLine("Solution found:");
                printSolution(boardGrid);
            }
            else
            {
                Console.WriteLine("No solution exists.");
            }
        }

        static bool solveKTUtil(int x, int y, int moveCount)
        {
            attemptedMoves++;
            if (attemptedMoves % 1000000 == 0)
                Console.Out.WriteLine("Attempts: {0}", attemptedMoves);

            if (moveCount == BoardSize * BoardSize)
                return true;

            List<(int, int)> possibleMoves = new List<(int, int)>();

            for (int k = 0; k < 8; k++)
            {
                int next_x = x + xMove[k];
                int next_y = y + yMove[k];
                if (isSquareSafe(next_x, next_y))
                {
                    int neighborCount = CountVisitedNeighbors(next_x, next_y);
                    possibleMoves.Add((next_x, next_y));
                }
            }

            // Sort the possible moves based on the count of unvisited neighbors in ascending order
            possibleMoves.Sort((a, b) => CountVisitedNeighbors(a.Item1, a.Item2).CompareTo(CountVisitedNeighbors(b.Item1, b.Item2)));

            // Iterate through the sorted possible moves
            foreach (var move in possibleMoves)
            {
                int next_x = move.Item1;
                int next_y = move.Item2;

                // Mark the next move on the board
                boardGrid[next_x, next_y] = moveCount;

                // Recursively call solveKTUtil for the next move
                if (solveKTUtil(next_x, next_y, moveCount + 1))
                    return true;
                else
                    boardGrid[next_x, next_y] = -1; // Backtrack and reset the move if it doesn't lead to a solution
            }

            return false; // Return false if no solution is found from the current position
        }

        static int CountVisitedNeighbors(int x, int y)
        {
            int count = 0;

            // Iterate through all possible knight moves
            for (int i = 0; i < 8; i++)
            {
                int next_x = x + xMove[i];
                int next_y = y + yMove[i];

                // Check if the square at (next_x, next_y) is a valid and unvisited square
                if (isSquareSafe(next_x, next_y))
                    count++;
            }

            // Return the count of visited neighbors
            return count;
        }

        static bool isSquareSafe(int x, int y)
        {
            return (x >= 0 && x < BoardSize && y >= 0 && y < BoardSize && boardGrid[x, y] == -1);
        }

        static void printSolution(int[,] solution)
        {
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                    Console.Write(solution[x, y] + " ");

                Console.WriteLine();
            }
        }
    }
}
