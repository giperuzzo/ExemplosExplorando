// See https://aka.ms/new-console-template for more information
// (Leonardo Buta) 
// EXPLORANDO A LINGUAGEM C# - INTRODUÇÃO AO MÓDULO 
// Objetivo Geral : Explorar a linguagem C#, apresentando diferentes possibilidades e capacidades d linguagem, bem como nos aprofudarmos mais sobre suas características.
// Módulos de Fundamentos e Algoritmos e lógica de programção básico para dar continuidade a essa fase.

// *****ETAPA 1 PROPRIEDADES, MÉTODOS E CONSTRUTORES
// conceitos essenciais
// -----INTRODUÇÃO A PROPRIEDADES-----
// Uma propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular. Qdo modelamos uma classe(exemplo pessoa), abstraimos um objeto fo mundo real e passamos para o codigo.Qdo modelamos uma classe de inicio não nos preocupados com os numeros, exemplo, nome, idade, tamanho e etc sim como vamos representar aquela propriedade. as informações são os atributos idade=30 e podemos encapsular a informação a ser informada.não aceitando vazio, gerando um bloqueio.
// validação pode ser tanto em método como em propriedade 
// Nesse exemplo criamos a classe pessoa que recebe um nome que é uma srtring e limitamos a 20 caracteres, assim tambem com a idade que é um int e não será permitido numeros negativos e então é negado a operação
// Pessoa
// Nome: String
// apresentar()
// Agora no código, propriedades na prática 
// para criar um novo projeto depois de criar uma pasta no terminal damos seguite comando {****dotnet new console***}
// criamos a pasta models e começamos criar as propriedades
// para criar um propriedade iniciamos com prop tab e fazemos as alterações necessárias
// criando um método = uma ação Apresentar
// importar new space
// get, obter o valor debaixo dos panos  set atribuindo o valor
// # entre campo e propriedade, o campo ele só armazena a propriedade tem get e set ou apenas um dos dois
using ExemplosExplorando.Models;
using Microsoft.VisualBasic;


// instanciando a classe Pessoa
// atribuindo valores validos 
// Pessoa p1 = new Pessoa();
// p1.Nome = "Leonardo";
// p1.Sobrenome = "Buta";
// p1.Idade = 20;
// p1.Apresentar();

//------INTRODUÇÃO Á MÉTODOS
// Um métdo é um bloco de código que contém uma série de instruções
// Exemplo: classe CALCULADORA  métodO SOMAR porém ele recebe dois numeros e executa a ação......possibilita aproveitar o código, use um metodo e reaproveite o codigo
// classe pessoa
// ´propriedades  nome, idade,
// metodos apresentar
// outro exemplo   classe curso / propriedade nome e alunos;list<Pessoas / metodos adicionar,remover,listar,obteralunos etc nesse caso o alunos estende a classe pessoa(que ja tem suas propriedades e seus métodos)

// --Implementando a classe curso---------------------

// Pessoa p1 = new Pessoa();
// p1.Nome = "Leonardo";
// p1.Sobrenome = "Buta";

// Pessoa p2 = new Pessoa();
// p2.Nome = "Eduardo";
// p2.Sobrenome = "Neves Queiroz";

// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

//  -------CONSTRUTORES ---------
// Os construtores permitem que o programador defina valores padrão, limite a instanciação e grave códigos flexívei e fáceis de ler.
// instacia uma classe e coloca um valor padrão numa unica linha - vejamos na pratica

// Pessoa p1 = new Pessoa(nome:"Leonardo", sobrenome:"Buta");
// Pessoa p2 = new Pessoa(nome:"Eduardo", sobrenome:"Neves Queiroz");


// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


// Implementando o construtor 
// Define no construtor o valor padrão
// nomear seus parametros para passar os valores padrao

//  Finalização, conceitos importantes para usar o tempo todo em C#
// ***************************************************************************

// *****ETAPA 2 MANIPULANDO VALORES
// ----------------Concatenação de Strings
// Podemos formatar valores em diversas representações. Essa formatação de valores é conhecida por concatenação ou interpolação.(juntas dois textos pra dar mais sentido) . Concatenação de String 
// concatenção de string
// string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
// Console.WriteLine(texto);
// ********************************************
// interpolação de string sintase  $"" {VALOR} - {}
// $(significa interpolação  dentro das {}é a propriedade)
// PREFERIVEL USAR INTERPOLAÇÃO

// ----------------Concatenação de valores
// no exemplo abaixo ele esta somente unindo as string, e não fazendo a soma precisa se variaveis do tipo int
// string numero1 = "10";
// string numero2 = "20";
// string resultado = numero1 + numero2;

