using FundamentosOO;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //Livro livro1 = new Livro();
        //livro1.Titulo = "Maus";
        //livro1.Editora = "Art Spiegelman";
        //livro1.Autor = "Spiegelman";
        //livro1.AnoLancamento = 2018;

        //Livro livro2 = new Livro();
        //livro2.Titulo = "Harry Potter";
        //livro2.Editora = "Editora Abril";
        //livro2.Autor = "J.K.H.";
        //livro2.AnoLancamento = 2001;

        //Livro livro3 = new Livro();
        //livro3.Titulo = "Programando em C#";
        //livro3.Editora = "Editora Nova";
        //livro3.Autor = "Gustavo Castello";
        //livro3.AnoLancamento = 1982;

        ////Instanciar um obejto do Tipo Aluno
        //Aluno aluno1 = new Aluno();
        ////Preencher os atributos do Objeto
        //aluno1.Nome = "Cristiano de Paula";
        //aluno1.RM = "1234TI";
        //aluno1.Email = "cristiano.paula@sp.senai.br";
        //aluno1.Nascimento = new DateOnly(1981, 07, 16);

        //Aluno aluno2 = new Aluno();

        //aluno2.Nome = "João Rodolfo F. da Costa";
        //aluno2.RM = "4429TI";
        //aluno2.Email = "joao.r.costa7@aluno.senai.br";
        //aluno2.Nascimento = new DateOnly(2008, 05, 16);

        //Aluno aluno3 = new Aluno();

        //aluno3.Nome = "José da Silva";
        //aluno3.RM = "4321TI";
        //aluno3.Email = "jose.silva@sp.senai.br";
        //aluno3.Nascimento = new DateOnly(2000, 12, 07);

        ////Imprimir na Tela
        //Console.WriteLine("Aluno 1");
        //Console.WriteLine("Nome: " + aluno1.Nome);
        //Console.WriteLine("RM: " + aluno1.RM);
        //Console.WriteLine("Email: " + aluno1.Email);
        //Console.WriteLine("Data de nascimento: " + aluno1.Nascimento);
        //Console.WriteLine("========================================================");

        //Console.WriteLine("Aluno 2");
        //Console.WriteLine("Nome: " + aluno2.Nome);
        //Console.WriteLine("RM: " + aluno2.RM);
        //Console.WriteLine("Email: " + aluno2.Email);
        //Console.WriteLine("Data de nascimento: " + aluno2.Nascimento);
        //Console.WriteLine("========================================================");

        //Console.WriteLine("Aluno 3");
        //Console.WriteLine("Nome: " + aluno3.Nome);
        //Console.WriteLine("RM: " + aluno3.RM);
        //Console.WriteLine("Email: " + aluno3.Email);
        //Console.WriteLine("Data de nascimento: " + aluno3.Nascimento);
        //Console.WriteLine("========================================================");

        ////Instanciar um Objeto do Tipo Produto

        //Produto p1 = new Produto();
        //p1.Codigo = 123456;
        //p1.Nome = "Coca-Cola 3L";
        //p1.Preco = 12.99;
        //p1.Estoque = 96;

        ////Chamar o metodo QuantidadeEstoque
        //p1.QuantidadeEstoque();

        //p1.Estoque = 85;
        //p1.QuantidadeEstoque();

        //Console.WriteLine("========================================================");
        //Console.WriteLine();

        ////Instanciar um Objeto do Tipo Carro

        //Carro carro1 = new Carro();
        //carro1.Marca = "Ferrari";
        //carro1.Modelo = "488";
        //carro1.Velocidade = 80;

        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Desacelerar();


        //Console.WriteLine("========================================================");
        //Console.WriteLine();


        //Pessoa pessoa1 = new Pessoa();
        //pessoa1.Nome = "Joãozinho";
        //pessoa1.Idade = 57;

        //pessoa1.Envelhecer(5);

        //Console.WriteLine("========================================================");
        //Console.WriteLine();

        //Funcionario func1 = new Funcionario();
        //func1.Nome = "Luizinho";
        //func1.Idade = 20;
        //func1.Cargo = "Aprendiz";
        //func1.Salario = 1400;

        //func1.ApresentarSe();

        //Console.WriteLine("===================================================");

        //Console.WriteLine(" ");
        //Instanciando um objeto Animal
        //Animal animal1 = new Animal();

        ////Preencher os atributos do Animal
        //animal1.Especie = "Cachorro";

        ////Chamando o Método do Objeto
        //animal1.emitirSom();

        ////Imprimindo a informação na tela
        //Console.WriteLine("O Animal " + animal1.Especie + " emitiu um som");

        //Instanciando um objeto da classe animal subclasse gato

        //Gato gato1 = new Gato();
        //gato1.Nome = "Sophia";
        //Console.WriteLine(gato1.Nome + " disse:");
        //gato1.emitirsom();

        //Gato gato2 = new Gato();
        //gato2.Nome = "Renatão";
        //gato2.Especie = "Persa";
        //Console.WriteLine(gato2.Nome + " da raça, " + gato2.Especie + " faz:");
        //gato2.emitirsom();

        //Porco porco1 = new Porco();
        //porco1.Nome = "Rodolfo";
        //porco1.Especie = "American Yorkshire";
        //Console.WriteLine(porco1.Nome + " da raça, " + porco1.Especie + " faz:");
        //porco1.emitirsom();

        //Galinha galinha1 = new Galinha();
        //galinha1.Nome = "Helena";
        //galinha1.Especie = "Caipira";
        //Console.WriteLine(galinha1.Nome + " da raça, " + galinha1.Especie + " faz:");
        //galinha1.emitirsom();

        Mago mago1 = new Mago();
        mago1.Nome = "Jeferson";
        mago1.Categoria = "Mago";
        mago1.Nivel = 6;
        mago1.Forca = 70;
        mago1.Agilidade = 40;
        mago1.Inteligencia = 90;
        mago1.Vida = 50;


        Elfo elfo1 = new Elfo();
        elfo1.Nome = "Pequenelson";
        elfo1.Categoria = "Elfo";
        elfo1.Nivel = 5;
        elfo1.Forca = 50;
        elfo1.Agilidade = 80;
        elfo1.Inteligencia = 60;
        elfo1.Vida = 40;


        Cavaleiro cavaleiro1 = new Cavaleiro();
        cavaleiro1.Nome = "Pegevision";
        cavaleiro1.Categoria = "Cavaleiro";
        cavaleiro1.Nivel = 7;
        cavaleiro1.Forca = 90;
        cavaleiro1.Agilidade = 50;
        cavaleiro1.Inteligencia = 60;
        cavaleiro1.Vida = 80;

        mago1.apresentarSe();
        elfo1.apresentarSe();
        cavaleiro1.apresentarSe();

        cavaleiro1.batalhar(elfo1);
        Console.WriteLine("======================================");
        cavaleiro1.Evoluir();
        Console.WriteLine("======================================");
        cavaleiro1.batalhar(mago1);
        Console.WriteLine("======================================");
        cavaleiro1.Evoluir();
    }
}