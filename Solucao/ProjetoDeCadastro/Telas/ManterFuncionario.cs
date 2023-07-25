using System;
using Biblioteca.Arquivo;
using Biblioteca.Model;
using ProjetoDeCadastro.Conversores;

namespace ProjetoDeCadastro.Telas
{
    class ManterFuncionario
    {
        public void CadastrarFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.Clear();


            Console.WriteLine("CADASTRAR FUNCIONÁRIO ");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            funcionario.Telefone = Console.ReadLine();

            Console.Write("CPF: ");
            funcionario.CPF = Console.ReadLine();

            Console.Write("RG: ");
            funcionario.RG = Console.ReadLine();

            Console.Write("CEP (Apenas números): ");
            funcionario.CEP = int.Parse(Console.ReadLine());

            Console.Write("Estado: ");
            funcionario.Estado = Console.ReadLine();

            Console.Write("Cidade: ");
            funcionario.Cidade = Console.ReadLine();

            Console.Write("Endereço: ");
            funcionario.Endereço = Console.ReadLine();

            Console.Write("Cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Salário R$ ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.Write("Data de contratação: ");
            funcionario.DataContratacao = DateTime.Parse(Console.ReadLine());


            GerenciadorArquivo.GravarArquivo("funcionario", FuncionarioTexto.ConverterParaTexto(funcionario));//nome do arquivo, texto a ser escrito neste arquivo
        }

        public void ListarFuncionarios()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE FUNCIONÁRIOS ");

            string[] linhas = GerenciadorArquivo.LerArquivo("funcionario");//nome do arquivo, texto a ser escrito neste arquivo
            foreach (string linha in linhas)
            {
                FuncionarioTexto.ConverterParafuncionario(linha);
                Console.WriteLine(linha);
            }
        }
    }
}
