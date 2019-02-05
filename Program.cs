using System;

namespace Atividade1
{
    class Program
    {
        public const decimal Juro = 0.6M;
        static void Main(string[] args)
        {
            int sum = 0;
            int idContaCorrente = 0;
            int idContaPoupanca = 0;

            Banco banco = new Banco();
            bool init = true;
            while (init)
            {

                MenuPrincipal();
                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Agencia agencia = new Agencia();
                    agencia.IdAgencia = sum;
                    banco.addAgencia(agencia);
                    sum++;

                }
                else if (op == 2)
                {
                    Cliente cliente = new Cliente();
                    Console.WriteLine("digite o nome do titular: ");
                    string nome_cliente = Console.ReadLine();
                    cliente.Nome = nome_cliente;

                    Console.WriteLine("Temos 2 tipos de conta, qual deseja?\n");
                    Console.WriteLine("1 - Conta Corrente: ");
                    Console.WriteLine("2 - Conta Poupança: ");

                    int tipoConta = int.Parse(Console.ReadLine());
                    if (tipoConta == 1)
                    {
                        ContaCorrente cc = new ContaCorrente(cliente.Nome);
                        Console.WriteLine("Digite o numero da agência: ");
                        int numAgencia = int.Parse(Console.ReadLine());

                        Agencia agencia = banco.buscaAgencia(numAgencia);
                        if (agencia != null)
                        {
                            cc.Id = idContaCorrente;
                            agencia.addContaCorrente(cc);
                            idContaCorrente++;
                        }
                        else
                        {
                            Console.WriteLine("Dados errado, tente novamente.");
                        }

                    }
                    else if (tipoConta == 2)
                    {
                        ContaPoupanca cp = new ContaPoupanca(Juro, DateTime.Now, cliente.Nome);
                        Console.WriteLine("Digite o numero da agência: ");
                        int numAgencia = int.Parse(Console.ReadLine());

                        Agencia agencia = banco.buscaAgencia(numAgencia);
                        if (agencia != null)
                        {
                            cp.Id = idContaPoupanca;
                            agencia.addContaPoupanca(cp);
                            idContaPoupanca++;
                        }
                        else
                        {
                            Console.WriteLine("Dados errado, tente novamente.");
                        }

                    }
                }
                else if (op == 3)
                {
                    Solicitacao solicitacao = new Solicitacao();
                    solicitacao.realizarSolicitacao(banco);


                }
                else if (op == 4)
                {
                    banco.listaIdAgencias();
                }
                else if (op == 0)
                {
                    init = false;
                }


            }
        }
        public static void MenuPrincipal()
        {
            Console.WriteLine("Escolha um opção");
            Console.WriteLine(" 1 - Cadastro de Agência  ");
            Console.WriteLine(" 2 - Criar Conta ");
            Console.WriteLine(" 3 - Iniciar Sessão ");
            Console.WriteLine(" 4 - Mostrar agências ");
            Console.WriteLine(" 0 - Sair");
        }
    }
}
