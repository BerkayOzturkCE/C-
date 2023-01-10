//c# ödevler algoritma

class algoritma
{

    static void Main()
    {

        string input = Console.ReadLine();
        string[] words = input.Split(" ");
        foreach (var word in words)
        {
            string[] innerwords = word.Split(",");
            int indis = Convert.ToInt32(innerwords[1]);
            string newWord = innerwords[0];
            if (indis < newWord.Length && indis >= 0)
                newWord = newWord.Remove(indis, 1);
            Console.Write(newWord + " ");
        }
    }
}