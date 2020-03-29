using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaBasicoAvancado
{
    public static partial class Program
    {
        public static void TrabalhandoComLista()
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //Cria uma lista implicita.
            List<string> aulas = new List<string>
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };
            Imprimir(aulas);
            Console.WriteLine();

            //Cria uma lista explicita
            List<string> aulas2 = new List<string>();
            aulas2.Add(aulaIntro);
            aulas2.Add(aulaModelando);
            aulas2.Add(aulaSets);
            Imprimir(aulas2);

            Console.WriteLine();

            //Obtêm o primeiro e o útimo item da lista
           // GetPrimeiroUltimoRegistroDaLista(aulas);

            //Manipulando Lista com First e Last
           // ManipularLista(aulas);


            //Manipulando Lista com Remover, Clonar, Ordenar e Reverter uma lista.
            ManipularLista_2(aulas);
        }

        private static void ManipularLista_2(List<string> aulas)
        {
            Console.WriteLine("Reverter uma lista");
            //Retorna a listar de forma reversa.
            aulas.Reverse();
            Imprimir(aulas);
            Console.WriteLine();

            Console.WriteLine("Remover um registro de uma determinado índice");
            //Remove um registro de uma determinada posição;
            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);
            Console.WriteLine();

            Console.WriteLine("Adicionando uma novo registro dentro da lista");
            //Adiciona um novo registro na lista.
            aulas.Add("Conclusão");
            Imprimir(aulas);
            Console.WriteLine();

            Console.WriteLine("Ordenando uma lista.");
            //Ordena os resgitros da lista.
            aulas.Sort();
            Imprimir(aulas);
            Console.WriteLine();

            Console.WriteLine("Copiando uma lista através de uma determinada faixa.");
            //Copia os registro de uma lista para outra através de uma faixa.
            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);
            Console.WriteLine();

            Console.WriteLine("Clonando uma lista");
            //Clona uma lista.
            List<string> clone = new List<string>(aulas);
            Imprimir(clone);
            Console.WriteLine();

            Console.WriteLine("Remove os itens de uma lista através de uma determinada faixa");
            //Remove registro de uma determinada faixa.
            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);

        }

        private static void ManipularLista(List<string> aulas)
        {
            //Obtêm o primeiro registro que contenha a palavra [Trabalhando].
            //Obs: Ao pesquisar e não encontrar o registro, será lançada uma exceção, muito cuidado!
            Console.WriteLine("A primeira aula 'Trabalhando' é:" + aulas.First(aula => aula.Contains("Trabalhando")));
            Console.WriteLine("A última aula 'Trabalhando' é:" + aulas.Last(aula => aula.Contains("Trabalhando")));

            //O método [FirstOrDefault] serve para fazer uma operação e caso não encontre o registro ele retorno um valor padrão 
            Console.WriteLine("A primeira aula 'Conclusão' é:" + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));
        }
        private static void GetPrimeiroUltimoRegistroDaLista(List<string> aulas)
        {
            Console.WriteLine("A primeira aula é " + aulas[0]);
            Console.WriteLine("A última aula é " + aulas[aulas.Count - 1]);

            Console.WriteLine();

            //Obtêm o último item da lista
            Console.WriteLine("A primeira aula é " + aulas.First());
            Console.WriteLine("A última aula é " + aulas.Last());
        }

        private static void Imprimir(List<string> aulas)
        {
            /*
            Console.WriteLine("Primeiro tipo de percorrer uma lista");
            //Percorrer uma lista - 1
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
            Console.WriteLine();

            Console.WriteLine("Segundo tipo de percorrer uma lista");
            //Percorrer uma lista - 2
            for (int i = 0; i < aulas.Count; i++)
            {
                Console.WriteLine(aulas[i]);
            }
            Console.WriteLine();

    */
            //Console.WriteLine("Terceiro tipo de percorrer uma lista");
            //Percorrer uma lista - 3 através de uma expressão Lambda.
            aulas.ForEach(aula => { Console.WriteLine(aula); });
        }
    }
}
