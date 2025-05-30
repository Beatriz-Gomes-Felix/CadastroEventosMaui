using System;
using Microsoft.Maui.Controls;

namespace CadastroEventosMaui
{
    public partial class ResultadoPage : ContentPage
    {
        public ResultadoPage(Evento evento)
        {
            InitializeComponent();
            ResumoLabel.Text = $"Evento: {evento.Nome}\n" +
                               $"Local: {evento.Local}\n" +
                               $"Data: {evento.DataInicio:dd/MM/yyyy} a {evento.DataFim:dd/MM/yyyy}\n" +
                               $"Duração: {evento.DuracaoDias} dias\n" +
                               $"Participantes: {evento.NumeroParticipantes}\n" +
                               $"Custo por Participante: R$ {evento.CustoPorParticipante:F2}\n" +
                               $"Custo Total: R$ {evento.CustoTotal:F2}";
        }
    }
}
