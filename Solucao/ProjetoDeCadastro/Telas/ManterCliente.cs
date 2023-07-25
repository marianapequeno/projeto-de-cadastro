using System;
using Biblioteca.Arquivo;
using Biblioteca.Model;
using ProjetoDeCadastro.Conversores;

namespace ProjetoDeCadastro.Telas
{
    class ManterCliente
    {

        public void CadastrarCliente()
        {
            Cliente cliente = new Cliente();


            Console.Clear();


            Console.WriteLine("CADASTRAR CLIENTE ");
            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.Write("CPF: ");
            cliente.CPF = Console.ReadLine();

            Console.Write("RG: ");
            cliente.RG = Console.ReadLine();

            Console.Write("CEP (Apenas números): ");
            cliente.CEP = int.Parse(Console.ReadLine());

            Console.Write("Estado: ");
            cliente.Estado = Console.ReadLine();

            Console.Write("Cidade: ");
            cliente.Cidade = Console.ReadLine();

            Console.Write("Endereço: ");
            cliente.Endereço = Console.ReadLine();

            GerenciadorArquivo.GravarArquivo("cliente", ClienteTexto.ConverterParaTexto(cliente));//nome do arquivo, texto a ser escrito neste arquivo
        }

        public void ListarClientes()
        {
            Console.Clear();

            Console.WriteLine("LISTAGEM DE CLIENTES ");

            string[] linhas = GerenciadorArquivo.LerArquivo("cliente");//nome do arquivo, texto a ser escrito neste arquivo
            foreach (string linha in linhas)
            {
                ClienteTexto.ConverterParaCliente(linha);
                Console.WriteLine(linha);   
            }
        }

    }
}
