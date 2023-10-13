using Exo_Recap_HVM.Models;

void StartGame()
{
    Hero thierry = new Dwarf("Mister T");
    Dice d2 = new Dice(2);

    Console.WriteLine($"L'aventure commence pour notre héro {thierry.Name}");
    Console.WriteLine($"\nStatique du héro :");
    Console.WriteLine($"Force : {thierry.Strength}");
    Console.WriteLine($"End   : {thierry.Stamina}");
    Console.WriteLine($"Pdv   : {thierry.HealthMax}");
    Console.WriteLine();

    while (thierry.IsAlive)
    {
        Monster enemie = GenerateMonster();
        Console.WriteLine($"Combat contre un « {enemie.Name} » !");

        bool heroInitiative = (d2.Roll() == 1);
        while(thierry.IsAlive && enemie.IsAlive)
        {
            if(heroInitiative)
            {
                thierry.Attack(enemie);
            }
            else
            {
                enemie.Attack(thierry);
            }

            heroInitiative = !heroInitiative;
        }

        if(thierry.IsAlive )
        {
            thierry.Loot(enemie);
            thierry.RestoreHealth();
        }

        Console.WriteLine();
    }
    Console.WriteLine("Le héro a été vaincu !");

    Console.WriteLine("\nRésultat de l'expedition :");
    Console.WriteLine($" - Or   : {thierry.Gold}");
    Console.WriteLine($" - Cuir : {thierry.Leather}");
}

Monster GenerateMonster()
{
    Dice d3 = new Dice(3);

    Monster monster;

    switch(d3.Roll())
    {
        case 1:
            monster = new Wolf();
            break;
        case 2:
            monster = new Orc();
            break;
        default:
            monster = new Dragonet();
            break;
    }

    return monster;
}



StartGame();