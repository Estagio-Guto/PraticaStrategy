using roteiro1.parte3;
using System;
using System.Collections.Generic;
using System.Text;

namespace padroesroteiros.roteiro1.parte3
{
    public class ServicoQuarto
    {
        private IConnectionInterface connection;
        public ServicoQuarto(IConnectionInterface c)
        {
            this.connection = c;
        }

        public void verificarQuarto()
        {
            this.connection.Connect();
            Console.WriteLine("Lógica de negócio para o Serviço de Quarto");
        }
    }
}
