namespace Biblioteca;

public class Triangulo : InstrumentoMusical
{
    public Triangulo(string nome, string tipo) : base(nome, tipo) { }

    public override void Tocar()
    {
        Console.WriteLine($"Tocando {Nome}..");
    }
}