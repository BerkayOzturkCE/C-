namespace TelRehberi
{
    class FindNum
    {
        public static void ShowNumber(List<Contact> myContact)
        {
            List<Contact> found = new List<Contact>();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n*******************************************");

            Console.Write("(1) İsim veya soyisime göre arama yap\n(2) Telefon numarasına göre arama yap\nseciminiz: ");
            char input = Convert.ToChar(Console.ReadLine());
            switch (input)
            {
                case '1':
                    found = FindByNameSurname(myContact);
                    break;
                case '2':
                    found = FindByNumber(myContact);
                    break;
                default:
                    break;
            }
                    Console.Clear();

            Console.WriteLine("Arama Sonuçları");
            Console.WriteLine("**********************************************");
            foreach (var contact in found)
            {
                Console.WriteLine($"İsim: {contact.Name}");
                Console.WriteLine($"Soyisim: {contact.Surname}");
                Console.WriteLine($"Telefon Numarası: {contact.Phone}");
                Console.WriteLine("-");
            }
            Console.ReadKey();

        }


        public static List<Contact> FindByNumber(List<Contact> myContact)
        {
            Console.Clear();

            Console.Write("Telefon Numarasını girin:");
            string phone = Console.ReadLine();
            var contact = myContact.FirstOrDefault(x => x.Phone.Equals(phone));

            if (contact is null)
            {
                throw new InvalidDataException("Telefon Numarası Bulunamadı.");
            }
            else
            {
                List<Contact> nums = new List<Contact>();
                nums.Add(contact);
                return nums;
            }

        }

        public static List<Contact> FindByNameSurname(List<Contact> myContact)
        {
            Console.Clear();

            Console.Write("İsim veya soyisim girin:");
            string phone = Console.ReadLine();
            var contact = myContact.FindAll(x => x.Name.Equals(phone) || x.Surname.Equals(phone));
            if (contact.Count()==0)
            {
                throw new InvalidDataException("Kayıt Bulunamadı.");
            }
            else
            {
                return contact;
            }

        }


        public static Contact FindService(List<Contact> myContact)
        {

            Console.Write("İsim veya soyisim girin:");
            string phone = Console.ReadLine();
            var contact = myContact.FirstOrDefault(x => x.Name.Equals(phone) || x.Surname.Equals(phone));
          
                return contact;
            

        }

    }
}