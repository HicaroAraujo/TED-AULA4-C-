Carro c1 = new();

c1.marca = "wolksvagem";
c1.modelo = "Sedan";
c1.cor = "vermelha";
c1.placa = "2302jkdl";
c1.ano = 2024; 

c1.Andar();

Pessoa p1 = new Pessoa();
p1.nome = "hicaro";
p1.idade = 23;
p1.profissao = "Desenvolvedor";

p1.Cumprimentar();
p1.Informacao();
Console.WriteLine($"{p1.nome} é maior de idade? {p1. MaiorIdade()}");
p1.Envelhecer();
p1.Informacao();
