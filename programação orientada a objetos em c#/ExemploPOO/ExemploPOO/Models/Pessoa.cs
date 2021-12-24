namespace ExemploPOO.Models
{
    // Exemplo de abstração
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Documento { get; set; }

        public virtual void Apresentar(){
            Console.WriteLine($"Oi, me chamo {Nome} e tenho {Idade} anos de idade.");
        }
    }
    
}