namespace TelRehberi
{
    class DelNum
    {
        public static void DeleteNumber(List<Contact> myContact)
        {

            while (true)
            {
                Console.Clear();
                Console.Write("Lütfen silinecek olan kişiye ait ");
                Contact contact = FindNum.FindService(myContact);

                if (contact is null)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. ");

                    Console.Write("(1) Silmeyi sonlandır\n(2) Yeniden dene\nseciminiz: ");
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
                        Console.Write($"{contact.Name} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n) : ");
                        char input = Convert.ToChar(Console.ReadLine());
                        Console.Clear();

                        switch (input)
                        {
                            case 'y':
                                myContact.Remove(contact);
                                Console.Write($"{contact.Name} isimli kişi rehberden başarıyla silindi.");

                                return;
                            case 'n':
                                Console.Write($"{contact.Name} isimli kişi rehberden silinmedi.");

                                return;

                            default:
                                Console.Write("Yanlış seçim. ");

                                break;
                        }

                        Console.ReadKey();
                    }


                }



            }

        }

    }
}