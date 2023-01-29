namespace ToDoListApplication
{
    class ToDoListApplication
    {
        public static void ToDoListMain()
        {


            Dictionary<int, string> members = new Dictionary<int, string>();
            members.Add(1, "TeamMember1");
            members.Add(2, "TeamMember2");
            members.Add(3, "TeamMember3");



            List<Card> ToDoList = new List<Card>(){
                            new Card()
                            {
                                AssignedTo=1,
                                Title="Test Card 1",
                                Description="Test Card Description 1",
                                Size=1,
                                }
            };
            List<Card> InProgressList = new List<Card>(){
                            new Card()
                            {
                                AssignedTo=2,
                                Title="Test Card 2",
                                Description="Test Card Description 2",
                                Size=2,
                                }
            };
            List<Card> DoneList = new List<Card>(){
                            new Card()
                            {
                                AssignedTo=3,
                                Title="Test Card 3",
                                Description="Test Card Description 3",
                                Size=3,
                                }
            };


            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n*******************************************");
                    Console.Write("(1) Board Listelemek\n(2) Board'a Kart Eklemek\n(3) Board'dan Kart Silmek\n(4) Kart Taşımak\n(5)Çıkış\nseciminiz: ");
                    char input = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                    switch (input)
                    {
                        case '1':
                        ListBoard.ListBoardFunc(ToDoList,InProgressList,DoneList, members);
                            break;
                        case '2':
                        AddCard.AddCardFunc(ToDoList, members);
                            break;
                        case '3':
                        DeleteCard.DeleteCardFunc(ToDoList,InProgressList,DoneList);
                            break;
                        case '4':
                        UpdateCard.UpdateCardFunc(ToDoList,InProgressList,DoneList, members);
                            break;
                        case '5':
                            return;
                        default:
                            Console.WriteLine("Geçersiz Seçim");
                            Console.ReadKey();
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