using System;

namespace Mini_battle;

public class Player : Character
{
    public Enemy Target { get; private set; }
    public int maxHealth {get; private set; }
    public Player(string Name, int Hp, int Dmg)
        : base(Name, Hp, Dmg)
    {
        maxHealth = Hp;
    }

    public override void TakeTurn(Character Target)
    {
        Console.WriteLine("It's your turn. What do you want to do?");
        Console.WriteLine("Attack [1]");
        Console.WriteLine("Heal [2]");
        String Input = Console.ReadLine();

        if (Input == "1")
        {
            Double damageDone = Target.TakeDamage(this.Dmg);
            Console.WriteLine($"You attacked for  {damageDone} damage");
            Console.WriteLine($"Goblin now has  {Target.Hp} hp left");

        }
        else if (Input == "2")
        {
            if(HealTest(Hp) > maxHealth)
            {
                Hp = maxHealth;
                Console.WriteLine($"You healed to {Hp} Hp");
                return;
            }
            heal();
            Console.WriteLine($"You healed to {Hp}");
        }
        else
        {
            Console.WriteLine("That command dosnt exist try again");
            TakeTurn(Target);
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
//V