using System;

namespace lista_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float peso;
            float altura;
            float imc;

            Console.WriteLine("ESCREVA SEU NOME: ");
            nome = Console.ReadLine();

            Console.WriteLine("ESCREVA SUA IDADE: ");
            idade =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ESCREVA SEU PESO: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("ESCREVA SUA ALTURA:");
            altura = float.Parse(Console.ReadLine());

            imc = peso /(altura * altura);

            Console.WriteLine(nome + "seu imc é :" + imc);






        }
    }
}