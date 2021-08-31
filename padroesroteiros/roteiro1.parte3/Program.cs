using padroesroteiros.roteiro1.parte3;
using System;

namespace roteiro1.parte3
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            IConnectionInterface Con = new MySqlConnection();
            IConnectionInterface c = new OracleConnection();
            ServicoQuarto quarto = new ServicoQuarto(Con);
            quarto.verificarQuarto();
            ServicoReserva reserva = new ServicoReserva(Con);
            reserva.criarReserva();
            RelatorioReserva relatorio = new RelatorioReserva(c);
            relatorio.gerarRelatorio();
        }
    }
}
