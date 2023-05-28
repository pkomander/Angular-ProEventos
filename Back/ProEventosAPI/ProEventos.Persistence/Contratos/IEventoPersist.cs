using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    {
        //Eventos
        Task<Evento[]> GetAllEventosByTemaAsync(int userId, string tema, bool includePalestrante = false);
        Task<Evento[]> GetAllEventosAsync(int userId, bool includePalestrante = false);
        Task<Evento> GetEventosByIdAsync(int userId, int eventoId, bool includePalestrante = false);
    }
}
