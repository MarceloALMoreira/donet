using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLine
{

        //Primeira classe
    public class ContaCorrente
    {
        public string titular;
        public int agencia;
        public string conta;
        public double saldo;


        //primeiro metedo da classe Conta corrente, -> Metedo Depositar
        public void  Depositar(double valor)
        {
            this.saldo += valor;
        }


    }


}
