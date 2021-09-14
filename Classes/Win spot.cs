using System;
public class winspot
{
    static Random rnd = new Random();

    public char Visual = '0';
    public int wx = rnd.Next(1,8);
    public int wy = rnd.Next(1,8);

    public bool CheckWin(int boxXholder, int boxYholder, bool winner)
    {
        if (boxXholder == wx && boxYholder == wy)
        {
            winner = true;
        }
        return winner;
    }
}