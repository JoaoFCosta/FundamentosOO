using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        public virtual void apresentarSe() { }

        public virtual int atacar()
        {
            int pontosAtaque = 0;
            pontosAtaque = (this.Inteligencia + (this.Forca * 2) + this.Agilidade + this.Nivel) / 2;
            return pontosAtaque;
        }

        public virtual int defender()
        {
            int pontosDefesa = 0;
            pontosDefesa = (this.Inteligencia + this.Forca + (this.Agilidade * 2) + this.Nivel + this.Vida) / 2;
            return pontosDefesa;
        }
        public virtual void evoluir()
        {
            this.Nivel++;
            this.Forca += 10;
            this.Inteligencia += 10;
            this.Agilidade += 10;
            Console.WriteLine("O Jogador " + this.Nome + " evoluiu para o nível " + this.Nivel + ". Seus novos valores são: \nAgilidade: " + this.Agilidade + "\nInteligência: " + this.Inteligencia + "\nForça: " + this.Forca);
        }

        public virtual void batalhar(Personagem p)
        {

            bool vencedor = false;
            while (vencedor == false)
            {
                int valorAtaque = this.atacar();
                int valorDefesaInimigo = p.defender();
                int danoDeVida = valorAtaque - valorDefesaInimigo;
                danoDeVida = Math.Max(danoDeVida, 10);
                p.Vida -= danoDeVida;
                Console.WriteLine("Dano na Vida do Inimigo em " + danoDeVida);
                Console.WriteLine("O nível de vida do Inimigo agora é " + p.Vida);

                if (p.Vida <= 0)
                {
                    Console.WriteLine(this.Nome + " venceu a batalha!");
                    Console.WriteLine("=======================================================================");
                    vencedor = true;
                    this.evoluir();
                    break;
                }

                int valorAtaqueInimigo = p.atacar();
                int valorDefesa = this.defender();
                danoDeVida = valorAtaqueInimigo - valorDefesa;
                danoDeVida = Math.Max(danoDeVida, 10);
                this.Vida -= danoDeVida;
                Console.WriteLine("Dano na Vida do Atacante em " + danoDeVida);
                Console.WriteLine("O nível de vida do Atacante agora é " + this.Vida);

                if (this.Vida <= 0)
                {
                    Console.WriteLine(p.Nome + " venceu a batalha!");
                    Console.WriteLine("=======================================================================");
                    vencedor = true;
                    p.evoluir();
                    break;
                }
            }
        }
    }
}
