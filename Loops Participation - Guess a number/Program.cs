using System;

namespace Loops_Participation___Guess_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set a MIN value");
            string answer = Console.ReadLine();
            int MIN = Convert.ToInt32(answer);
            


            Console.WriteLine("Set a MAX value");
            answer = Console.ReadLine();
            int MAX = Convert.ToInt32(answer);
            

            Console.WriteLine($"Guess the number between {MIN} and {MAX}");
            answer = Console.ReadLine();
            int guess = Convert.ToInt32(answer);

            Random rand = new Random();
            int randomNumber = rand.Next(MIN, MAX + 1);

            while (randomNumber != guess)
            {
                Console.WriteLine("Your guess is incorrect, feel free to attempt again!");
                guess = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine($"Hey good job, you got it right!");






        }









        
        
        
          
        
           
        
    }
}
