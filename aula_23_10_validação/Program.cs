using System;

namespace aula_23_10_validação
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa jogador = new Pessoa();
            jogador.Nome = "Rogerio Ceni";
            Console.WriteLine(jogador.Nome);

            Idolo idolo = new Idolo();
            idolo.idolo = "Rogerio Ceni";
            Console.WriteLine(idolo.idolo);

            Tecnico tecnico = new Tecnico();
            tecnico.tecnico = "Rogerio Ceni";
            Console.WriteLine(tecnico.tecnico);
        }
    }
}
