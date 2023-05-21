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
        Task<EventoDto> AddEventos(EventoDto model);
        Task<EventoDto> UpdateEvento(int id, EventoDto model);
        Task<bool> DeleteEvento(int eventoId);

        Task<EventoDto[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante = false);
        Task<EventoDto[]> GetAllEventosAsync(bool includePalestrante = false);
        Task<EventoDto> GetEventosByIdAsync(int eventoId, bool includePalestrante = false);
    }
}
