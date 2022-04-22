namespace EstudoInterfaceCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new ImpressoraComum();
            var i2 = new ImpressoraCopiadora();
            Console.WriteLine(i.Imprimir("Estou estudando C#"));
            Console.WriteLine(i2.Copiar("E você?"));
        }
    }
}