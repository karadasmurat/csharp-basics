class BattleGame{

    public static void play(){

        int healthHero = 10;
        int healthMonster = 10;

        bool heroAttacks = true;

        Console.WriteLine($"Let the game begin!\nHero: {healthHero}   vs   Monster: {healthMonster}\n");

        while (true){
            Random rand = new Random();
            int attack = rand.Next(1, 11);


            if(heroAttacks){
                Console.WriteLine($"Hero hits with {attack}!");
                healthMonster -= attack;
                Console.WriteLine($"Hero: {healthHero}   vs   Monster: {healthMonster}");
                if(healthMonster <= 0){
                    Console.WriteLine($"🌟 Hero wins!");
                    break;
                }
            }
            else{
                Console.WriteLine($"Monster hits back with {attack}!");
                healthHero -= attack;
                Console.WriteLine($"Hero: {healthHero}   vs   Monster: {healthMonster}");
                if(healthHero <= 0){
                    Console.WriteLine($"Hero lost.");
                    break;
                }
            } 

            heroAttacks = !heroAttacks;     // Logical Negation operator to switch on/off
            Console.WriteLine("");

        }
    }
}