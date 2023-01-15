
using System.Collections.Generic;

namespace TelRehberi
{
    public class TelRehberi
    {
        public static void RehberApp()
        {
             List<Contact> myContacts = new List<Contact>();

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n*******************************************");
                    Console.Write("(1) Yeni Numara Kaydetmek\n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncelleme\n(4) Rehberi Listelemek\n(5) Rehberde Arama Yapmak\n(6) Çıkış\nseciminiz: ");
                    char input = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                    switch (input)
                    {
                        case '1':
                            AddNum.AddNumber(myContacts);
                            break;
                        case '2':
                        DelNum.DeleteNumber(myContacts);
                            break;
                        case '3':
                        UpdateNum.UpdateNumber(myContacts);
                            break;
                        case '4':
                            ListNum.ListNumber(myContacts);
                            break;
                        case '5':
                        FindNum.ShowNumber(myContacts);
                            break;
                        case '6':
                            return;
                        default:
                            Console.WriteLine("Geçersiz Seçim");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();

                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
        }



    }
}