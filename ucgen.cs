//Ucgen Odevi
class ucgen
{

    static void Main()
    {

        Console.WriteLine("Ucgenin boyutunu giriniz");
        int boyut = Convert.ToInt32(Console.ReadLine());
        if (boyut <= 1)
        {
            Console.WriteLine("girdiğiniz sayı 1'den büyük olmalı");
            return;
        }
        for (int i = 1; i <= boyut; i++)
        {
            for (int j = 0; j < (boyut * 2) - 1; j++)
            {
                if (j < boyut - i || j > boyut + i - 2)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }

            }
            Console.WriteLine();
        }
    }
}



