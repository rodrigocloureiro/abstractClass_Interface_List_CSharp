namespace Biblioteca;

public class Violao : InstrumentoMusical, IAfinavel
{
    public Violao(string nome, string tipo) : base(nome, tipo) { }

    public void Afinar()
    {
        Console.WriteLine($"Afinando {Nome}..");
    }

    public bool VerificarAfinacao()
    {
        return true;
    }

    public override void Tocar()
    {
        Console.WriteLine($"Tocando {Nome}..");
    }
}