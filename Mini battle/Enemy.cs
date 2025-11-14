using System;

namespace Mini_battle;

public class Enemy : Character
{
    public Player Target { get; private set; }
    private Boolean RageMode { get; set;}

    public Enemy(string Name, int Hp, int Dmg)
        : base(Name, Hp, Dmg)
        {
            RageMode = false;
        }

        public override void TakeTurn(Character Target)
        {
            Dice dice = new Dice();
            int diceRoll = dice.SixDice();
            if (Hp > 50)
            {

                if (diceRoll == 1)
                {
                    if(HealTest(Hp) > 100)
                    {
                        Hp = 100;
                        Console.WriteLine($"Goblin healed to 100 Hp");
                        return;
                    }
                    heal(); 
                    Console.WriteLine($"Goblin healed to {Hp} Hp");
                }
                else
                {
                    Double damageDone = Target.TakeDamage(this.Dmg);
                    Console.WriteLine($"Goblin attacked for {damageDone} damage");
                    Console.WriteLine($"You now have {Target.Hp} hp left");
                }
            }
            if(Hp < 50)
            {
                if (RageMode == false)
            {
                Console.WriteLine("Goblin activated rage mode");
                RageMode = true;
            }
                if (diceRoll < 5)
                {
                    if(HealTest(Hp) > 50)
                {
                    if (RageMode == true)
                    {
                        Console.WriteLine("Goblin deactivated rage mode");
                        RageMode = false;
                    }
                }
                    if(HealTest(Hp) > 100)
                {
                    Hp = 100;
                    Console.WriteLine($"Goblin healed to 100 Hp");
                    return;
                }
                    heal();
                    Console.WriteLine($"Goblin healed to {Hp} Hp");
                }
                else
                {
                    Double damageDone = Target.TakeDamage(this.Dmg);
                    Target.Hp -= Dmg * 0.5;
                    Console.WriteLine($"Goblin attacked for {damageDone * 1.5} damage");
                    Console.WriteLine($"You now have {Target.Hp} hp left");
                }
            }
        } 
}
