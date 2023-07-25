using System;
using ProjetoDeCadastro.Telas;
 

namespace ProjetoDeCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcoes = 0;

            while (opcoes != 5)
            {
                Console.WriteLine("O que deseja fazer? ");
                Console.WriteLine("(1 - Cadastrar cliente, 2 - Listar cliente, 3 - Cadastrar funcionário, 4 - Listar funcionário, 5 - Fechar programa)");
                opcoes = int.Parse(Console.ReadLine());

                ManterCliente telaCliente = new ManterCliente();
                ManterFuncionario telaFuncionario = new ManterFuncionario();
                switch (opcoes)
                {
                    case 1:
                        telaCliente.CadastrarCliente();
                        break;

                    case 2:
                        telaCliente.ListarClientes();
                        break;

                    case 3:
                        telaFuncionario.CadastrarFuncionario();
                        break;

                    case 4:
                        telaFuncionario.ListarFuncionarios();
                        break;

                    case 5:
                        // Encerrar programa
                        break;

                    default:
                        Console.WriteLine("Comando inválido!");
                        break;
                }
            }
        }
    }
}
