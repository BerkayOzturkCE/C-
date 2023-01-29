namespace ToDoListApplication
{
    class DeleteCard
    {
        public static void DeleteCardFunc(List<Card> ToDoList, List<Card> InProgressList, List<Card> DoneList)
        {

            while (true)
            {
                Console.Clear();
                Console.Write("Lütfen Kart başlığını yazın:  ");
                string Title = Console.ReadLine();
                Card ToDokart = ToDoList.FirstOrDefault(c => c.Title.Equals(Title));

                Card InProgresskart = InProgressList.FirstOrDefault(c => c.Title.Equals(Title));

                Card Donekart = DoneList.FirstOrDefault(c => c.Title.Equals(Title));



                if (ToDokart is null && InProgresskart is null && Donekart is null)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kayıt bulunamadı. Lütfen bir seçim yapınız. ");

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

                    if (ToDokart is not null)
                    {
                        ToDoList.Remove(ToDokart);
                        Console.Write($"{ToDokart.Title} isimli kayıt başarıyla silindi.");
                    }
                    else if (InProgresskart is not null)
                    {
                        InProgressList.Remove(InProgresskart);
                        Console.Write($"{InProgresskart.Title} isimli kayıt başarıyla silindi.");
                    }
                    else if (Donekart is not null)
                    {
                        DoneList.Remove(Donekart);
                        Console.Write($"{Donekart.Title} isimli kayıt başarıyla silindi.");
                    }
                    Console.ReadKey();
                    return;






                }



            }

        }

    }
}