using System;
public class box 
{
    public char vbox = 'O';
    static Random rnd = new Random();
    public int row = rnd.Next(1,8);
    public int column = rnd.Next(1,8);
}