using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    class Solicitacao
    {
        public void realizarSolicitacao(Banco banco)
        {
            Console.WriteLine("Digite agência: ");
            int numAgencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tipo da conta: 1 - Corrente/ 2 - Poupança");
            Console.WriteLine("1 - Corrente:");
            Console.WriteLine("2 - Poupança:");
            int tipoConta = int.Parse(Console.ReadLine());

            if (tipoConta == 1)
            {
                Console.WriteLine("Digite a sua conta: ");
                int numConta = int.Parse(Console.ReadLine());
                Agencia agencia = banco.buscaAgencia(numAgencia);
                if (agencia == null)
                {
                    return;
                }
                ContaCorrente cc = agencia.getCCorrente(numConta);
                if (cc == null)
                {
                    return;
                }

                Console.WriteLine("Operação: \n");
                Console.WriteLine("1 - Saldo:");
                Console.WriteLine("2 - Sa1ue:");
                Console.WriteLine("3 - Depósito:");
                int operacao = int.Parse(Console.ReadLine());

                if (operacao == 1)
                {
                    Console.WriteLine("Situação da conta:");
                    Console.WriteLine("Conta: " + cc.Id);
                    Console.WriteLine("Titular: " + cc.Titular);
                    Console.WriteLine("Saldo: R$ " + cc.Saldo);
                }
                else if (operacao == 2)
                {
                    Console.WriteLine("Digite o valor do saque ");
                    cc.Sacar(decimal.Parse(Console.ReadLine()));
                }
                else if (operacao == 3)
                {
                    Console.WriteLine("Digite o valor do deposito ");
                    cc.Depositar(decimal.Parse(Console.ReadLine()));
                }
            }
            else if (tipoConta == 2)
            {
                Console.WriteLine("Digite a conta: ");
                int numConta = int.Parse(Console.ReadLine());
                Agencia agencia = banco.buscaAgencia(numAgencia);
                if (agencia == null)
                {
                    return;
                }
                ContaPoupanca cp = agencia.getCPoupanca(numConta);
                if (cp == null)
                {
                    return;
                }

                Console.WriteLine("Operação: \n");
                Console.WriteLine("1 - Saldo:");
                Console.WriteLine("2 - Sa1ue:");
                Console.WriteLine("3 - Depósito:");
                int operacao = int.Parse(Console.ReadLine());

                if (operacao == 1)
                {
                    Console.WriteLine("Situação da conta:");
                    Console.WriteLine("Conta = " + cp.Id);
                    Console.WriteLine("Titular = " + cp.Titular);
                    Console.WriteLine("Seu saldo é = R$ " + cp.Saldo);
                }
                else if (operacao == 2)
                {
                    Console.WriteLine("Digite o valor do saque ");
                    cp.Sacar(decimal.Parse(Console.ReadLine()));
                }
                else if (operacao == 3)
                {
                    Console.WriteLine("Digite o valor do depósito ");
                    cp.Depositar(decimal.Parse(Console.ReadLine()));
                }
            }
        }
    }
}
