using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaBasicoAvancado
{
    public static partial class Program
    {
        public static void TrabalhandoComConjuntos()
        {
            //Declarando set de alunos.

            ISet<string> alunos = new HashSet<string>();

            //Adicionando: Vanessa, Ana e Rafael.
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            //Imprimindo.
            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(",",alunos));

            //adicionando: priscila, rollo, fabio
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            //remover ana, adicionando marcelo
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            //imprimindo de novo
            Console.WriteLine(string.Join(",", alunos));

            //adicionando gushiken de novo
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(",", alunos));

            //ordenando: sort
            //alunos.Sort();
            //copiando: alunosEmLista
            List<string> alunosEmLista = new List<string>(alunos);
            //ordenando cópia
            alunosEmLista.Sort();
            //imprimindo cópia
            Console.WriteLine(string.Join(",", alunosEmLista));
        }
    }
}
