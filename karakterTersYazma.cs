//Karakter ters yazdırma ödev
    class TersYaz
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] words = input.Split(" ");
            foreach (var word in words)
            {
                char first = word.First();
                string newWord = word.Remove(0, 1);
                newWord += first;
                Console.Write(newWord + " ");

            }
        }
    }
