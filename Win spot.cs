using System;
public class winspot
{
    static Random rnd = new Random();

    public char Visual = '0';
    public int x = rnd.Next(0,9);
    public int y = rnd.Next(0,9);

    public bool CheckWin(int boxXholder, int boxYholder, bool winner)
    {
        if (boxXholder == x && boxYholder == y)
        {
            winner = true;
        }
        return winner;
    }
}