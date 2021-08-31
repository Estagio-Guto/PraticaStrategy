using padroesroteiros.roteiro1.parte1;
using System;

namespace roteiro1.parte1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServicoQuarto quarto = new ServicoQuarto();
            quarto.verificarQuarto();
            ServicoReserva reserva = new ServicoReserva();
            reserva.criarReserva();
            RelatorioReserva relatorio = new RelatorioReserva();
            relatorio.gerarRelatorio();
        }
    }
}
