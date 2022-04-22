namespace EstudoInterfaceCsharp
{
    public class ImpressoraComum : IImpressora
    {
        public string Imprimir(string texto)
        {
            return "Imprimindo: " + texto;
        }
    }
}