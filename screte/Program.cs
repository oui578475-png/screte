namespace screte
{
    internal class Program
    {
        static string[] userNamesList = { "Pelle", "Stina", "Ali", "Bob" };
        static string[] userPasswordsList = { "1232342344", "abcd", "qwerty", "" };

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

        private static void AddUser()
        {
            Console.WriteLine("Hello from AddUser().");
        }

        private static void ChangePassword()
        {
            Console.WriteLine("Hello from ChangePassword().");
        }

        private static void ShowUsers()
        {
            Console.WriteLine("Hello from ShowUsers().");
        }

        private static void Login()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Lösenord: ");
            string password = Console.ReadLine();

            bool found = false;

            int i = 0;
            while (i < userNamesList.Length)
            {
                if (userNamesList[i] == name && userPasswordsList[i] == password)
                {
                    Console.WriteLine("Välkommen " + name);
                    found = true;
                    break;
                }

                i++;
            }

            if (!found)
            {
                Console.WriteLine("Fel namn eller lösenord.");
            }
        }

        static void DeleteUser()
        {
            Console.WriteLine("Ange namnet du vill ta bort från listan: ");
            string name = Console.ReadLine();

            if (Array.IndexOf(userNamesList, name) == -1)
            {
                Console.WriteLine("Inget sådant namn finns i listan.");
                return;
            }

            Console.WriteLine("Användaren finns (men borttagning är ej implementerad).");
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
