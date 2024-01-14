using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Curso
    {
        public String Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        // assinatura de um metodo, o public nao faz parte posso ate apagar
        // tipo de seções do metodo, nesse caso é void (vazio) e não retorna nada , aqui não retorna pq estamos adicionando um aluno /\Nome do método podemos colocar o nome que quiser : AdicionarAluno(importante ter sentido, usar as boas práticas)  entre () estamos chamando os parametros/argumentos(classe Pessoa chamado aluno (listPessoa)) aó vai aceitar o tipo passado no caso aqui String
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        // tipos de retornos criando metodo para saber a qtde de alunos matriculados (uso o int e ele automaticamente pede um retorno e temos que usar o return. Significa que chegou ao final do metodo e esta retornando ele tem que retornar o mesmo tipo informado, no caso aqui um inteiro
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        
        // ---- Implementando o método remover aluno o remove retorna um boleano

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
            
        }

        // -----Implementando metodo LISTAR

    // refatorar lista alunos   para ter o numero relativo ao aluno não posso usar o foreach, tenho que unhar o for porém ele le o primeiro numero como 0 como se fosse um array , lembrando que o int count é transformado em string antes do retorno no console
    // AJUSTANDO A NUMERAÇÃO - saida com 0 para saida com 1 como primeiro o count começa com 0 mais para que exiba com 1 . recomendado count = 0 e no momento de exibir no console com count +1

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            for(int count = 0; count < Alunos.Count; count++)
            {
                // concatenção de string
                // string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                // Console.WriteLine(texto);
                // ********************************************
                // interpolação de string sintase  $"" {VALOR} - {}
                // $(significa interpolação  dentro das {}é a propriedade)
                // PREFERIVEL USAR INTERPOLAÇÃO
                string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
            // foreach(Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }
    }
}