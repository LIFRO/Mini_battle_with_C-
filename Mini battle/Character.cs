using System;

namespace Mini_battle;

public abstract class Character
{
    Dice Crits = new Dice();
    public string Name {get; private set; }
    public Double Hp {get; set;}
    public int Dmg {get; private set;}

    public Character(string name, int hp, int dmg)
    {
        this.Name = name;
        this.Hp = hp;
        this.Dmg = dmg;
    }
    public void heal()
    {
        this.Hp += 10;
    }
    public Double TakeDamage(int Dmg)
    {
        double Multiplier = Crits.CritCheck();
        this.Hp -= Dmg * Multiplier;
        return Dmg * Multiplier;
    }
    public double HealTest(double Health)
    {
        Health += 10;
        return Health;
    }

    public abstract void TakeTurn(Character Target);
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