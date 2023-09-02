namespace Biblioteca;

public class Program
{
    public static void Main(string[] args)
    {
        IList<InstrumentoMusical> listaInsturmentos = new List<InstrumentoMusical>();
        listaInsturmentos.Add(new Violao("Violão", "Corda"));
        listaInsturmentos.Add(new Baixo("Baixo", "Corda"));
        listaInsturmentos.Add(new Guitarra("Guitarra", "Corda"));
        listaInsturmentos.Add(new Triangulo("Triângulo", "Percussão"));
    }
}