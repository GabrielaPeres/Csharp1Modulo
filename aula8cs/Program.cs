using aula8cs.src;
using System;

namespace aula8cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("atividade classe");
            Cachorro floquinho = new Cachorro("Floquinho", 5, "azul", "pequeno");

            floquinho.Comer();
        }
    }
}
