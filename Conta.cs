using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    public abstract class Conta
    {
        private decimal saldo;
        private string titular = string.Empty;

        public Conta(string t)
        {
            this.titular = t;
        }
        public virtual void Depositar(decimal valor)
        {
            Saldo += valor;
        }
        public virtual void Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente. ");
            }
        }
        public  string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public abstract int Id { get; set; }
    }
}
