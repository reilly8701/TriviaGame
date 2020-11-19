using System;

namespace trivia_aGAINUGH
{
    class TriviaQuestion
    {
        public string question = "";
        public string answer = "";
    }
    class Player
    {
        string name = "someone";
        int score = 0;
    }
    class Game
    {


        string gameName = "Fish Trivia by Maura";

        public Game()
        {
            TriviaQuestion Sharks = new TriviaQuestion();
            TriviaQuestion BigFish = new TriviaQuestion();
            string SharkResponse = "baby shark dododododo";
            string BigFishResponse = "thats a bigass fish";
            SharkResponse = Console.ReadLine();
            BigFishResponse = Console.ReadLine();
            Sharks.question = "What shark has been found in the Illinois River?";
            Sharks.answer = "Bull Shark";
            BigFish.question = "What's the world's largest freshwater fish?";
            BigFish.answer = "Buluga Sturgeon";

            Console.Title = gameName;
            Console.WriteLine("Welcome to " + gameName);
            Console.WriteLine("Type your answer to the questions. Press Enter to move forward");
            Play();
            Console.ReadKey();
            Console.WriteLine(Sharks.question);
            Console.ReadKey();
            Console.ReadLine();
            Console.WriteLine("the correct response was " + Sharks.answer + ". Press Enter to continue");
            Console.ReadKey();
            Console.WriteLine(BigFish.question);
            Console.ReadKey();
            Console.ReadLine();
            Console.WriteLine("the correct response was " + BigFish.answer + ". Press Enter to continue");
            Console.ReadKey();
            Console.WriteLine("congrats. you learned about fish. hooray.");
            Console.ReadKey();


        }
        private void Play()
        {

            TriviaQuestion Sharks = new TriviaQuestion();
            TriviaQuestion BigFish = new TriviaQuestion();
            Sharks.question = "What shark has been found in the Illinois River?";
            Sharks.answer = "Bull Shark";
            BigFish.question = "What's the world's largest freshwater fish?";
            BigFish.answer = "Buluga Sturgeon";
        }
        class Program
        {

            static void Main()
            {
                new Game();
            }






        }

    }


}
