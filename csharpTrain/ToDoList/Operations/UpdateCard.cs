namespace ToDoListApplication
{
    class UpdateCard
    {
        public static void UpdateCardFunc(List<Card> ToDoList, List<Card> InProgressList, List<Card> DoneList, Dictionary<int, string> members)
        {

            while (true)
            {
                Console.Clear();
                Console.Write("Lütfen taşıma işlemi için Kart başlığını yazın:  ");
                string Title = Console.ReadLine();
                Card ToDokart = ToDoList.FirstOrDefault(c => c.Title.Equals(Title));

                Card InProgresskart = InProgressList.FirstOrDefault(c => c.Title.Equals(Title));

                Card Donekart = DoneList.FirstOrDefault(c => c.Title.Equals(Title));



                if (ToDokart is null && InProgresskart is null && Donekart is null)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kayıt bulunamadı. Lütfen bir seçim yapınız. ");

                    Console.Write("(1) Taşıma işlemini sonlandır\n(2) Yeniden dene\nseciminiz: ");
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
                    Card card = new Card();
                    if (ToDokart is not null)
                    {
                        ViewCard(ToDokart, members);
                        card = ToDokart;
                        ToDoList.Remove(ToDokart);
                    }
                    else if (InProgresskart is not null)
                    {
                        ViewCard(InProgresskart, members);
                        card = InProgresskart;
                        InProgressList.Remove(InProgresskart);
                    }
                    else if (Donekart is not null)
                    {
                        ViewCard(Donekart, members);
                        card = Donekart;
                        DoneList.Remove(Donekart);
                    }


                    Console.Write("\nLütfen taşımak istediğiniz Line'ı girin\n(1)  ToDo\n(2)   IN PROGRESS\n(3)  Done\nseciminiz: ");
                    char input = Convert.ToChar(Console.ReadLine());
                    switch (input)
                    {
                        case '1':
                            ToDoList.Add(card);
                            break;
                        case '2':
                            InProgressList.Add(card);

                            break;
                        case '3':
                            DoneList.Add(card);

                            break;

                        default:
                            Console.Write("Yanlış seçim. ");

                            return;
                    }
                            Console.Write("Taşıma işlemi başarıyla tamamlandı");

                    Console.ReadKey();
                    return;


                }

            }

        }

        public static void ViewCard(Card card, Dictionary<int, string> members)
        {
            Console.WriteLine("\n\nBulunan kart bilgileri\n*******************************************\n");

            Console.WriteLine($"Başlık      :{card.Title}");
            Console.WriteLine($"İçerik      :{card.Description}");
            Console.WriteLine($"Atanan Kişi :{members[card.AssignedTo]}");
            Console.WriteLine($"Büyüklük    :{((SizeEnum)card.Size).ToString()}");
        }

    }
}