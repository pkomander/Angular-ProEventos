using ProEventos.Application.Dtos;
using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Application.Contratos
{
    public interface IEventosService
    {
        Task<EventoDto> AddEventos(int userId, EventoDto model);
        Task<EventoDto> UpdateEvento(int userId, int id, EventoDto model);
        Task<bool> DeleteEvento(int userId, int eventoId);

        Task<EventoDto[]> GetAllEventosByTemaAsync(int userId, string tema, bool includePalestrante = false);
        Task<EventoDto[]> GetAllEventosAsync(int userId, bool includePalestrante = false);
        Task<EventoDto> GetEventosByIdAsync(int userId, int eventoId, bool includePalestrante = false);
    }
}
