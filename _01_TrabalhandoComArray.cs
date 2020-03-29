using System;

namespace ListaBasicoAvancado
{
    public partial class Program
    {
        /*
            *  É importante lembrarmos que o array é um tipo muito básico de coleção do .NET, 
            * então o utilizaremos em casos específicos, como em transferências de arquivos, 
            * manipulação de buffer ou imagens, em arquivos de baixo nível. 
            *  Isso porque normalmente, embora faça parte de várias coleções do .NET,
            * o array não é tão usado quanto outro tipo de coleção (como o List). 
            *  Assim sendo, se for usar um tipo de coleção, 
            * busque sempre ver se é possível optar pela lista no lugar de um array, 
            * pois ela fornece métodos muito mais convenientes do que um simples array
           */

        public static void ManipularArray()
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            /*      [Primeira Forma de declarar Array]
                    string[] aulas = new string[]
                    {
                        aulaIntro,
                        aulaModelando,
                        aulaSets
                    };
            */
            /*      [Segunda Forma de declarar Array]  */

            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Imprimir(aulas);
            Console.WriteLine();
            Console.WriteLine(aulas[0]); // Acessando o Primeiro [Array]
            Console.WriteLine(aulas[aulas.Length - 1]);// Pegando o último [Array]
            Imprimir(aulas);
            Console.WriteLine();

            aulas[0] = "Trabalhando com Array"; // Trocando informação do [Array]
            Imprimir(aulas);


            Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando)); // Retorna o índice do [Array]
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));// Retorna o índice do [Array]
            Console.WriteLine();

            Array.Reverse(aulas); // Revertendo as opções do [Array]
            Imprimir(aulas);
            Console.WriteLine();

            Array.Reverse(aulas); // Revertendo as opções do [Array]
            Imprimir(aulas);
            Console.WriteLine();

            Array.Resize(ref aulas, 2); // Redimensiona o [Array]
            Imprimir(aulas);
            Console.WriteLine();

            Array.Resize(ref aulas, 3); // Redimensiona o [Array]
            Imprimir(aulas);
            Console.WriteLine();

            aulas[aulas.Length - 1] = "Conclusão";

            Array.Sort(aulas); // Ordenando o [Array]
            Imprimir(aulas);
            Console.WriteLine();

            // Copiando o [Array]
            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);
            Console.WriteLine();

            //Clonando o [Array]
            string[] clone = aulas.Clone() as string[];
            Imprimir(copia);
            Console.WriteLine();

            //Limpando o [Array]
            Array.Clear(clone, 1, 2);
            Imprimir(clone);

            Console.ReadKey();
        }
        private static void Imprimir(string[] aulas)
        {
            // Primeira forma de varrer o [Array]
            /*
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
            */

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}

