using System;
public class box 
{
    public char vbox = 'O';
    static Random rnd = new Random();
    public int y = rnd.Next(1,8);
    public int x = rnd.Next(1,8);
}