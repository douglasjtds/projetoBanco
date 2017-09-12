using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoBanco
{
    public class TotalizadorDeTributos
    {
        public double Total { get; private set; }


        /*para não precisar usar dessa forma, podemos usar a interface abaixo (ITributavel)*/
        //public void Acumula(ContaPoupanca cp) {
        //    Total += cp.CalculaTributo();
        //}

        //public void Acumula(ContaInvestimento ci) {
        //    Total += ci.CalculaTributo();
        //}


        /*usando interface ITributavel*/
        public void Acumula(ITributavel t) {
            this.Total += t.CalculaTributo(); //o problema de somar dessa forma é que
            //o programa soma com o total de outro cálculo (??)
        }
    }

}
