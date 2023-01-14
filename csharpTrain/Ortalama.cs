
    class OrtalamaHesapla
    {

         static void Main()
        {
            Console.WriteLine("dizi boyutunu girin:");
            int boyut = Convert.ToInt32(Console.ReadLine());
           int sayi= fibbonaci(boyut);
           double ort=Convert.ToDouble(sayi)/boyut;
           Console.WriteLine(ort);

        }


        public static int fibbonaci(int boyut){

            int n=1, m=1, toplam=2;
            for (int i = 2; i < boyut; i++) {
                int temp=n+m;
                n=m;
                m=temp;
                toplam+=m;
            }
            return toplam;

        }
    }
