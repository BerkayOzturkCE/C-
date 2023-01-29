namespace ToDoListApplication
{
    class AddCard
    {
        public static void AddCardFunc(List<Card> ToDoList, Dictionary<int, string> members)
        {
            Card newCard = new Card();
            Console.Write("Başlık giriniz                                 : ");
            newCard.Title = Console.ReadLine();
            Console.Write("İçerik giriniz                                 : ");
            newCard.Description = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) : ");
            newCard.Size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kişi Seçiniz                                   : ");
            newCard.AssignedTo = Convert.ToInt32(Console.ReadLine());

            if (!members.ContainsKey(newCard.AssignedTo))
                throw new InvalidOperationException("Takım Üyesi bulunamadı!!!");
            
            if(newCard.Size>5||newCard.Size<1)
                throw new InvalidOperationException("Yanlış boyut girildi!!!");

            ToDoList.Add(newCard);
            Console.Clear();
            Console.Write("Yeni kart başarıyla eklendi.");
            Console.ReadKey();
        }



    }



}
