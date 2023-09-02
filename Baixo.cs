namespace Biblioteca;

public class Baixo : InstrumentoMusical, IAfinavel
{
    public Baixo(string nome, string tipo) : base(nome, tipo) { }

    public void Afinar()
    {
        Console.WriteLine($"Afinando {Nome}..");
    }

    public bool VerificarAfinacao()
    {
        return false;
    }

    public override void Tocar()
    {
        Console.WriteLine($"Tocando {Nome}..");
    }
}