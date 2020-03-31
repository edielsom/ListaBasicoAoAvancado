using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaBasicoAvancado
{
    public static partial class Program
    {
        public static void TrabalhandoComListaDicionary()
        {
            // vamos declarar o curso
            Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");
            //... e adicionar 3 aulas a esse curso
            //Trabalhando com Listas - 21 minutos;
            //Criando uma Aula - 20 minutos;
            //Modelando com Coleções - 24 minutos
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            //um aluno também tem matrícula!
            //vamos criar a classe Aluno com Nome e NumeroMatricula

            //Instanciando 3 alunos com suas matrículas:
            //Vanessa Tonini - 34672
            //Ana Losnak - 5617
            //Rafael Nercessian - 17645
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            //Precisamos matricular os alunos no curso, criando um método
            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            //imprimindo os alunos matriculados
            Console.WriteLine("Imprimindo os alunos matriculados");
            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }
            // imprimir: "O aluno a1 está matriculado?"
            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");

            //Criar um método EstaMatriculado
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            //vamos instanciar uma aluna (Vanessa Tonini)
            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            //e verificar se Tonini está matriculada
            Console.WriteLine("Tonini está matriculada? " + csharpColecoes.EstaMatriculado(tonini));

            //mas a1 == a Tonini?
            Console.WriteLine("a1 == a Tonini?");
            Console.WriteLine(a1 == tonini);


            //o que ocorreu? a1 é equals a Tonini?
            Console.WriteLine("a1 é equals a Tonini?");
            Console.WriteLine(a1.Equals(tonini));

            //limpando o console
            Console.Clear();

            //já temos método para saber se o aluno está matriculado.
            //mas agora precisamos buscar aluno por número de matrícula

            //pergunta: "Quem é o aluno com matrícula 5617?"
            Console.WriteLine("Quem é o aluno com matrícula 5617?");

            //implementando Curso.BuscaMatriculado
            Aluno Aluno5617 = csharpColecoes.BuscaMatriculado(5617);
            Console.WriteLine(Aluno5617);
            //quem é o aluno 5618?
            Console.WriteLine("Quem é o aluno 5618?");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(5618));

            Console.Clear();


            //e se quisermos trocar o aluno que tem a mesma chave?
            Aluno fabio = new Aluno("Fabio Gushiken", 5617);
            csharpColecoes.SubstituiAluno(fabio);

            //pergunta: "Quem é o Aluno 5617 agora?"
            Console.WriteLine("Quem é o Aluno 5617 agora?");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(5617));


        }
    }
}
