using System.Collections;

namespace Koleksiyonlar
{
    class KoleksiyonlarSoru3
    {
        public static void KoleksiyonSoru3()
        {
            string vowels = "AaEeUuOoIıİiÜüÖö";
            string sesliharfler ="";
            Console.Write("Cümle giriniz: ");
            string input = Console.ReadLine();
            char[] harfler = input.ToCharArray();

            for (int i = 0; i < harfler.Count() - 1; i++)
            {
                if (vowels.Contains(harfler[i]))
                {
                    sesliharfler+=harfler[i];
                }
               
            }
            char[] sesliler=sesliharfler.ToCharArray();
            Array.Sort(sesliler);

            for (int i = 0; i < sesliler.Length; i++){
                Console.Write(sesliler[i]+"-");
            }





        }


    }

}