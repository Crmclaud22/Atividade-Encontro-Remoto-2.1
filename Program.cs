
using Encontro_remoto_2.Classes;

// Console.WriteLine("Hello, World!");

//para instanciar: Tipo NomeDoObjeto = MetodoConstrutor ():
//instaciamos um obejo do tipo pessoa fisica
//ou seja, estamos criando um objeto

//PessoaFisica novaPessoaFisica = new PessoaFisica();

//atribuimos um valor para as propriedades
// novaPessoaFisica.Nome = "Claudio";
// novaPessoaFisica.Cpf = "01241584688";
// novaPessoaFisica.DataNascimento = new DateTime(1962,11,07);
// novaPessoaFisica.Rendimento = 15000.50f;
//imprimimos os valores do objeto do console
// Console.WriteLine(novaPessoaFisica.Nome);
// Console.WriteLine(novaPessoaFisica.Cpf);
// Console.WriteLine(novaPessoaFisica.DataNascimento);
// Console.WriteLine(novaPessoaFisica.Rendimento);

//concatenação
//cw cria o console.writeline

//imprimimimos no console usando a concatenação
// System.Console.WriteLine("Nome:" + novaPessoaFisica.Nome);
// System.Console.WriteLine("Cpf: " + novaPessoaFisica.Cpf);
// System.Console.WriteLine("Data de Nascimento: " + novaPessoaFisica.DataNascimento);
// System.Console.WriteLine("Rendimento: $ " + novaPessoaFisica.Rendimento);

//Interpolaçao
//abrir colchete shift + colchete 
//cwl cria o console.write line já com estrutura
//O SYSTEM ABAIXO REFERE-SE AO CW E PODE SER RETIRADO
//imprimimos no console os volores do objeto utilizando a INTERPOLAÇÃO
// System.Console.WriteLine($"Nome: {novaPessoaFisica.Nome}");
// System.Console.WriteLine($"Cpf: {novaPessoaFisica.Cpf}");
// Console.WriteLine($"Data de Nascimento: {novaPessoaFisica.DataNascimento} ");
// Console.WriteLine($"Rendimento: $ {novaPessoaFisica.Rendimento} ");

//Quebra de linha usar o caracter @ antes do $, dar enter

//Imprimimos no console os valores do objeto utiliizando interpolaçao e que de linhas
// Console.WriteLine(@$"
// Nome: {novaPessoaFisica.Nome}
// Data de Nascimento: {novaPessoaFisica.DataNascimento}
// Cpf: {novaPessoaFisica.Cpf}
// Rendimento: $ {novaPessoaFisica.Rendimento}
// ");

//instanciado um objeto do tipo Pessoa Juridica
PessoaJurica novaPessoaJuridica = new PessoaJurica();

//Atribuimos valores para os atributos do objeto Pessoa Jurídica
novaPessoaJuridica.Nome = "Tce SP";
novaPessoaJuridica.RazaoSocial = "Tribunal de Contas do Estado";
novaPessoaJuridica.Cnpj = "1234567891555";
novaPessoaJuridica.Rendimento = 100000007.11f;

//Imprimimos os valores do objeto Pessoa Jurídica
Console.WriteLine(@$"
Nome fantasia : {novaPessoaJuridica.Nome}
Razão Social : {novaPessoaJuridica.RazaoSocial}
Cnpj : {novaPessoaJuridica.Cnpj}
Rendimento Mensal : {novaPessoaJuridica.Rendimento}
");
