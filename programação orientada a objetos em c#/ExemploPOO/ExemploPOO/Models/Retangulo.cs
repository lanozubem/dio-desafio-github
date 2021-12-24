namespace ExemploPOO.Models
{
    // Exemplo de Encapsulamento
    public class Retangulo
    {
        private double comprimento { get; set; }
        private double largura { get; set; }
        private bool valido { get; set; }

        public void DefinirMedidas(double comprimento, double largura)
        {
            if (comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                this.valido = true;
            }else{
                Console.WriteLine("Valores inválidos!");
            }

        }

        public double ObterArea()
        {
            if (this.valido)
            {
                return comprimento * largura;
            }else
            {
                System.Console.WriteLine("Preencha valores válidos");
                return 0;
            }
        }
    }

}