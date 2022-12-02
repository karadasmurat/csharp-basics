class DiceGame
{
    public void play(){
        
        Random rand = new Random();
        int roll1 = rand.Next(1, 7);
        int roll2 = rand.Next(1, 7);
        int roll3 = rand.Next(1, 7);

        int sum = roll1 + roll2 + roll3;
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3}");

        if (roll1 == roll2 && roll1 == roll3){
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            sum += 6;
        }
        else if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3){
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            sum += 2;
        }

        Console.WriteLine($"Total: {sum}");

        if (sum > 15){
            Console.WriteLine("You win!");
        }else{
            Console.WriteLine("Sorry, you lose.");
        }
    }
}