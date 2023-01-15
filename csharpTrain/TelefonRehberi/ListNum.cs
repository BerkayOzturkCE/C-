namespace TelRehberi
{
    class ListNum
    {
        public static void ListNumber(List<Contact> myContact)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var contact in myContact)
            {
                Console.WriteLine($"İsim: {contact.Name}");
                Console.WriteLine($"Soyisim: {contact.Surname}");
                Console.WriteLine($"Telefon Numarası: {contact.Phone}");
                Console.WriteLine("-");
            }
            Console.ReadKey();

        }

        

    }
}