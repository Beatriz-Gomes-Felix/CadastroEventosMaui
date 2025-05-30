using System;

namespace CadastroEventosMaui
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }

        public int DuracaoDias => (DataFim - DataInicio).Days + 1;
        public double CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}
