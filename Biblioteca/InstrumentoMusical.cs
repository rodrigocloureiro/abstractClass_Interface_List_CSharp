namespace Biblioteca;

public abstract class InstrumentoMusical
{
    private string _nome;
    private string _tipo;

    public InstrumentoMusical(string nome, string tipo)
    {
        _nome = nome;
        _tipo = tipo;
    }

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public string Tipo
    {
        get { return _tipo; }
        set { _tipo = value; }
    }

    public abstract void Tocar();
}