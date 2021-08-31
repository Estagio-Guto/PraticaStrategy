using roteiro1.parte3;
using System;
using System.Collections.Generic;
using System.Text;

namespace padroesroteiros.roteiro1.parte3
{
    public class OracleConnection : IConnectionInterface
    {
        public void Connect()
        {
            Console.WriteLine("Conectando com o Oracle");
        }
    }
}
