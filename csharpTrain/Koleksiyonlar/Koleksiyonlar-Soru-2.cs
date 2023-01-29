using System.Collections;

namespace Koleksiyonlar
{
    class KoleksiyonlarSoru2
    {
        public static void KoleksiyonSoru2()
        {
            int[] numbers = new int[20];

            int[] biggest = new int[3];
            int[] smallest = new int[3];

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    Console.Write($"{i + 1}. sayıyı girin: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    numbers[i] = input;
                }
                catch (Exception ex)
                {
                    i--;
                    Console.WriteLine(ex.ToString() + " hata!!!");
                }
            }

            Array.Sort(numbers);

            for (int i = 0; i < 3; i++)
            {
                biggest[i] = numbers[i];
                smallest[i] = numbers[numbers.Length-1-i];
            }

            Console.WriteLine($"En büyük üç sayının toplamı: {Avarage(biggest)*3}\t ortalaması: {Avarage(biggest)}");
            Console.WriteLine($"En küçük üç sayının toplamı: {Avarage(smallest)*3}\t ortalaması: {Avarage(smallest)}");






        }



        private static double Avarage(int[] array)
        {
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int arrayItem = Convert.ToInt32(array[i]);
                total += arrayItem;
            }
            return total/array.Length;
        }

    }

}