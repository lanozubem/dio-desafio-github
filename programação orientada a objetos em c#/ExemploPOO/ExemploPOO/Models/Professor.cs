namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Oi, me chamo {Nome} e sou um profesor que ganha R${Salario}");
        }
    }
}