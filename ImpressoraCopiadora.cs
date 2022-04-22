namespace EstudoInterfaceCsharp
{
    public class ImpressoraCopiadora : IImpressora, ICopiadora
    {
        public string Imprimir(string texto)
        {
            return "Imprimindo: "+texto;
        }

        public string Copiar(string texto)
        {
            return "Copiando: "+texto;
        }
    }
}