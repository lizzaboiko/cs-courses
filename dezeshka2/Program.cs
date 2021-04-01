using System;

namespace dezeshka2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! Select option to continue:");
            Console.WriteLine("1 - Login");
            Console.WriteLine("2 - Register");
            Console.WriteLine("3 - Forgot password");
            Console.Writeline("4 - Admin login");

            var action = int.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Console.WriteLine("Proceed to login");
                    Login();
                    break;
                case 2:
                    Console.WriteLine("Proceed to register");
                    Register();
                    break;
                case 3:
                    Console.WriteLine("Proceed to lost password form");
                    RestoreAccount();
                    break;
                case 4:
                    Console.WriteLine("Proceed to login for admin");
                    AdminPanel();
                    break;
                default:
                    throw new Exception("Chosen option is not supported");
            }

            private static void Login()
            {
                var savedlogin = "lizza";
                var savedpassword = "0203";
                Console.WriteLine("Введите логин:");
                var login = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                var password = Console.ReadLine();

                if ((savedlogin == login) && (savedpassword == password))
                {
                    Console.WriteLine("Вход в систему выполнен успешно");
                }
                else
                {
                    Console.WriteLine("Отказ во входе в систему. Неверный логин или пароль");
                }


            }

            private static void Register()
            {
                Console.WriteLine("Введите логин:");
                var login = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                var password = Console.ReadLine();
                Console.WriteLine("Введите пароль повторно:");
                var repassword = Console.ReadLine();

                if (repassword == password)
                {
                    Console.WriteLine("Регистрация прошла успешно");
                }
                else
                {
                    Console.WriteLine("Пароли не совпадают");
                }
            }

            private static void RestoreAccount()
            {
                var savedlogin = "lizza";
                var savedemail = "lizzaboiko@mail.ru";
                Console.WriteLine("Введите логин или email:");
                var loginiliemail = Console.ReadLine();

                if ((savedlogin == loginiliemail) || (savedemail == loginiliemail))
                {
                    Console.WriteLine("письмо для восстановления отправлено");
                }
                else
                {
                    Console.WriteLine("Неверный логин или пароль");
                }
            }

            private static void AdminPanel()
            {
                var savedlogin = "admin";
                var savedpassword = "admin";
                Console.WriteLine("Введите логин:");
                var login = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                var password = Console.ReadLine();

                if ((savedlogin == login) && (savedpassword == password))
                {
                    Console.WriteLine("Вход в систему выполнен успешно");
                }
                else
                {
                    Console.WriteLine("Отказ во входе в систему. Неверный логин или пароль");
                }
            }
        }
    }
}
