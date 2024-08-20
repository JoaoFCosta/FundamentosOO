using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Mago : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Olá, eu sou o Mago " + this.Nome + ", tenho: \n" + this.Vida + " Pontos de vida \ninteligência: " + this.Inteligencia + "\nagilidade: " + this.Agilidade + "\nforça: " + this.Forca + "\nMeu nível é: " + this.Nivel);
            Console.WriteLine("=======================================================================");
        }
    }
}
