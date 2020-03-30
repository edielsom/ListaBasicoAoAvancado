using System;
using System.Collections.Generic;

namespace ListaBasicoAvancado
{
    public static partial class Program
    {
        public static void ManipulandoListaOrdenar2()
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            Imprimir_2(csharpColecoes.Aulas);

            //adicionar 2 aulas
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));

            //imprimir
            Imprimir_2(csharpColecoes.Aulas);

            //ordenar a lista de aulas
            //csharpColecoes.Aulas.Sort();

            //copiar a lista para outra lista
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            //ordenar a cópia
            aulasCopiadas.Sort();

            Imprimir(aulasCopiadas);

            //totalizar o tempo do curso
            Console.WriteLine(csharpColecoes.TempoTotal);


            Console.WriteLine(csharpColecoes);
        }

        private static void Imprimir_2(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}