using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoBanco.Contas;

namespace projetoBanco.Contas
{
    public class ContaPoupanca : Conta, ITributavel //classe pai e assinatura de interface
    {
        public override void Saca(double valor)
        {   
            if(valor < 0.0) {
                throw new ArgumentException();
            }
            
            if (valor + 0.10 > this.Saldo) {
                throw new SaldoInsuficienteException();
            } else {
                this.Saldo -= valor + 0.10;
            }
            
            /*antes do tratamento de exceção
            base.Saca(valor + 0.10); */
        }

        public override void Deposita(double valorOperacao)
        {
            if(valorOperacao < 0.0) {
                throw new ArgumentException();
            }

            base.Deposita(valorOperacao);

            /*antes do tratamento de exceção
            base.Deposita(valorOperacao);
           //this.Saldo += valorOperacao; */
        }

        public void CalculaRendimento()
        {
            //método para teste
        }

        public double CalculaTributo() {
            return this.Saldo * 0.02;
        }
    }
}
