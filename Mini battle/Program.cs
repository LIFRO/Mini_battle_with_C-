// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using Mini_battle;

Player Person = null;
Enemy Goblin = new Enemy("Goblin", 100, 15);
bool NoCharacter = true;
Dice Roll = new Dice();
Boolean PersonStarted;
Boolean Fight = true;

Console.WriteLine("what should the name of your character be?");
string? PlayerName = Console.ReadLine();
if (PlayerName == null || PlayerName == "")
{
    PlayerName = "Gary";
}

while (NoCharacter == true)
{
    Console.WriteLine("Do you want a heavy character or a strong character\n To get heavy character type [H]\n To get a strong character type [S] ");
    string? CharacterType = Console.ReadLine();
    if (CharacterType == "H")
    {
        Person = new Player(PlayerName, 300, 15);
        NoCharacter = false;
    }
    else if (CharacterType == "S")
    {
        Person = new Player(PlayerName, 100, 30);
        NoCharacter = false;
    }
    else
    {
        Console.WriteLine("That type doesnt exist");
    }
}
Console.WriteLine("Your characters name is " + Person!.Name + "\n Your chracters hp is " + Person.Hp + "\n Your characters dmg is " + Person.Dmg);

Goblin = new Enemy("Goblin", 100, 30);

Console.WriteLine($"You are fighting a {Goblin.Name} with these stats Hp {Goblin.Hp} and Dmg {Goblin.Dmg}");

int RollResult = Roll.SixDice();
if (RollResult > 4)
{
    PersonStarted = true;
}
else
{
    PersonStarted = false;
}
if (PersonStarted == true)
{
    while (Fight == true)
    {
        if (Person.Hp < 0)
        {
            Console.WriteLine("You lost!!");
            Fight = false;
            break;
        }

        Person.TakeTurn(Goblin);
        if (Goblin.Hp < 0)
        {
            Console.WriteLine("You won!!!");
            Fight = false;
            break;
        }
        Goblin.TakeTurn(Person);
    }
}
else
{
    while(Fight == true)
    {
        if (Goblin.Hp < 0)
        {
            Console.WriteLine("You won!!");
            Fight = false;
            break;
        }
        Goblin.TakeTurn(Person);
        if (Person.Hp < 0)
        {
            Console.WriteLine("You lost");
            Fight = false;
            break;
        }
        Person.TakeTurn(Goblin);
    }
}

