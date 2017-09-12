using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoBanco.Contas;

namespace projetoBanco.Contas
{
    class ContaCorrente : Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            base.Saca(valor + 0.05);
        }

        public override void Deposita(double valorOperacao) {
            base.Deposita(valorOperacao - 0.10);
        }

        public double CalculaTributo() {
            return this.Saldo * 0.05;
        }
    }
}
