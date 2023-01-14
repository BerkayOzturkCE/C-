//Karakter ters yazdırma ödev
class SessizHarf
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(" ");
        string vowels = "AaEeUuOoIıİiÜüÖö";
        foreach (var word in words)
        {
            if (word.Length < 2)
            {
                Console.Write("false ");
                continue;
            }
            char[] harfler = word.ToCharArray();
            for (int i = 0; i < harfler.Count() - 1; i++)
            {
                if (!vowels.Contains(harfler[i]) && !vowels.Contains(harfler[i + 1]))
                {
                    Console.Write("true ");
                    break;
                }
                if (i == harfler.Count() - 2)
                {
                    Console.Write("false ");
                }
            }
        }
    }
}
