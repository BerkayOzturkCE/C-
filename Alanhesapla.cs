class AlanHesap
{

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("[1]-Kare Alanı");
            Console.WriteLine("[2]-Üçgen Alanı");
            Console.WriteLine("[3]-Daire Alanı");
            Console.WriteLine("[4]-Dikdörtgen Alanı");
            Console.Write("Seciminiz:");
            Char secim = Convert.ToChar(Console.ReadLine());

            switch (secim)

            {
                case '1':
                    KareAlan();
                    break;
                case '2':
                    UcgenAlan();
                    break;
                case '3':
                    DaireAlan();
                    break;
                case '4':
                    DikdortgenAlan();
                    break;
                default:
                    break;
            }
        }
    }

    static void KareAlan()
    {
        Console.Write("Kenar boyutu girin:");
        double kenar = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Alan: " + kenar * kenar);
    }
    static void DikdortgenAlan()
    {
        Console.Write("Yükseklik girin:");
        double yukseklik = Convert.ToDouble(Console.ReadLine());
        Console.Write("Taban boyutu girin:");
        double taban = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Alan: " + yukseklik * taban);
    }
    static void UcgenAlan()
    {
        Console.Write("Yükseklik girin:");
        double yukseklik = Convert.ToDouble(Console.ReadLine());
        Console.Write("Taban boyutu girin:");
        double taban = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Alan: " + yukseklik * taban / 2);
    }
    static void DaireAlan()
    {
        Console.Write("Yaricap girin:");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Alan: " + Math.PI * r * r);
    }
}