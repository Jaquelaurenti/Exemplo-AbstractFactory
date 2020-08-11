using ExemploAbstractFactory.Interfaces;

namespace ExemploAbstractFactory
{
    /// <summary>
    /// ProdutoA2
    /// </summary>
    public class SamsungGalaxy : ISmartPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}
