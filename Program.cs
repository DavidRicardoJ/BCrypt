using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BCrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.Write("Nome: ");
            user.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Email: ");
            user.Email = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Senha: ");
            user.Senha = Console.ReadLine();

            Console.WriteLine();
            user.Senha = Crypto.HashPassword(user.Senha);
            Console.WriteLine($"Nome: {user.Nome}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine($"Senha: {user.Senha}");

            Console.WriteLine();
            Console.Write("Digite sua senha novamente: ");
            var senha = Console.ReadLine();
            Console.WriteLine();
            if (Crypto.ValidatePassword(senha, user.Senha))
            {
                Console.WriteLine("As senhas são iguais.");
            }
            else
            {
                Console.WriteLine("As senhas são diferentes.");
            }

            Console.ReadKey();
        }
    }
}
