using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senha_fixa {
    class Program {
        static void Main(string[] args) {

            int numero, senha;

            Console.Write("Digite a senha: ");
            numero = int.Parse(Console.ReadLine());

            senha = 2002;

            while (numero != senha) {
                Console.Write("Senha invalida. Tente novamente: ");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido.");
        }
    }
}
