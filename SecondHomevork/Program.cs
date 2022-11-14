using System;

namespace SecondHomevork
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string secondName, int age, string[] petnames, string[] favColours) user;
            user = UserInfo();

        }

        public static (string name, string secondName, int age, string[] petnames, string[] favColours) UserInfo()
        {
            Console.WriteLine("Введите имя");
            
        }
    }
}
