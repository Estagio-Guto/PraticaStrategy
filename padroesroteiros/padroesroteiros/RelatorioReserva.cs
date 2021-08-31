using System;
using System.Collections.Generic;
using System.Text;

namespace padroesroteiros.roteiro1.parte1
{
    public class RelatorioReserva
    {
        private MySqlConnection connection;
        public RelatorioReserva()
        {
            this.connection = new MySqlConnection();
        }
        public void gerarRelatorio()
        {
            this.connection.Connect();
            Console.WriteLine("Lógica de negócio para geração do relatório");
        }
    }
}
