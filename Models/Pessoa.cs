using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Pessoa
    {
        // CRIANDO UM CONSTRUTOR, é o mesmo nome da classe, mais não retorna nada , vai receber alguns parametros, pode ser vazio ou um parametro obrigatorio podemos ter mais que um construtor
        public Pessoa(){

        }
        
        public Pessoa(string nome, string sobrenome)
        
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        // qdo criamos get(obter ) e set(atribuir) vazios estamos aceitandq valor passado pra ele, não vai ter nenhuma validação. exemplo quero que o nome tenha valores validos. validando o nome. CRIAMOS UM CAMPO PRIVATE  NOME E ENCAPSULAMOS(PROTEGEMOS DE MODIFICAÇÕES EXTERNAS A NÃO SER QUE ELA PASSE POR UMA VALIDAÇÃO)
        // MODIFICADORES DE ACESSO  PUBLIC E PRIVATE
        // PUBLIC qq um pode acessar a classe
        // PRIVATE acesso restrito  somente a classe pessoa, é validadA antes de ATRIBUIR O valor - ISSO É CHAMADO DE ENCAPSULAMENTO

        // PROPRIEDADADES SOMENTE DE LEITURA - SOMENTE O GET
        

        private string _nome;
        private int _idade;
        public string Nome 
        {
            //  get
            //  {
            //     return _nome.ToUpper();
            //  }
            //  // BODY EXPRESSIONS *** MAIS SUCINTO, sempre que possível faça isso, porem no set não conseguimos pq temos um if 
            get => _nome.ToUpper();

             set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
         }

         public string Sobrenome { get;set;}

        //  CRIANDO UM METODO SO DE LEITURA
         public  string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        //  VALIDANDO A PROPRIEDADE IDADE CRIA O CAMPO DO TIPO IDADE CHAMADO PRIVADO
        public int Idade 
        { 
            get => _idade;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }
                _idade = value;
            }

            }

        public void Apresentar()
        {
            Console.Write($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}