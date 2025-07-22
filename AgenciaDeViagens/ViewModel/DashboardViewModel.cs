using AgenciaDeViagens.Models;

namespace AgenciaDeViagens.ViewModel
{
    public class DashboardViewModel
    {
        public List<Pacote> Pacotes { get; set; }
        public List<PeriodoIndisponivel> Periodos { get; set; }
    }
}
