using ExemploPOO.Models;

// Abstração
// Pessoa p1 = new Pessoa();
// p1.Nome = "Neo";
// p1.Idade = 35;
// p1.Apresentar();

// Retangulo r = new Retangulo();
// r.DefinirMedidas(0, 10);
// System.Console.WriteLine(r.ObterArea());

// Herança e Polimorfismo
// Professor p = new Professor();
// p.Nome = "Victor";
// p.Idade = 42;
// p.Apresentar();
// p.Salario = 4877.99;

// Herança e Polimorfismo
// Aluno a = new Aluno();
// a.Nome = "Flash";
// a.Idade = 16;
// a.Documento = "123456";
// a.Nota = 7;
// a.Apresentar();

// Sobrecarga de métodos e Interface
var c = new Calculadora();
System.Console.WriteLine(c.Somar(10,5));
// System.Console.WriteLine(c.Somar(1, 2, 3));
System.Console.WriteLine(c.Dividir(10, 5));
System.Console.WriteLine(c.Multiplicar(10, 5));
System.Console.WriteLine(c.Subtrair(10, 5));

// var c = new Corrente();
// c.Creditar(100);
// c.ExibirSaldo();

// Classe Object
// var comp = new Computador();
// comp.ToString()