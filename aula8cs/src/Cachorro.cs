using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula8cs.src
{
    class Cachorro
    {
        public string Nome { get; set; }
        public int Peso { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }

        public Cachorro(string _nome, int _peso, string _cor, string _tamanho)
        {
            Nome = _nome;
            Peso = _peso;
            Cor = _cor;
            Tamanho = _tamanho;
        }

        public void Comer()
        {
            Console.WriteLine("comendo");
            
        }

        public string Dormir()
        { 
            return "dormindo";
        }
             
    }
}
