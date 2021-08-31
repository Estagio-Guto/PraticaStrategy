using System;
using System.Collections.Generic;
using System.Text;

namespace padroesroteiros.roteiro1.parte1
{
    public class ServicoQuarto
    {
        private MySqlConnection connection;
        public ServicoQuarto()
        {
            this.connection = new MySqlConnection();
        }

        public void verificarQuarto()
        {
            this.connection.Connect();
            Console.WriteLine("Lógica de negócio para o Serviço de Quarto");
        }
    }
}
