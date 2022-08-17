using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Jogos_LPR.Classes
{
    internal class Jogo
    {
        private string titulo;
        private string genero;
        private int ano;
        private int maxJogadores;
        private int notaMetaCritic;

        public Jogo( string titulo, string genero, int ano, int maxJogadores, int notaMetaCritic)
            {
            this.titulo = titulo;
            this.genero = genero;
            this.ano = ano;
            this.maxJogadores = maxJogadores;
            this.notaMetaCritic = notaMetaCritic;
            }
        public Jogo(String titulo, int ano, String genero, int maxJogadores)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.ano = ano;
            this.maxJogadores = maxJogadores;
        }


        public void setTitulo(string titulo)
        {
            if(titulo != "")
            this.titulo = titulo;
        }
        public void setGenero(string genero)
        {
            this.genero = genero;
        }
        public void setAno(int ano)
        {
            this.ano = ano;
        }
        public void setMaxJogadores(int maxJogadores)
        {
            this.maxJogadores = maxJogadores;
        }
        public void setNotaMetaCritic (int notaMetaCritic)
        {
            this.notaMetaCritic = notaMetaCritic;
        }


        public string getTitulo()
        {
            return this.titulo;
        }
        public int getAno()
        {
            return this.ano;
        }
    }
}