// mais se caso vc declarar uma string e um inteiro acontece o casting implicito e converte o tipo inteiro em string
// concatenação com tipos inteiros, terá o resultado da adição
// int numero1 = 10;
// int numero2 = 20;
// int resultado = numero1 + numero2;

// Console.WriteLine(resultado);

// -----Formatando valores monetários de forma dinâmica------------(valor decimal colocar M no final)

// decimal valorMonetario = 1582.40M;
// para saber a moeda podemos usar a interpolação de string para representar o valor impresso no console no caso abaixo o :C significa que quero mostrar o valor de uma moeda(vai colocar o R$ dar espaço e colocar a virgula) significa que está no brasil ou entao de onde sua configuração esteja informando.
// Console.WriteLine($"{valorMonetario:C}");

// -----------Alterando a localização do código- especifico para uma localização 
// import DO System.Globalization  e use a cultura do sistema
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
using System.Globalization;
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// decimal valorMonetario = 1582.40M;
// nesse caso usando o :C 
// Console.WriteLine($"{valorMonetario:C}");


// --- Alterando a localização da cultura direto no console pode usar if informando qual a cultura do usuario do programa---


// Console.WriteLine($"{valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US"))}");

// ----Formatação personalizada Não preciso formatar em uma cultura específica exemplo C1, significa as casas decimais, C2 duas casas decimais, assim sucessivamente, podemos trocar esse C por N porem ele não vai exibir o simbola da moeda------------------------

// Console.WriteLine($"{valorMonetario.ToString("C")}");

// ----------------  Representando porcetagem/

// double porcetagem = .3421;
// Console.WriteLine(porcetagem.ToString("p"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// ------Formatando DATETIME-----------------
// Sintaxe de implementação de DAteTime    ( DateTime data = DateTime.Now)

// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// ------Formatando data e hora-------
// veremos abaixo como representar somente data ou somente hora
// abaixo mostrando so a data
// Console.WriteLine(data.ToShortDateString());
// // abaixo mostrando so as horas
// Console.WriteLine(data.ToShortTimeString());

// convertendo datas, nem sempre teremos datas padrão  convertendo uma string para o DateTime usando o Parse mais ele pode dar um erro e encerrar o programa

// DateTime data = DateTime.Parse("13/01/2024 15:28");
// Console.WriteLine(data);

// -----Formatando data e hora usaremos o TryParse

// string dataString = "2024-01-13 16:10";
// DateTime.TryParseExact(dataString,
// "yyyy-MM-dd HH:mm",
// CultureInfo.InvariantCulture,
// DateTimeStyles.None, out DateTime data);

// Console.WriteLine(data);

// ---Validando o retorno do TryParse com if se ele conseguiu ou não converter

// string dataString = "2024-12-17 16:10";
// bool sucesso = DateTime.TryParseExact(dataString,
// "yyyy-MM-dd HH:mm",
// CultureInfo.InvariantCulture,
// DateTimeStyles.None, out DateTime data);
// if(sucesso)
// {
//     Console.WriteLine("Conversão com sucesso!! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

// -----fim da nossa etapa ------------------------------------


// *****ETAPA 3 EXCEÇÕES E COLEÇÕES

// -Exceções ou exception: Os recursos de manipulação de exceção da linguagem C# ajudam voc~e a lidar com quaisquer situações eccepcionais ou inesperadas que ocorram quando um programa for executado. (Foge do seu controle)
// Realizando a leitura de um arquivo criar uma nova pasta e depois um arquivo de texto

// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
// foreach(string linha in linhas)
// {
// Console.WriteLine(linha);

// }

// ------Disparando uma exceção----------------
// Simulando um erro para tratar a exceção, retornou conforme abaixo
// Unhandled exception. System.IO.FileNotFoundException: Could not find file 'C:\dio_avanade\ExemplosExplorando\Arquivos\arquivLeitura.txt'.
// File name: 'C:\dio_avanade\ExemplosExplorando\Arquivos\arquivLeitura.txt'
//    at Microsoft.Win32.SafeHandles.SafeFileHandle.CreateFile(String fullPath, FileMode mode, FileAccess access, FileShare share, FileOptions options)
//    at Microsoft.Win32.SafeHandles.SafeFileHandle.Open(String fullPath, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize, Nullable`1 unixCreateMode)    
//    at System.IO.Strategies.OSFileStreamStrategy..ctor(String path, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize, Nullable`1 unixCreateMode)        
//    at System.IO.Strategies.FileStreamHelpers.ChooseStrategyCore(String path, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize, Nullable`1 unixCreateMode)
//    at System.IO.StreamReader.ValidateArgsAndOpenPath(String path, Encoding encoding, Int32 bufferSize)
//    at System.IO.File.ReadAllLines(String path, Encoding encoding)
//    at Program.<Main>$(String[] args) in C:\dio_avanade\ExemplosExplorando\Program.cs:line 220

