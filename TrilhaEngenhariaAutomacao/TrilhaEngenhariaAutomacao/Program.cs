using System;
using System.Collections.Generic;
using System.Linq;

namespace Contas
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente _clientesCorrente = new ContaCorrente();
            ContaPoupanca _clientesPoupanca = new ContaPoupanca();
            Console.WriteLine("Selecione: \n 0 - Sair  \n 1 - Conta Corrente \n 2 - ContaPupanca");
            string conta = Console.ReadLine();
            while (conta != "0")
            {
                if (conta == "1")
                {
                    Console.WriteLine("Digite o nome do cliente:");
                    _clientesCorrente.nomeDonoConta = Console.ReadLine();

                    Console.WriteLine("Digite o valor da conta:");
                    _clientesCorrente.valorContaCorrente = Convert.ToDouble(Console.ReadLine());

                    List<string> clientes = new List<string>();

                    clientes.Add(_clientesCorrente.nomeDonoConta);

                    string funcionalidade = "";

                    Console.WriteLine("Funcoes: \n 0 - Sair \n 1 - Deposito \n 2 - Saque");
                    funcionalidade = Console.ReadLine();

                    Console.Clear();

                    while (funcionalidade == "1" || funcionalidade == "2")
                    {
                        if (funcionalidade == "2")
                        {
                            Console.WriteLine("\n Valor na Conta " + String.Format("{0:0.00}", _clientesCorrente.valorContaCorrente));
                            Console.WriteLine("\n Digite o valor a ser sacado:");
                            double saque = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\n Valor atual da conta: " + _clientesCorrente.Saque(saque));

                            Console.WriteLine("\n Funcoes: \n 0 - Sair \n 1 - Deposito \n 2 - Saque");
                            funcionalidade = Console.ReadLine();
                            Console.Clear();
                        }
                        if (funcionalidade == "1")
                        {
                            Console.WriteLine("\n Valor na Conta " + String.Format("{0:0.00}", _clientesCorrente.valorContaCorrente));
                            Console.WriteLine("\n Digite o valor a ser depositado:");
                            double deposito = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\n Valor atual da conta: " + _clientesCorrente.Deposito(deposito));

                            Console.WriteLine("\n Funcoes: \n 0 - Sair \n 1 - Deposito \n 2 - Saque");
                            funcionalidade = Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }

                if (conta == "2")
                {
                    Console.WriteLine("Digite o nome do cliente:");
                    _clientesPoupanca.nomeDonoContaPoupanca = Console.ReadLine();

                    Console.WriteLine("Digite o valor da conta:");
                    _clientesPoupanca.valorContaPoupanca = Convert.ToDouble(Console.ReadLine());

                    List<string> clientes = new List<string>();

                    clientes.Add(_clientesPoupanca.nomeDonoContaPoupanca);

                    string funcionalidade = "";

                    Console.WriteLine("Funcoes: \n 0 - Sair \n 1 - Deposito \n 2 - Saque");
                    funcionalidade = Console.ReadLine();

                    Console.Clear();

                    while (funcionalidade == "1" || funcionalidade == "2")
                    {
                        if (funcionalidade == "2")
                        {
                            Console.WriteLine("\n Valor na Conta " + String.Format("{0:0.00}", _clientesPoupanca.valorContaPoupanca));
                            Console.WriteLine("\n Digite o valor a ser sacado:");
                            double saque = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\n Valor atual da conta: " + _clientesPoupanca.Saque(saque));

                            Console.WriteLine("\n Funcoes: \n 0 - Sair \n 1 - Deposito \n 2 - Saque");
                            funcionalidade = Console.ReadLine();
                            Console.Clear();
                        }
                        if (funcionalidade == "1")
                        {
                            Console.WriteLine("\n Valor na Conta " + String.Format("{0:0.00}", _clientesPoupanca.valorContaPoupanca));
                            Console.WriteLine("\n Digite o valor a ser depositado:");
                            double deposito = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\n Valor atual da conta: " + _clientesPoupanca.Deposito(deposito));

                            Console.WriteLine("\n Funcoes: \n 0 - Sair \n 1 - Deposito \n 2 - Saque");
                            funcionalidade = Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("Clique ENTER para fechar");

            Console.ReadKey();

        }
    }
}
