using ExemploAbstractFactory.Interfaces;
using System;

namespace ExemploAbstractFactory.ConcretesFactory
{
    /// <summary>
    /// ConcreteFactory2
    /// </summary>
    public class Samsung : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
