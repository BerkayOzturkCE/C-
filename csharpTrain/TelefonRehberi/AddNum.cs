
namespace TelRehberi
{
    class AddNum
    {
        public static void AddNumber(List<Contact> myContacts){
            Console.Write("Lütfen isim giriniz              : ");
            string name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz           : ");
            string surname = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz  : ");
            string phoneNum = Console.ReadLine();
            var contact=myContacts.FirstOrDefault(x=>x.Phone.Equals(phoneNum));
        
            
            if (contact is null)
            {
                Contact newContact=new Contact();
                newContact.Name=name;
                newContact.Surname=surname;
                newContact.Phone=phoneNum;
                myContacts.Add(newContact);
            }else
            {
                throw new InvalidDataException("Telefon Numarası kayıtlı !!!");
            }

        }
        
    }
}