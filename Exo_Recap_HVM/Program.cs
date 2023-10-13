using Exo_Recap_HVM.Models;

void StartGame()
{
    Dice d2 = new Dice(2);

    Hero thierry = new Dwarf("Mister T");
    thierry.OnAttackEvent += AfficherDetailCombat;
    thierry.OnDeadEvent += (hero) =>
    {
        Console.WriteLine($"Le héro {hero.Name} a été vaincu !");
    }; 
    thierry.OnDeadEvent += (hero) =>
    {
        Console.WriteLine($"Game over !!!");
    };

    Console.WriteLine($"L'aventure commence pour notre héro {thierry.Name}");
    Console.WriteLine($"\nStatique du héro :");
    Console.WriteLine($"Force : {thierry.Strength}");
    Console.WriteLine($"End   : {thierry.Stamina}");
    Console.WriteLine($"Pdv   : {thierry.HealthMax}");
    Console.WriteLine();

    while (thierry.IsAlive)
    {
        Monster enemie = GenerateMonster();
        enemie.OnAttackEvent += AfficherDetailCombat;
        enemie.OnDeadEvent += (enemie) => Console.WriteLine("Le monstre est mort !");

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
    

    Console.WriteLine("\nRésultat de l'expedition :");
    Console.WriteLine($" - Or   : {thierry.Gold}");
    Console.WriteLine($" - Cuir : {thierry.Leather}");
}

void AfficherDetailCombat(Character attacker, Character defender, int dommage)
{
    Console.WriteLine($" - {attacker.Name} attaque {defender.Name} de {dommage} dégâts !");
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