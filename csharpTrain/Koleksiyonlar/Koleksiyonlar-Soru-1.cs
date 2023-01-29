using System.Collections;

namespace Koleksiyonlar
{
    class KoleksiyonlarSoru1
    {
        public static void KoleksiyonSoru1()
        {
            ArrayList Primes = new ArrayList();
            ArrayList notPrime = new ArrayList();
           
                for (int i = 0; i < 20; i++)
                { try
            {
                    Console.Write($"{i + 1}. sayıyı girin: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input < 1)
                    {
                        throw new InvalidOperationException("0'dan büyük bir sayı girin:");
                    }

                    if (!isPrime(input))
                    {
                        notPrime.Add(input);
                    }
                    else
                    {
                        Primes.Add(input);
                    }
  }
            catch (Exception ex)
            {
                i--;
                Console.WriteLine(ex.ToString()+" hata!!!");
            }
                }

                Primes.Sort();
                notPrime.Sort();
                Console.WriteLine($"Asal sayıların sayısı {Primes.Count}\tortalaması {Convert.ToDouble(Avarage(Primes)) / Primes.Count} ");
                Console.WriteLine($"Asal olmayan sayıların sayısı {notPrime.Count}\tortalaması {Convert.ToDouble(Avarage(notPrime)) / notPrime.Count} ");




          

        }

        private static bool isPrime(int input)
        {

            if (input <= 1) return false;
            if (input == 2) return true;
            var max = Math.Ceiling(Math.Sqrt(input));
            for (int i = 2; i < max; i++)
            {
                if (input % i == 0)
                    return false;
            }
            return true;

        }

        private static int Avarage(ArrayList array)
        {
            int total = 0;
            for (int i = 0; i < array.Count; i++)
            {
                int arrayItem = Convert.ToInt32(array[i]);
                total += arrayItem;
            }
            return total;
        }

    }

}