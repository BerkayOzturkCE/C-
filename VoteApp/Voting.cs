
using System.Collections.Generic;

namespace App1
{
    public class Vote
    {
        public static List<Category> categories = new List<Category>(){
                new Category(){ ID = 1,  Title="Action         ",Vote=0},
                new Category(){ ID = 2,  Title="Adventure      ",Vote=0},
                new Category(){ ID = 3,  Title="Comedy         ",Vote=0},
                new Category(){ ID = 4,  Title="Drama          ",Vote=0},
                new Category(){ ID = 5,  Title="Horror         ",Vote=0},
                new Category(){ ID = 6,  Title="Romance        ",Vote=0},
                new Category(){ ID = 7,  Title="Science fiction",Vote=0},
                new Category(){ ID = 8,  Title="Fantasy        ",Vote=0},
                new Category(){ ID = 9,  Title="Historical     ",Vote=0},
            };

        public static List<User> users = new List<User>(){
                new User(){ ID = 1, Name="Berkay"},
                new User(){ ID = 2,  Name="Ezgi"},
                new User(){ ID = 3,  Name="Mustafa"},
            };
        public static User currentUser;

        public static void VoteApp()
        {

            while (true)
            {
                int total = 0;
                try
                {
                    Console.Write("[1]- Oy kullan\n[2]- Kayıt Ol\n[3]- Sonuçlar\n[4]- Çıkış\nseciminiz: ");
                    char input = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                    switch (input)
                    {
                        case '1':
                            currentUser = Auth.Login(users);
                            if (currentUser == null)
                            {
                                currentUser = Auth.SignUp(users.Count());
                                users.Add(currentUser);
                            }
                            vote(currentUser);
                            break;
                        case '2':
                            users.Add(Auth.SignUp(users.Count()));
                            break;
                        case '3':
                            total = categories.Sum(x => x.Vote);
                            foreach (var category in categories)
                            {
                                Console.WriteLine($"{category.ID}-{category.Title}\t Oy sayısı: {category.Vote}\tOy Oranı: %{(category.Vote * 100) / total}");
                            }
                            break;
                        case '4':
                            total = categories.Sum(x => x.Vote);
                            foreach (var category in categories)
                            {
                                Console.WriteLine($"{category.ID}-{category.Title}\t Oy sayısı: {category.Vote}\tOy Oranı: %{(category.Vote * 100) / total}");
                            }
                            return;
                        default:
                            Console.WriteLine("Geçersiz Seçim");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Hatası alındı.");
                }
            }


        }

        public static void vote(User currentUser)
        {
            Console.WriteLine($"{currentUser.Name}, Oy vermek istediğiniz kategorinin Id'sini seçiniz");

            foreach (var category in categories)
            {
                Console.WriteLine($"{category.ID}-{category.Title}");
            }
            Console.Write("Seçiminiz: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Category selectedCategory = categories.FirstOrDefault(x => x.ID == input);
            if (selectedCategory == null)
            {
                throw new InvalidOperationException("Kategori bulunamadı.");
            }

            selectedCategory.Vote++;

        }



    }
}