using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoBanco.Contas;

namespace projetoBanco.Contas
{
    public class ContaInvestimento : Conta, ITributavel
    {
        //outros metodos


        public double CalculaTributo() {
            return this.Saldo * 0.03;
        }
    }
}
