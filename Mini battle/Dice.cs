using System;

namespace Mini_battle;

public class Dice
{
    private Random rand = new Random();

    public int SixDice() => rand.Next(1, 7);
    
    public double CritCheck()
    {
        int CheckNumber = SixDice();
        if (CheckNumber > 4)
        {
            return 1.25;
        }
        else
        {
            return 1;
        }
    } 
}


//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//