

using System.Drawing;
using BarcodeLib;
using ZXing.Windows.Compatibility;

namespace App1
{
    class barcodes
    {
        public static void barcodeApp()
        {
            while (true)
            {
                
                            Console.Write("[1]-Barkod Oluştur\n[2]-Barkod oku\nseciminiz: ");

                Char secim = Convert.ToChar(Console.ReadLine());

                switch (secim)

                {

                    case '1':
                        savebarcode();
                        break;
                        case '2':
                        ReadBarcode();
                        break;
                    default:
                        break;
                }
            }
        }


        public static void savebarcode()
        {
            Barcode barcode = new Barcode();
            Console.Write("Barkoda dönüşecek veriyi girin: ");
            string data = Console.ReadLine();
            barcode.Encode(TYPE.CODE128, data);
            barcode.SaveImage(Environment.CurrentDirectory + @"\barcodes\" + data + "barcode.png", BarcodeLib.SaveTypes.PNG);
            Console.WriteLine(data + " için barkod oluşturuldu");
        }
        public static void ReadBarcode()
        {
            Console.Write("Resmin bulunduğu konumu girin: ");
            string path = Console.ReadLine();
            var barcodeReader = new BarcodeReader();
            var barcodeBitmap =(Bitmap)Image.FromFile(path);
            var result = barcodeReader.Decode(barcodeBitmap);
            if (result != null)
            {
                Console.WriteLine("Barkod'da kayıtlı olan veri: " + result.Text);
            }



        }

    }




}