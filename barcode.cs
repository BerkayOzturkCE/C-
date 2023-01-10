
using BarcodeLib;
class barcodes
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("[1]-Barcode oluştur");
            Char secim = Convert.ToChar(Console.ReadLine());

            switch (secim)

            {

                case '1':
                    Barcode barcode = savebarcode();
                    Console.WriteLine("barkod verisi: " + barcode.RawData);
                    break;
                default:
                    break;
            }
        }
    }


    public static Barcode savebarcode()
    {
        Barcode barcode = new Barcode();
        Console.WriteLine("Veri girin");
        string data = Console.ReadLine();
        barcode.Encode(TYPE.ISBN, data);
        barcode.SaveImage(Environment.CurrentDirectory + @"\" + data + "barcode.png", SaveTypes.PNG);
        Console.WriteLine(data + " için barkod oluşturuldu");
        return barcode;
    }

}



