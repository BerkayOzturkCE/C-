namespace TelRehberi
{
    class ListNum
    {
        public static void ListNumber(List<Contact> myContact)
        {

            while (true)
            {
                List<Contact> newContact = new List<Contact>();

                Console.Clear();

                Console.Write("(1) A-Z\n(2) Z-A\nseciminiz: ");
                char input = Convert.ToChar(Console.ReadLine());
                switch (input)
                {
                    case '1':
                        newContact = myContact.OrderBy(x => x.Name).ToList();
                        break;
                    case '2':
                        newContact = myContact.OrderByDescending(x => x.Name).ToList();
                        break;

                    default:
                        break;
                }


                Console.Clear();
                Console.WriteLine("Telefon Rehberi");
                Console.WriteLine("**********************************************");
                foreach (var contact in newContact)
                {
                    Console.WriteLine($"İsim: {contact.Name}");
                    Console.WriteLine($"Soyisim: {contact.Surname}");
                    Console.WriteLine($"Telefon Numarası: {contact.Phone}");
                    Console.WriteLine("-");
                }
                Console.ReadKey();
                return;
            }

        }



    }
}