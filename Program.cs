using System;

namespace BoxGame
{

    class Program
    {
        static int rowSize = 9;
        static int columnSize = 9;
        static void Main(string[] args)
            {

            box A = new box();
            winspot winspot = new winspot();

            bool gameRunning = true;

            char[,] field = new char[rowSize,columnSize];
            
            int Xholder = 0;
            int Yholder = 0;
            
            int boxXholder = A.column;
            int boxYholder = A.row;

            char player = 'X';

            bool winner = false;

            while(gameRunning)
            {
                field[Yholder,Xholder] = player;
                field[boxYholder,boxXholder] = A.vbox;
                field[winspot.y, winspot.x] = winspot.Visual;

                drawField(field);
                string moveDir = Console.ReadLine();

                switch(moveDir)
                {
                    case "w":
                        field[Yholder,Xholder] = ' ';
                        Yholder--;
                        break;
                        
                    case "a":
                        field[Yholder,Xholder] = ' ';
                        Xholder--;
                        break;

                    case "s":
                        field[Yholder,Xholder] = ' ';
                        Yholder++;
                        break;

                    case "d":
                        field[Yholder,Xholder] = ' ';
                        Xholder++;
                        break;
                }

                if(Xholder == boxXholder && Yholder == boxYholder)
                {
                    Console.WriteLine("aaa");
                    switch(moveDir)
                    {
                        case "w":
                            field[boxYholder,boxXholder] = ' ';
                            boxYholder--;
                            break;
                            
                        case "a":
                            field[boxYholder,boxXholder] = ' ';
                            boxXholder--;
                            break;

                        case "s":
                            field[boxYholder,boxXholder] = ' ';
                            boxYholder++;
                            break;

                        case "d":
                            field[boxYholder,boxXholder] = ' ';
                            boxXholder++;
                            break;
                    }
                }


                if(Xholder < 0 ) Xholder = 0;
                else if(Xholder > 8) Xholder = 8;

                if(Yholder < 0) Yholder = 0;
                else if(Yholder > 8) Yholder = 8;


                if(boxXholder < 1 || boxXholder > 7) 
                {
                    gameRunning = false;
                }
                else if(boxYholder < 1 || boxYholder > 7) 
                {
                    gameRunning = false;
                }

                winner = winspot.CheckWin(boxXholder, boxYholder, winner); 
                
                if(winner)
                {
                    gameRunning = false;
                }
                Console.Clear();
            }

            Console.Clear();
            if(winner == true)
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
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < columnSize; i++) //rows loop
            {
                Console.Write("|");
                for (int j = 0; j < columnSize; j++) //columns loop
                {
                    Console.Write("  ");
                    Console.Write(field[i,j]);
                }
                Console.Write("  |");
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------");
        }
    }
}
