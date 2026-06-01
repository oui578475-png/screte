namespace screte
{
    internal class Program
    {
        static string[] userNamesList = { "Pelle", "Stina", "Ali", "Bob" };
        static string[] userPasswordsList = { "1234", "abcd", "qwerty", "" };

        static bool isLoggedIn = false;
        static string currentUser = "";

        static void Main(string[] args)
        {
            bool runprogram = true;

            while (runprogram)
            {
                Menu();

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 1)
                    {
                        AddUser();
                    }
                    else if (choice == 2)
                    {
                        ChangePassword();
                    }
                    else if (choice == 3)
                    {
                        ShowUsers();
                    }
                    else if (choice == 4)
                    {
                        Login();
                    }
                    else if (choice == 5)
                    {
                        DeleteUser();
                    }
                    else if (choice == 0)
                    {
                        runprogram = false;
                    }
                    else
                    {
                        Console.WriteLine("Fel val.");
                    }
                }
                else
                {
                    Console.WriteLine("Välj i menyn.");
                }
            }
        }

        static void Login()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Lösenord: ");
            string password = Console.ReadLine();

            for (int i = 0; i < userNamesList.Length; i++)
            {
                if (userNamesList[i] == name && userPasswordsList[i] == password)
                {
                    Console.WriteLine("Välkommen " + name);
                    isLoggedIn = true;
                    currentUser = name;
                    return;
                }
            }

            Console.WriteLine("Fel namn eller lösenord.");
        }

        static void AddUser()
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("Du måste vara inloggad först.");
                return;
            }

            Console.Write("Nytt namn: ");
            string newName = Console.ReadLine();

            Console.Write("Nytt lösenord: ");
            string newPassword = Console.ReadLine();

            Array.Resize(ref userNamesList, userNamesList.Length + 1);
            Array.Resize(ref userPasswordsList, userPasswordsList.Length + 1);

            userNamesList[^1] = newName;
            userPasswordsList[^1] = newPassword;

            Console.WriteLine("Användare tillagd!");
        }

        static void ShowUsers()
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("Du måste vara inloggad först.");
                return;
            }

            Console.WriteLine("Användare:");
            for (int i = 0; i < userNamesList.Length; i++)
            {
                Console.WriteLine(userNamesList[i]);
            }
        }

        static void DeleteUser()
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("Du måste vara inloggad först.");
                return;
            }

            Console.Write("Namn att ta bort: ");
            string name = Console.ReadLine();

            int index = Array.IndexOf(userNamesList, name);

            if (index == -1)
            {
                Console.WriteLine("Finns inte.");
                return;
            }

            for (int i = index; i < userNamesList.Length - 1; i++)
            {
                userNamesList[i] = userNamesList[i + 1];
                userPasswordsList[i] = userPasswordsList[i + 1];
            }

            Array.Resize(ref userNamesList, userNamesList.Length - 1);
            Array.Resize(ref userPasswordsList, userPasswordsList.Length - 1);

            Console.WriteLine("Användare borttagen!");
        }

        static void ChangePassword()
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("Du måste vara inloggad först.");
                return;
            }

            Console.Write("Nytt lösenord: ");
            string newPassword = Console.ReadLine();

            for (int i = 0; i < userNamesList.Length; i++)
            {
                if (userNamesList[i] == currentUser)
                {
                    userPasswordsList[i] = newPassword;
                    Console.WriteLine("Lösenord ändrat!");
                    return;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("\n--- MENY ---");
            Console.WriteLine("1. AddUser");
            Console.WriteLine("2. ChangePassword");
            Console.WriteLine("3. ShowUsers");
            Console.WriteLine("4. Login");
            Console.WriteLine("5. DeleteUser");
            Console.WriteLine("0. Exit");
        }
    }
}