using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosMauiApp.Models
{
    public class Evento
    {
        public string Nome { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }    
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }    
        public string Local {  get; set; }  = string.Empty;
        public decimal CustoPorParticipante {  get; set; }
        public int DuracaoDias => (DataTermino - DataInicio).Days;
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}
