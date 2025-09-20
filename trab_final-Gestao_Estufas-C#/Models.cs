using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab_final_Gestao_Estufas.Models
{
    public class Estufa
    {
        public int IdEstufa { get; set; }
        public string Nome { get; set; }
        public string Localizacao { get; set; }
        public int Tamanho_m2 { get; set; }
        public string Cultura { get; set; }
    }

    public class EventoIrrigacao
    {
        public int IdEvento { get; set; }
        public int IdEstufa { get; set; }
        public DateTime DataHora { get; set; }
        public int DuracaoSegundos { get; set; }
    }

    public class LogAtmosferico
    {
        public int IdLog { get; set; }
        public int IdEstufa { get; set; }
        public DateTime DataHora { get; set; }
        public float Temperatura { get; set; }
        public float Umidade { get; set; }
    }
}

