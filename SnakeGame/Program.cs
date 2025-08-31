using System.Security.Cryptography.X509Certificates;

namespace SnakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10, 5);
            Console.Write("#");

            DrawBoard();

            void DrawBoard()
            {
                int width = 50;
                int height = 20;

                Console.Clear(); 

                // خط بالا
                for (int x = 0; x < width; x++)
                {
                    Console.SetCursorPosition(x, 0);
                    Console.Write("#");
                }

                // خط پایین
                for (int x = 0; x < width; x++)
                {
                    Console.SetCursorPosition(x, height - 1);
                    Console.Write("#");
                }

                // خط چپ
                for (int y = 0; y < height; y++)
                {
                    Console.SetCursorPosition(0, y);
                    Console.Write("#");
                }

                // خط راست
                for (int y = 0; y < height; y++)
                {
                    Console.SetCursorPosition(width - 1, y);
                    Console.Write("#");
                }
            }
        }


    }
}
