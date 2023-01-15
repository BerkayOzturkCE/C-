namespace TelRehberi
{
    class UpdateNum
    {
        public static void UpdateNumber(List<Contact> myContact)
        {

            while (true)
            {
                Console.Clear();
                Console.Write("Lütfen Güncellenecek olan kişiye ait ");
                Contact contact = FindNum.FindService(myContact);

                if (contact is null)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. ");

                    Console.Write("(1) Güncellemeyi sonlandır\n(2) Yeniden dene\nseciminiz: ");
                    char input = Convert.ToChar(Console.ReadLine());
                    switch (input)
                    {
                        case '1':
                            return;
                        case '2':
                            continue;

                        default:
                            Console.Write("Yanlış seçim. ");

                            break;
                    }

                }
                else
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.Write("(1) İsmi Güncelle\n(2) Soyismi Güncelle\n(3) Numarayı Güncelle\nseciminiz: ");
                        char input = Convert.ToChar(Console.ReadLine());
                        Console.Clear();


                        switch (input)
                        {
                            case '1':
                                Console.Write("Lütfen yeni isimi giriniz: ");
                                contact.Name = Console.ReadLine();

                                break;
                            case '2':
                                Console.Write("Lütfen yeni soyismi giriniz: ");
                                contact.Surname = Console.ReadLine();

                                break;
                            case '3':
                                Console.Write("Lütfen yeni numarayı giriniz: ");
                                contact.Phone = Console.ReadLine();

                                break;

                            default:
                                Console.Write("Yanlış seçim. ");
                                Console.ReadKey();
                                continue;
                        }
                        Console.Write("Başarıyla Güncellendi");
                        Console.ReadKey();
                        return;
                    }


                }



            }

        }

    }
}