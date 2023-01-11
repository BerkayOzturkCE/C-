//Karakter ters yazdırma ödev
class KarakterDegistir
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(" ");
        foreach (var word in words)
        {
            char first = ' ';
            char last = ' ';
            last = word.Last();

            string newWord = word.Remove(word.Length - 1, 1);
            if (newWord.Length > 0)
            {
                first = word.First();
                newWord = newWord.Remove(0, 1);

            }

            newWord = last + newWord + first;
            Console.Write(newWord + " ");

        }
    }
}
