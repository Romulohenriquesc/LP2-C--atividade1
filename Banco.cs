using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    class Banco
    {
        List<Agencia> agencias = new List<Agencia>();
        public List<Agencia> Agencias { get; }

        public int IdBanco { get; set; }
        public void addAgencia(Agencia agencia)
        {

            agencias.Add(agencia);
            Console.WriteLine("Agência " + agencia.IdAgencia + " criada com sucesso!");
            Console.WriteLine("Numero de agencias: " + (agencias.Count - 1) + "\n");
        }
        public Agencia buscaAgencia(int cod)
        {
            Agencia age = null;
            foreach (var agencia in agencias)
            {
                if (agencia.IdAgencia == cod)
                {
                    age = agencia;
                    return age;
                }
            }
            Console.WriteLine("Verifique seus dados e tente novamente.\n");
            return null;
        }
        public void listaIdAgencias()
        {

            foreach (var agencia in agencias)
            {
                Console.WriteLine("Agencia: " + agencia.IdAgencia + "\n");
            }
        }

    }
}
