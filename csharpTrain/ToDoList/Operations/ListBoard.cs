namespace ToDoListApplication
{
    class ListBoard
    {
        public static void ListBoardFunc(List<Card> ToDoList, List<Card> InProgressList, List<Card> DoneList, Dictionary<int, string> members)
        {

            Console.Clear();
            Console.WriteLine("\n\nToDo Line\n*******************************************\n");
            if (ToDoList.Count()==0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var ToDo in ToDoList)
                {
                    Console.WriteLine($"Başlık      :{ToDo.Title}");
                    Console.WriteLine($"İçerik      :{ToDo.Description}");
                    Console.WriteLine($"Atanan Kişi :{members[ToDo.AssignedTo]}");
                    Console.WriteLine($"Büyüklük    :{((SizeEnum)ToDo.Size).ToString()}");
                    Console.WriteLine("----");
                }
            }

            Console.WriteLine("\n\nInProgress Line\n*******************************************\n");
            if (InProgressList.Count() == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var InProgress in InProgressList)
                {
                    Console.WriteLine($"Başlık      :{InProgress.Title}");
                    Console.WriteLine($"İçerik      :{InProgress.Description}");
                    Console.WriteLine($"Atanan Kişi :{members[InProgress.AssignedTo]}");
                    Console.WriteLine($"Büyüklük    :{((SizeEnum)InProgress.Size).ToString()}");
                    Console.WriteLine("----");
                }
            }
            Console.WriteLine("\n\nDone Line\n*******************************************\n");

            if (DoneList.Count() == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var Done in DoneList)
                {
                    Console.WriteLine($"Başlık      :{Done.Title}");
                    Console.WriteLine($"İçerik      :{Done.Description}");
                    Console.WriteLine($"Atanan Kişi :{members[Done.AssignedTo]}");
                    Console.WriteLine($"Büyüklük    :{((SizeEnum)Done.Size).ToString()}");
                    Console.WriteLine("----");
                }
            }
            Console.ReadKey();

        }



    }
}