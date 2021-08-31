using roteiro1.parte3;
using System;
using System.Collections.Generic;
using System.Text;

namespace padroesroteiros.roteiro1.parte3
{
    public class ServicoReserva
    {
        private IConnectionInterface connection;
        public ServicoReserva(IConnectionInterface c)
        {
            this.connection = c;
        }
        public void criarReserva()
        {
            this.connection.Connect();
            Console.WriteLine("Lógica de negócio para Reserva do Quarto");
        }
    }
}
