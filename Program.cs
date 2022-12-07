using Intro;
class Program{

    // static Main(), is special. 
    // When the program is executed, the .NET Runtime will search by default for a method named Main() to use as the starting point, or entry point, for the program.
    // Important - C# is a case-sensitive language. You must spell Main with an uppercase M.”

    static void Main(string[] args){

        Basics basics = new Basics();
        
        //basics.inputBasics();
        // basics.variable_basics();
        // basics.ArithmeticOperators();
        // basics.arrayBasics();
        // mbasics.stringBasics();
        // basics.dateTimeBasics();
        // basics.conversionBasics();
        //basics.formattingBasics();

        // Console.WriteLine(basics.addValues(10, 5));

        // double fee = basics.calculateFee(5);
        // Console.WriteLine($"calculateFee(5): {fee}");
        // fee = basics.calculateFee(5, dailyRate: 200);
        // Console.WriteLine($"calculateFee(5, dailyRate: 200): {fee}");

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

        try{

            string argument = MKDate.checkEmptyString("  ");
            Console.WriteLine($"Argument is {argument}");

            string season = MKDate.getSeason(0);
            Console.WriteLine($"It is {season}");


        }catch(ArgumentOutOfRangeException aore){
            // Catch a specific exception
            Console.WriteLine("Month not looking good");
            // Console.WriteLine(aore.Message);
        }catch(Exception e){
            // Catch all hitherto unhandled exceptions, whatever their specific type.
            Console.WriteLine(e.Message);
        }finally{
            // Ensure that some code will always run, even if an exception is thrown
            Console.WriteLine("This code will allways run, even if an exception is thrown.");
        }
        

        // DiceGame game = new DiceGame();
        // game.play();

        //FizzBuzzGame.play();
        // BattleGame.play();

    }
   
}     