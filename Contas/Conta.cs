namespace projetoBanco.Contas
{
    public abstract class Conta
    {

        //bloco <>
        private static int numeroDeContas;

        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }
        //alterado </>    

        public Cliente Titular;

        public int Numero { get; set; }
        public double Saldo { get; protected set; }

        public virtual void Deposita(double valorOperacao) 
        {
            this.Saldo += valorOperacao;
        }

        public virtual void Saca(double valor) {
            this.Saldo -= valor;
        }

        public static int ProximoNumero() {
            return Conta.numeroDeContas + 1;
        }

    }
}