using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    public class Agencia
    {
        List<ContaCorrente> contasCorrente = new List<ContaCorrente>();
        List<ContaPoupanca> contasPoupanca = new List<ContaPoupanca>();
        List<Solicitacao> solicitacoes = new List<Solicitacao>();


        public int IdAgencia { get; set; }
        public ContaCorrente getCCorrente(int num)
        {
            ContaCorrente cc = null;
            foreach (var conta in contasCorrente)
            {
                if (conta.Id == num)
                {
                    cc = conta;
                    return cc;
                }
            }

            Console.WriteLine("Verifique se os dados estão corretos e tente novamente.");
            return null;        
        }
        public ContaPoupanca getCPoupanca(int num)
        {
            ContaPoupanca cp = null;
            foreach (var conta in contasPoupanca)
            {
                if (conta.Id == num)
                {
                    cp = conta;
                    return cp;
                }
            }
            Console.WriteLine("Verifique se os dados estão corretos e tente novamente.");
            return null;

        }
        public void addContaCorrente(ContaCorrente cc)
        {
            contasCorrente.Add(cc);
            Console.WriteLine("Conta: " + cc.Id + "\n" + "Titular: " + cc.Titular + "\n" + "Conta Criada com sucesso\n");
        }
        public void addContaPoupanca(ContaPoupanca cp)
        {
            contasPoupanca.Add(cp);
            Console.WriteLine("Conta: " + cp.Id + "\n" + "Titular: " + cp.Titular + "\n" + "Conta Criada com sucesso\n");
        }
    }
}
