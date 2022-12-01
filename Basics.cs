class Basics{

    public void variable_basics(){
        
        string firstName = "Bob";
        int widgetsSold = 7;

        // What happens if we try to use the + symbol with both string and int values?
        // Both string concatenation and addition use the plus + symbol. 
        // This is called overloading an operator, and the compiler infers the proper use based on the data types it's operating on.
        Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");    // Bob sold 77 widgets.
        Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");  // Bob sold 14 widgets.


        int sum = 7 + 5;
        int quotient = 5 / 10;  // 0
        // The remainder operator % tells you the remainder of int division.
        // When the modulus is 0, that means the dividend is divisible by the divisor.
        int remainder = 7 % 5;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine($"Quotient: {quotient}"); 
        Console.WriteLine("Remainder of 7 / 5 : " + remainder);

        int fahrenheit = 94;
        float floatCelc = (fahrenheit - 32f) * (5f / 9f);
        decimal decimalCelc = (fahrenheit - 32m) * (5m / 9m);   // For money, always decimal. It's why it was created.
        Console.WriteLine($"[float] The temparature is {floatCelc} Celcius");   //34.44445 
        Console.WriteLine($"[decimal] The temparature is {decimalCelc} Celcius"); // 34.444444444444444444444444447

        // Operators like +=, -=, *=, ++, and -- are known as compound assignment operators, 
        // because they compound some operation in addition to assigning the result to the variable. 
        int value = 0;
        value += 5;
        value++;
        Console.WriteLine("First: " + value);       // First: 6
        Console.WriteLine("Second: " + value++);    // Second: 6
        Console.WriteLine("Third: " + value);       // Third: 7




        // Some methods don't rely on the current state of the application to work properly. 
        // In other words, stateless methods are implemented so that they can work without referencing or changing any values already stored in memory. 
        // Stateless methods are also known as static methods.
        // Other methods, however, must have access to the state of the application to work properly. 
        // In other words, stateful methods are built in such a way that they rely on values stored in memory by previous lines of code that have already executed, or they modify the state of the application by updating values or storing new values in memory. 
        // Stateful (instance) methods keep track of their state in fields, which are variables defined on the class. 
        // Each new instance of the class gets its own copy of those fields in which to store state.
        // A single class can support both stateful and stateless methods. 
        // However, when you need to call stateful methods, you must first create an instance of the class so that the method can access state.

        Random rand = new Random();
        int roll = rand.Next(1,7);
        Console.WriteLine("Dice: "+roll);

        // The new operator does several important things:
        //   * It first requests an address in the computer's memory large enough to store a new object based on the Random class.
        //   * It creates the new object and stores it at the memory address.
        //   * It returns the memory address so that it can be saved in the dice variable.

        // Why is the Next() method stateful?
        // Couldn't the .NET Class Library designers figure out a way to generate a random number without requiring state? And what exactly is being stored or referenced by the Next() method?
        // These are fair questions. To create the illusion of randomness, the developers of the Next() method decided to capture the date and time down to the fraction of a millisecond and use that to seed an algorithm that produces a different number each time. 
        // While not entirely random, it suffices for most applications. The state that is captured and maintained through the life time of the rand object is the seed value. Each subsequent call to the Next() method is rerunning the algorithm, but ensures that the seed changes so that the same value isn't (necessarily) returned.

        // Overloaded methods
        // An overloaded method is defined with multiple method signatures. 
        // Many methods in the .NET Class Library have overloaded method signatures.

        int number = 7;
        string text = "seven";

        Console.WriteLine(number);      // version 1
        Console.WriteLine(text);        // version 2

        Random dice = new Random();
        int roll1 = dice.Next();            // version 1
        int roll2 = dice.Next(101);         // version 2
        int roll3 = dice.Next(50, 101);     // version 3

        Console.WriteLine($"First roll: {roll1}");      
        Console.WriteLine($"Second roll: {roll2}");     
        Console.WriteLine($"Third roll: {roll3}"); 

    }
}