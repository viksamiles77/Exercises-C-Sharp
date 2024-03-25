namespace exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = false;
            bool correctInput = false;
            DateTime dateInput = new DateTime();

            string answer;
            do
            {
                goAgain = false;

                while (true)
                {
                    Console.Write("Please enter a date (DD.MM.YYYY): ");
                    string input = Console.ReadLine();

                    if (DateTime.TryParse(input, out dateInput))
                    {
                        break;
                    }
                    Console.WriteLine("invalid input.");
                }

                IsWorkingDay(dateInput);


                do
                {
                    correctInput = false;
                    Console.WriteLine("Do you want to check another time?");
                    answer = Console.ReadLine();

                    if (answer.ToLower() == "yes")
                    {
                        goAgain = true;
                        correctInput = true;
                    }
                    else if (answer.ToLower() == "no")
                    {
                        goAgain = false;
                        correctInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please input yes or no.");
                        correctInput = false;
                    }
                } while (!correctInput);

            } while (goAgain);
        }

        static void IsWorkingDay(DateTime dateInput)
        {

            if (dateInput.DayOfWeek == DayOfWeek.Saturday || dateInput.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Non-working day.");
            }
            else
            {
                Console.WriteLine("It is working day.");
            }
        }
    }
}
