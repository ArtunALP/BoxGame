using System;

namespace BoxGame
{

    class Program
    {
        static int rowSize = 9;
        static int columnSize = 9;

        static box A = new box();
        static winspot winspot = new winspot();
        
        static player player = new player();
        
        static void Main(string[] args)
        {
            bool gameRunning = true;

            char[,] field = new char[rowSize, columnSize];
            
            bool winner = false;

            while (gameRunning)
            {
                drawField(field);

                string moveDir = Console.ReadLine();

                switch (moveDir)
                {
                    case "w":
                        field[player.y, player.x] = '.';
                        player.y--;
                        break;

                    case "a":
                        field[player.y, player.x] = '.';
                        player.x--;
                        break;

                    case "s":
                        field[player.y, player.x] = '.';
                        player.y++;
                        break;

                    case "d":
                        field[player.y, player.x] = '.';
                        player.x++;
                        break;
                }

                if (player.x == A.x && player.y == A.y)
                {
                    switch (moveDir)
                    {
                        case "w":
                            field[A.y,A.x] = '.';
                            A.y--;
                            break;

                        case "a":
                            field[A.y, A.x] = '.';
                            A.x--;
                            break;

                        case "s":
                            field[A.y, A.x] = '.';
                            A.y++;
                            break;

                        case "d":
                            field[A.y, A.x] = '.';
                            A.x++;
                            break;
                    }
                }


                if (player.x < 0) player.x = 0;
                else if (player.x > 8) player.x = 8;

                if (player.y < 0) player.y = 0;
                else if (player.y > 8) player.y = 8;


                if (A.x < 1 || A.x > 7)
                {
                    gameRunning = false;
                }
                else if (A.y < 1 || A.y > 7)
                {
                    gameRunning = false;
                }

                winner = winspot.CheckWin(A.x, A.y, winner);

                if (winner)
                {
                    gameRunning = false;
                }

                Console.Clear();

            } //main while loop

            Console.Clear();

            if (winner == true)
            {
                Console.WriteLine("You won");
            }
            else
            {
                Console.WriteLine("You lost");
            }

            Console.ReadKey();

        }

        static void drawField(char[,] field)
        {
            Console.WriteLine("-----------");

            for (int i = 0; i < columnSize; i++) //rows loop
            {
                Console.Write("|");
                for (int j = 0; j < columnSize; j++) //columns loop
                {
                    field[i, j] = '.';

                    field[winspot.wy, winspot.wx] = winspot.Visual;
                    field[player.y, player.x] = 'X';
                    field[A.y, A.x] = A.vbox;

                    Console.Write(field[i, j]);
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
        }
    }
}