namespace Biblioteca;

public class Guitarra : InstrumentoMusical, IAfinavel
{
    public Guitarra(string nome, string tipo) : base(nome, tipo) { }

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