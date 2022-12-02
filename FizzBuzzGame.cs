class FizzBuzzGame{

    // FizzBuzz rules:
    // Output values from 1 to 100, one number per line.
    // When the current value is divisible by 3, print the term Fizz next to the number.
    // When the current value is divisible by 5, print the term Buzz next to the number.
    // When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.

    public static void play(){

        for(int i = 1; i <= 100; i++){
            if(i % 15 == 0){
                Console.WriteLine("FizzBuzz");
                continue;
            }
            if( i % 3 == 0){
                Console.WriteLine("Fizz");
                continue;
            }
            if( i % 5 == 0){
                Console.WriteLine("Buzz");
                continue;
            }

            Console.WriteLine(i);
        }
    }
}