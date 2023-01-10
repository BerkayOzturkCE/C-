class AlanHesap
{

    static void Main()
    {
        while (true)
{
    Console.WriteLine("[1]-Kare ");
    Console.WriteLine("[2]-Üçgen ");
    Console.WriteLine("[3]-Daire ");
    Console.WriteLine("[4]-Dikdörtgen ");
    Console.Write("Seciminiz:");
    Char secim = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("[1]-Alan");
    Console.WriteLine("[2]-Çevre");
    Console.WriteLine("[3]-hacim");
    Console.Write("Seciminiz:");

    Char tur = Convert.ToChar(Console.ReadLine());

    switch (secim)

    {
        case '1':
            KareAlan(tur);
            break;
        case '2':
            UcgenAlan(tur);
            break;
        case '3':
            DaireAlan(tur);
            break;
        case '4':
            DikdortgenAlan(tur);
            break;
        default:
            break;
    }
}

    }

    static void KareAlan(char tur)
{

    Console.Write("Kenar boyutu girin:");
    double kenar = Convert.ToDouble(Console.ReadLine());
    if (tur == '1')
    {
        Console.WriteLine("Alan: " + kenar * kenar);

    }
    else if (tur == '2')
    {
        Console.WriteLine("Çevre: " + kenar * 4);

    }
    else
    {
        Console.WriteLine("hacim    : " + kenar * kenar * kenar);

    }

}
static void DikdortgenAlan(char tur)
{
    Console.Write("Yükseklik girin:");
    double yukseklik = Convert.ToDouble(Console.ReadLine());
    Console.Write("genislik girin:");
    double genislik = Convert.ToDouble(Console.ReadLine());


    if (tur == '1')
    {
        Console.WriteLine("Alan: " + yukseklik * genislik);

    }
    else if (tur == '2')
    {
        Console.WriteLine("Çevre: " + (yukseklik * 2 + genislik * 2));

    }
    else
    {
        Console.Write("uzunluk girin:");
        double uzunluk = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("hacim    : " + yukseklik * genislik * uzunluk);

    }
}
static void UcgenAlan(char tur)
{
    if (tur == '2')
    {
        Console.Write("sol kenarı girin:");
    }
    else
    {
        Console.Write("Yükseklik girin:");
    }
    double yukseklik = Convert.ToDouble(Console.ReadLine());
    Console.Write("Taban boyutu girin:");
    double taban = Convert.ToDouble(Console.ReadLine());

    if (tur == '1')
    {
        Console.WriteLine("Alan: " + yukseklik * taban / 2);

    }
    else if (tur == '2')
    {
        Console.Write("sol kenarı girin:");
        double kenar = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Çevre: " + (kenar + taban + yukseklik));

    }
    else
    {
        Console.WriteLine("hacim    : " + (Math.Pow(taban, 2) * yukseklik) / 3);

    }
}
static void DaireAlan(char tur)
{
    Console.Write("Yaricap girin:");
    double r = Convert.ToDouble(Console.ReadLine());

    if (tur == '1')
    {
        Console.WriteLine("Alan: " + Math.PI * r * r);

    }
    else if (tur == '2')
    {
        Console.WriteLine("Çevre: " + 2 * Math.PI * r);

    }
    else
    {
        Console.WriteLine("hacim    : " + (4 * Math.PI * Math.Pow(r, 3))/3);

    }
}
}