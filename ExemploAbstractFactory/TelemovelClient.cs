using ExemploAbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploAbstractFactory
{
    /// <summary>
    /// Client
    /// </summary>
    public class TelemovelClient
    {
       ISmartPhone smartPhone;
       INormalPhone normalPhone;

        public TelemovelClient(ITelemovel telemovelfactory)
        {
            smartPhone = telemovelfactory.BuscarSmartPhone();
            normalPhone = telemovelfactory.BuscarNormalPhone();
        }

        public string BuscarSmartPhoneModeloDetalhes() 
        {
            return smartPhone.BuscarDetalhesModelo();        
        }

        public string BuscarNormalPhoneModeloDetalhes()
        {
            return normalPhone.BuscarDetalhesModelo();
        }



    }
}
