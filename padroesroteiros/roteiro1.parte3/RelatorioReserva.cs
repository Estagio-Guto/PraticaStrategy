using roteiro1.parte3;
using System;
using System.Collections.Generic;
using System.Text;

namespace padroesroteiros.roteiro1.parte3
{
    public class RelatorioReserva
    {
        private IConnectionInterface connection;
        public RelatorioReserva(IConnectionInterface c)
        {
            this.connection = c;
        }
        public void gerarRelatorio()
        {
            this.connection.Connect();
            Console.WriteLine("Lógica de negócio para geração do relatório");
        }
    }
}
