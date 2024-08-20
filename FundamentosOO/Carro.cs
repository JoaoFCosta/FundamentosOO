using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Carro
    {
        //Atributos
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }

        //Metodos
        public void Acelerar()
        {
            this.Velocidade += 5;
            Console.WriteLine("A velocidade atual é: " + this.Velocidade + "Km/h");
        }

        public void Desacelerar()
        {
            this.Velocidade -= 5;
            if (this.Velocidade <= 0)
            {
                Console.WriteLine("O carro parou");
            }
            else
            {
                Console.WriteLine("A velocidade atual é: " + this.Velocidade + "Km/h");
            }
        }
    }
}

