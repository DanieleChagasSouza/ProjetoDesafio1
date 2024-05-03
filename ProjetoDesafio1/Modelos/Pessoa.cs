namespace ProjetoDesafio1.Modelos;

public class Pessoa
{
    public string Nome { get; set; }

    public int  DataDeNascimento { get; set; }

    public double Altura { get; set; }

    public Pessoa()
    {
    }

    public int CalcularIdadeDaPessoa()
    {
        int diaNascimento = DataDeNascimento % 100;
        int anoNascimento = DataDeNascimento / 10000;
        int mesNascimento = (DataDeNascimento / 100) % 100;

        try
        {
            DateTime dataNascimento = new DateTime(anoNascimento, mesNascimento, diaNascimento);
            DateTime hoje = DateTime.Today;

            int idade = hoje.Year - dataNascimento.Year;
            if (dataNascimento > hoje.AddYears(-idade))
                idade--;
            return idade;
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Data de nascimento inválida.");
            return -1;
        }


    }

    public void ExibirDadosDeUmaPessoa()
    {
        Console.WriteLine($"Meu Nome é: {Nome}");
        Console.WriteLine($"Minha data de nascimento é: {DataDeNascimento.ToString("0000/00/00")}");
        Console.WriteLine($"Minha idade é: {CalcularIdadeDaPessoa()}");
        Console.WriteLine($"Minha altura é {Altura.ToString("0.00")} M");
    }

}
