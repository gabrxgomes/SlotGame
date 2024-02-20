internal class Program
{
    private static void Main(string[] args)
    {
        var numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var numerosFiltrados = numeros.Where(n => n > 5);

        foreach (var numero in numerosFiltrados)
        {
            Console.WriteLine(numero);
        }
    }
}