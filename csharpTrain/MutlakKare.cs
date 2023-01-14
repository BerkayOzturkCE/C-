class MutlakKare
{

    static void Main()
    {
        int kucuk = 0, buyuk = 0;

        Console.Write("Aralarında boşluk olacak şekilde sayıları giriniz: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(" ");
        for (int i = 0; i < numbers.Length; i++)
        {
            int num = Convert.ToInt32(numbers[i]);

            if (num < 67)
            {
                kucuk += 67 - num;
            }else{
                num=num-67;
                buyuk+=num*num;
            }


        }
                    Console.WriteLine(kucuk+" "+buyuk);

    }
}