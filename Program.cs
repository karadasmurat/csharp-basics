class Program{

    // Main(), is special. 
    // When the program is executed, the .NET Runtime will search by default for a method named Main() to use as the starting point, or entry point, for the program.
    static void Main(string[] args){

        Basics basics = new Basics();
        // basics.variable_basics();
        // basics.arrayBasics();
        basics.stringBasics();
        // basics.dateTimeBasics();
        // basics.conversionBasics();
        //basics.formattingBasics();

        // Console.WriteLine(Basics.getEmployeeTitle(300)); 
        // Console.WriteLine(Basics.coinFlip()); 
        // Console.WriteLine(Basics.isEven(333));
        // Basics.SKU("01-MN-L");  // static method
        // Basics.drawSquare(5);

        // int min = Basics.min_of_three(100, 50, 222);
        // Console.WriteLine($"Min: {min}");

        // int score = 88;
        // char grade = Basics.letterOfScore(score);
        // Console.WriteLine($"Grade for {score} is {grade}");

        // DiceGame game = new DiceGame();
        // game.play();

        //FizzBuzzGame.play();
        // BattleGame.play();

    }
   
}     