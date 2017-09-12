using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoBanco
{
    public interface ITributavel //serve para criar uma espécie de assinatura para outras classes
    //no caso, para dizer qual classe vai utilizar o método CalculaTributo
    {
        double CalculaTributo();
    }
}
