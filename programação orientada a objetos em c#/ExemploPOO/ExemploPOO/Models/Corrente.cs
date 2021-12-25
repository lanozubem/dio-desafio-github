namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        private double Tarifa { get; set; }

        public override void Creditar (double valor)
        {
            base.saldo = valor;
        }
    }
}