// tentou fazer não conseguiu e encerrou e deu detalhes de como tentou fazer antsde encerrar e deu algumas pistas do que pode ter acontecido, mostrano inclusive onde ouve a quebra do problema, no caso aqui a linha do caminho do arquivo a ser lido.. Outros tipos de exceção por array inexistente, acesso a arquivos corrompidos, a arquivos sem autorização de acesso a seguir veremos como tratar essa exceção


// string[] linhas = File.ReadAllLines("Arquivos/arquivLeitura.txt");
// foreach(string linha in linhas)
// {
// Console.WriteLine(linha);

//    }

// ------tratando uma exceção------------------
// Como podemos prever ue o arquivo pode dar erro, é aí que entra o try catchou ao menos não encerrar o programa
// o try executa mais com uma cautela.
// try
// {
// string[] linhas = File.ReadAllLines("Arquivos/arquivLeitura.txt");
// foreach(string linha in linhas)
// {
// Console.WriteLine(linha);

//    }
//    catch significa pegar/obter a responsabilidade que o try nao conseguiu ler, no caso qdo acontecer uma exceção ele le do ponto onde o try informou e no console ele retorna a linha onde começõu o erro
// }catch(Exception ex)
//  {
// Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally 
// {
//     Console.WriteLine("Chegou até aqui!");
// }


// ele retornou a exceção mais foi bem especifico  /(Ocorreu uma exceção genérica. Could not find file 'C:\dio_avanade\ExemplosExplorando\Arquivos\arquivLeitura.txt'.) e ele para onde aconteceu a quebra do programa

// ------Exceção Genérica e específica-------
// O que é uma exceção generica - é um erro geral mostrando somente a linha
//  O ue é uma exceção mais especifica - por exemplo quando posiciono o mouse sobre o metodo nesse caso o ReadAllLine são exceções que já são dadas como dica do método e posso fazer qtos catch eu quiser informando todos os possiveis erros retornando mensagem que o erro foi ex: ArgumentException, ArgumentNullException .......

// -------Entendendo o bloco Finally usamos em conjunto com o try catch vem logo após o catch, ele serve para finalmente como o próprio nome diz finalizar com aquela instrução, ou então faça, ele executa a instrução, independente de ter sido ou não executado o código. exemplo acima. encerra a conexão ou envia um aviso a alguem entre outras funções de finaizar

// ------Usando o Throw - exceção para ser pega por um outro bloco de programa criamos uma nova classe exceção e criamos metodos e transformamos em cascata, colocando o throw no metodo4, ele foi chamando de bloco em bloco em retornou uma exceção throw, significa joga de volta, para pegar no catch se não tiver o bloo catch e se não tiver o catch e ninguem tratou a exceção dele ele encerra o programa criando uma rastreabilidade caso ele encontra o catch ele trata a exceção e retorna com sucesso
// new ExemploExcecao().Metodo1();


// ----Introdução a filas ou Coleções, array ou listas= igual uma coleçãp do mesmo tipo, ex inteiro string, exemplo QUEue(Fila) segue realmente uma ordem de fila, a primeira pessoa da fila vai ser atendida primeiro e quem chegar vai pra ultima posição, nada de furar fila. Veremos a seguir como adicionar uma posição na fila. o primeiro que entrar é o primeiro a sair =FIFO. 

// -----Fila na prática - implementando filas no C#  sintaxe Queue<tipo> file = new Queue<int>(); Enqueue no fim da fila

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
// // removendo elemento da fila ele sempre vai remover o primeiro elemento, por isso o metodo esta vazio
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);
// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// -------Coleções do tipo Pilha/Stack - , ele obdece algumas regras para inserção e exclusão do seu elemento e ao contrário de listas ele seRA LIFO= ocupar a primeira posição na pilha, mais na remoção ele será o ultimo que entrou vai ser o primeiro a sair . tiramos do topo para base

// --------Introdução á pilhas- como representar uma pilha no C# sintaxe  Stack<tipo> pilha = new Stack<int>(); para adicionar usaremos o metodo push ex  pilha.push e para remover o pilha.Pop a a remoção se dara na ordem do topo pra base e a inclusão tb ocupara o lugar do topo

