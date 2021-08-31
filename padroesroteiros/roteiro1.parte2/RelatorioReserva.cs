using System;
using System.Collections.Generic;
using System.Text;

namespace padroesroteiros.roteiro1.parte2
{
    public class RelatorioReserva
    {
        private OracleConnection connection;
        public RelatorioReserva()
        {
            this.connection = new OracleConnection();
        }
        public void gerarRelatorio()
        {
            this.connection.Connect();
            Console.WriteLine("Lógica de negócio para geração do relatório");
        }
    }
}
