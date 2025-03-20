using System.Security.Cryptography.X509Certificates;

public class Pessoa
{
    public string nome;
    public int idade;
    public string profissao;


    public void Envelhecer()
    {
        idade ++;
    }

    public void Cumprimentar()
    {
        Console.WriteLine($"oii meu nome é {nome}, boa tarde. Tudo bem?");
    }

    public bool MaiorIdade()
    {
        if(idade >=18)
        {
           return true;
        }else
        {
           return false;
        }

   
    } 
    public void Informacao()
    {
        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Profissao: {profissao}");
    }
}
