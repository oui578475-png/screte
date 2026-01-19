namespace screte
{
    internal class Program
    {
        string[] userNames = { "Pelle", "Stina", "Ali", "Bob" };
        string[] userPasswords = { "1234", "abcd", "qwerty", "" };
        static void Main(string[] args)
        {
            bool runprogram = true;
            while (runprogram)
            {
                Console.WriteLine("välj 0 eller 1");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if(choice == 1)
                    {
                        AddUser();
                    }
                    if (choice == 2)
                    {
                        ChangePassword();
                    }
                    if (choice == 3)
                    {
                        ShowUsers();
                    }
                    if (choice == 4)
                    {
                        Login();
                    }
                    if (choice == 0)
                    {
                        runprogram = false;
                    }
                }
                else
                {
                    Console.WriteLine("välj i menyn");
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
            Console.WriteLine("Hello from Login().");

        }

    }
}
