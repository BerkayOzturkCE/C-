
using System.Collections.Generic;

namespace App1
{
    public class Auth
    {


        public static User Login(List<User> users)
        {
            Console.Write("Kullanıcı adınızı giriniz: ");
            string userName = Console.ReadLine();
            User currentUser = users.FirstOrDefault(x => x.Name == userName);
            Console.Clear();

            return currentUser;

        }


        public static User SignUp(int newId)
        {

            Console.Write("Kayıt olmak için kullanıcı adınızı giriniz: ");
            string input = Console.ReadLine();
            User newUser = new User();
            newUser.ID = newId++;
            newUser.Name = input;
            Console.Clear();

            return newUser;

        }


    }
}