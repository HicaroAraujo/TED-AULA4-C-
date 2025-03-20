public class Carro
{

    public string marca;
    public string modelo;
    public string cor;
    public string placa;
    public int ano; 

    public void Andar()
    {
        Console.WriteLine("Carro andando");
    }

    public void Freiar()
    {
        Console.WriteLine($"Carro {modelo} freiando");
    }

}