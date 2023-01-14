class IntegerIkililer
{

    static void Main()
    {

        Console.Write("Aralarında boşluk olacak şekilde sayıları giriniz: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(" ");
      for (int i = 0; i < numbers.Length; i+=2)
      {
        int first=Convert.ToInt32(numbers[i]);
                int second=Convert.ToInt32(numbers[i+1]);

        if (first==second)
        {
            Console.Write(Math.Pow(first+second,2)+ " ");
            continue;
        }

        Console.Write((first+second)+" ");
         
      }
    }
}