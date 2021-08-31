using System;
using System.Collections.Generic;
using System.Text;

namespace padroesroteiros.roteiro1.parte2
{
    public class ServicoReserva
    {
        private OracleConnection connection;
        public ServicoReserva()
        {
            this.connection = new OracleConnection();
        }
        public void criarReserva()
        {
            this.connection.Connect();
            Console.WriteLine("Lógica de negócio para Reserva do Quarto");
        }
    }
}
