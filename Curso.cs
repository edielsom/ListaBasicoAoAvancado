using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBasicoAvancado
{
    public class Curso
    {
        private List<Aula> aulas;
        private string instrutor;
        private string nome;
        //alunos deve ser um ISet. Alunos deve retornar ReadOnlyCollection
        private ISet<Aluno> alunos = new HashSet<Aluno>();

        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();
        public Curso(string instrutor, string nome)
        {
            this.instrutor = instrutor;
            this.nome = nome;
            this.aulas = new List<Aula>();
        }

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }

        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }

        }

        public int TempoTotal
        {
            get
            {
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                //LINQ = Language Integrated Query
                //Consulta Integrada à Linguagem

                return aulas.Sum(aula => aula.Tempo);
            }
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {
            Aluno aluno = null;
            this.dicionarioAlunos.TryGetValue(numeroMatricula,out aluno);
            return aluno;
        }

        internal Aluno BuscaMatriculaOld(int numeroMatricula)
        {
            foreach (var aluno in alunos)
            {
                if (aluno.NumeroMatricula == numeroMatricula)
                    return aluno;
            }
            throw new Exception("Matrícula não encontrada: " + numeroMatricula);
        }

        internal void SubstituiAluno(Aluno aluno)
        {
            this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
        }
    }
}
