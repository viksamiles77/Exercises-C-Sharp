namespace exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            do {
                Console.Write("Please enter a word (input x to stop): ");
                string input = Console.ReadLine().ToLower();
                if (input.ToLower() == "x")
                {
                    break;
                }
                words.Add(input);
            } while (true);

            Console.Write("Please enter a text: ");
            string text = Console.ReadLine().ToLower();
            CheckWordCount(words, text);

        }

        static void CheckWordCount(List<string> words, string text)
        {
            string[] textWords = text.Split(' ', '.', '@', '?', ',', '!');
            foreach (string word in words)
            {
                int count = 0;
                foreach (string txtWord in textWords) {
                if (word == txtWord)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Word '{word}' appears {count} times in the text");
            }
        }
    }
}
