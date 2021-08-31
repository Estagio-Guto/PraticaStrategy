using System;
using System.Collections.Generic;
using System.Text;

namespace padroesroteiros.roteiro1.parte2
{
    public class ServicoQuarto
    {
        private OracleConnection connection;
        public ServicoQuarto()
        {
            this.connection = new OracleConnection();
        }

        public void verificarQuarto()
        {
            this.connection.Connect();
            Console.WriteLine("Lógica de negócio para o Serviço de Quarto");
        }
    }
}
