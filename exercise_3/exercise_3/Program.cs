using System.Security.Cryptography;

namespace exercise_3
{
    internal class Program
    {
        public static int cpuWinsCounter = 0;
        public static int myWinsCounter = 0;
        public static int draws = 0;
        public static int playedTimes = 0;
        static void Main(string[] args)
        {
            bool exitApp = false;
            do
            {
                exitApp = false;
                Console.WriteLine("Please select one of three options");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Stats");
                Console.WriteLine("3. Exit");
                while (true)
                {
                    string selectedOption = Console.ReadLine();
                    if (selectedOption == "1")
                    {
                        Play();
                        break;
                    }
                    else if (selectedOption == "2")
                    {
                        Stats();
                        break;
                    }
                    else if (selectedOption == "3")
                    {
                        exitApp = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter 1, 2 or 3.");
                    }
                }
            } while (!exitApp);
        }

        static void Play()
        {


            List<string> cpuChoice = new List<string> { "rock", "paper", "scissors" };
            Console.WriteLine("Please select: 1-rock, 2-paper, 3-scissors");
            while (true)
            {
                string selectedOption = Console.ReadLine();
                if (selectedOption == "1")
                {
                    Console.WriteLine("You selected: rock.");
                    Random randNum = new Random();
                    int randomPos = randNum.Next(cpuChoice.Count);
                    string currChoice = cpuChoice[randomPos];
                    Console.WriteLine($"Cpu selected: {currChoice}");
                    if (currChoice == "rock")
                    {
                        Console.WriteLine("Draw.");
                        draws++;
                        playedTimes++;
                    }
                    else if (currChoice == "paper")
                    {
                        Console.WriteLine("You lose.");
                        cpuWinsCounter++;
                        playedTimes++;
                    }
                    else if (currChoice == "scissors")
                    {
                        Console.WriteLine("You win.");
                        myWinsCounter++;
                        playedTimes++;
                    }
                    break;
                }
                else if (selectedOption == "2")
                {
                    Console.WriteLine("You selected: paper.");
                    Random randNum = new Random();
                    int randomPos = randNum.Next(cpuChoice.Count);
                    string currChoice = cpuChoice[randomPos];
                    Console.WriteLine($"Cpu selected: {currChoice}");
                    if (currChoice == "rock")
                    {
                        Console.WriteLine("You win.");
                        myWinsCounter++;
                        playedTimes++;
                    }
                    else if (currChoice == "paper")
                    {
                        Console.WriteLine("Draw.");
                        draws++;
                    }
                    else if (currChoice == "scissors")
                    {
                        Console.WriteLine("You lose.");
                        cpuWinsCounter++;
                        playedTimes++;
                    }
                    break;
                }
                else if (selectedOption == "3")
                {
                    Console.WriteLine("You selected: scissors.");
                    Random randNum = new Random();
                    int randomPos = randNum.Next(cpuChoice.Count);
                    string currChoice = cpuChoice[randomPos];
                    Console.WriteLine($"Cpu selected: {currChoice}");
                    if (currChoice == "rock")
                    {
                        Console.WriteLine("You lose.");
                        cpuWinsCounter++;
                        playedTimes++;
                    }
                    else if (currChoice == "paper")
                    {
                        Console.WriteLine("You win.");
                        myWinsCounter++;
                        playedTimes++;
                    }
                    else if (currChoice == "scissors")
                    {
                        Console.WriteLine("Draw.");
                        draws++;
                        playedTimes++;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter 1, 2 or 3.");
                }

            }
        }
        static void Stats()
        {
            // Percentage formula = (Value/Total value) × 100
            decimal percentMyWins = myWinsCounter;
            decimal percentPlayedTimes = playedTimes;
            decimal percentCpuWon = cpuWinsCounter;
            decimal percentDraws = draws;

            decimal myWinsResult = percentMyWins / percentPlayedTimes * 100;
            decimal cpuWinsResult = percentCpuWon / percentPlayedTimes * 100;
            decimal drawResult = percentDraws / percentPlayedTimes * 100;

            Console.WriteLine($"You won {myWinsCounter} times, {myWinsResult}%");
            Console.WriteLine($"Cpu won {cpuWinsCounter} times, {cpuWinsResult}%");
            Console.WriteLine($"You drew {draws} times, {drawResult}%");
        }
    }
}
