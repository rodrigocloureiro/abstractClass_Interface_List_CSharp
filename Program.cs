using Biblioteca;

public class Program
{
    public static void Main(string[] args)
    {
        IList<InstrumentoMusical> listaInstrumentos = new List<InstrumentoMusical>();

        Violao violao = new Violao("Violão", "Corda");
        listaInstrumentos.Add(violao);

        Baixo baixo = new Baixo("Baixo", "Corda");
        listaInstrumentos.Add(baixo);

        Guitarra guitarra = new Guitarra("Guitarra", "Corda");
        listaInstrumentos.Add(guitarra);

        Triangulo triangulo = new Triangulo("Triângulo", "Percussão");
        listaInstrumentos.Add(triangulo);

        foreach (InstrumentoMusical instrumento in listaInstrumentos)
        {
            instrumento.Tocar();

            if (instrumento is IAfinavel afinavel)
            {
                afinavel.Afinar();
                Console.WriteLine(afinavel.VerificarAfinacao() ? "Está afinado.." : "Não está afinado..");
            }

            Console.WriteLine("\n===============\n");
        }

        Console.ReadKey();
    }
}