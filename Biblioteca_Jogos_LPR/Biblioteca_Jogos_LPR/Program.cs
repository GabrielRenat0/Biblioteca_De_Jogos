using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Jogos_LPR.Classes;

namespace Biblioteca_Jogos_LPR
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Jogo> listaJogos = new List<Jogo>();
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                Console.WriteLine("****** Biblioteca De Jogos Renatin ******");
                Console.WriteLine("1 - Adicionar um Jogo");
                Console.WriteLine("2 - Listar os Jogos");
                Console.WriteLine("3 - Atualizar um Jogo");
                Console.WriteLine("4 - Deletar um Jogo");
                Console.Write("Opcao: ");

                bool resultado;
                string opcao = Console.ReadLine();
                switch (opcao)
                {

                   case "1":
                        resultado = AdicionarJogo(listaJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Cadastrado de cria feito :) ");
                        }
                        else
                        {
                            Console.WriteLine("Moio seu cadastro :( ");
                        }
                        break;

                    case "2":
                        resultado = ListarJogos(listaJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Listado de cria :) ");
                        }
                        else
                        {
                            Console.WriteLine("Moio sua listagem :( ");
                        }
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public static bool AdicionarJogo(List<Jogo> listajogos)
        {
            Console.Clear();
            Console.Write("Titulo: ");
            String titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            if (titulo == "") return false;
            if (ano < 1950) return false;

            Jogo novoJogo = new Jogo(titulo, ano, "teste", 1);

            listajogos.Add(novoJogo);
            Console.Beep();

            return true;
        }
        public static bool ListarJogos(List<Jogo> listaJogos)
        {
            foreach (Jogo jogo in listaJogos)
            {
                Console.Write("Titulo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                Console.WriteLine("==========");
                Console.WriteLine("");
            }

            return true;
        }


    }
}
