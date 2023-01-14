//Daire çizme ödevi

class daire
{

    static void Main()
    {

        Console.WriteLine("Daire yarıcapi giriniz");
        int yaricap = Convert.ToInt32(Console.ReadLine());
        Daire(yaricap);


    }

    static void Daire(int yaricap = 20)
    {
        for (double y = -yaricap; y <= yaricap; y++)
        {
            for (double x = -yaricap; x <= yaricap; x += 1)
            {
                if ((x * x) + (y * y) >= yaricap * yaricap)
                    Console.Write("  ");
                else
                    Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
