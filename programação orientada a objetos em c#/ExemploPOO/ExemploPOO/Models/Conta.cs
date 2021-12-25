namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo { get; set; }

        public abstract void Creditar(double valor);

        public virtual void ExibirSaldo(){
            System.Console.WriteLine("Seu saldo é: " + saldo);
        }
    }
}