// Stack<int> pilha = new Stack<int>();
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// ------Introdução Dictionary = Um dictionary é uma coleção de chave-valor para armazenar valores únicos sem uma ordem específica. (Ele serve pra qdo vc tem uma chave composta e vc precisa que esse elemento seja unico, caso não for unico ele vai grar uma exceção para vc.)  sintaxe Dictionary<dois tipos > estados = tipo 1 e tipo 2  rimeira posição é a chave, ela pode ser inteiro string , e o segundo elemento é o  valor que eu quero armazenar 

// Dictionary<string, string> estados = new Dictionary<string, string>();
// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");
// // percorrendo o dictionary , o elemento que representa ele é o keyvaluePair ou pela palavra var
// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");

// garante que os valores sejam unicos, no exemplo abaixo vamos tentar cadasstrar um valor já existente ele retornou os ja cadastrados e a nova adição ele gerou uma exceção informando que já existe a chave já existe
// estados.Add("BA", "Bahia");
// Chave: SP, Valor: São Paulo
// Chave: BA, Valor: Bahia
// Chave: MG, Valor: Minas Gerais
// Unhandled exception. System.ArgumentException: An item with the same key has already been added. Key: BA
//    at System.Collections.Generic.Dictionary`2.TryInsert(TKey key, TValue value, InsertionBehavior behavior)
//    at System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)
//    at Program.<Main>$(String[] args) in C:\dio_avanade\ExemplosExplorando\Program.cs:line 318


// ----Removendo e alternando elementos   
// Dictionary<string, string> estados = new Dictionary<string, string>();
// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");
// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// para remover uma chave uso o remove informando o valor da chave exemplo:

// Console.WriteLine("------------------------");
// estados.Remove("BA");
// manipulando alterando o valor da chave , COM [] COMO SE FOSSE UM ARRAY
// estados["SP"] = "sÃO pAULO - VALOR ALTERADO";
// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// como verificar se ja existe uma chave sem gerar uma exceção usando o método ContainsKey depois de rodar ele retornou 
// $ dotnet run
// Chave: SP, Valor: São Paulo
// Chave: BA, Valor: Bahia
// Chave: MG, Valor: Minas Gerais
// Verificando o elemento:BA
// Valor existente: BA

// acrescentando numero 2 na chave bahua eke aceitou e retornou 
// Chave: SP, Valor: São Paulo
// Chave: BA, Valor: Bahia
// Chave: MG, Valor: Minas Gerais
// Verificando o elemento:BA2
// Valor não existe. É seguro adicionar a chave: BA2
// string chave = "BA2";
// Console.WriteLine($"Verificando o elemento:{chave}");
// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else 
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }
// Como obter uma valor que já existe

// Dictionary<string, string> estados = new Dictionary<string, string>();
// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);

// --------Finalização-------------------------------------------

//******************** Desafios de Projetos - Crie um portifólio Vencedor**********
// PBL(Aprendizagem Baseada em Projetos) O Aprendizado Baseado em Projetos é sobre imergir em grandes ideias e criar soluções tangíveis. Neste método, você constroi projetos práticos que refletem problemas e desafios do mundo real. Esses projetos não apenas aumentam seu conhecimento, mas também demonstram suas competências.
// Portifólio - Cada Projeto concluído reforça suas habilidades, promove networking e dá destaque ao seu portfólio profissional.
// Destaque: Ao finaliar seus projetos na Dio, você obtém uma certificação de competências, um diferencial importante para abrir portas no mercado de trabalho.
// Oportunidades: Através da Talent Match, você tem acesso ás melhores oportunidades de emprego no setor de tecnologia. Vamos ajudá-lo a construir a carreira dos seus sonhos.
// Desenvolva suas hanilidades
// Hardskills: Linguagens de programação, Arquitetura de Sistema, Banco de daods, Stacks de desenvolvimento, ferramentas.
// Softskills : trablho em equipe, pensamento crítico, gerenciamento de tempo, comunicação, liderança  

// ------A importância dos Desafios de Projeto na Prática-----------
//  Projeto: Contribuindo em um projeto Open Source no Github dentro da Plataforma da DIO   Lab


// *****ETAPA 4 TUPLAS,OPERADORES TERNÁRIOS E DESCONSTRUÇÃO DE OBJETO
// *****ETAPA 5 NUGET, SERIALIZAR E ATRIBUTOS NO C#
// *****ETAPA 6 TIPOS ESPECIAIS NO C#
// *****ETAPA 7 STACK, HEAP E GARBAGE COLLECTOR





