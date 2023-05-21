using AutoMapper;
using ProEventos.Application.Contratos;
using ProEventos.Application.Dtos;
using ProEventos.Domain;
using ProEventos.Persistence.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Application
{
    public class EventoService : IEventosService
    {
        private readonly IGeralPersist _geralPersist;
        private readonly IEventoPersist _eventoPersist;
        private readonly IMapper _mapper;
        public EventoService(IGeralPersist georPersist, IEventoPersist eventoPersist, IMapper mapper)
        {
            _geralPersist = georPersist;
            _eventoPersist = eventoPersist;
            _mapper = mapper;
        }

        public async Task<EventoDto> AddEventos(EventoDto model)
        {
            try
            {
                var evento = _mapper.Map<Evento>(model);
                _geralPersist.Add<Evento>(evento);
                if(await _geralPersist.SaveChangesAsync())
                {
                    var retorno = await _eventoPersist.GetEventosByIdAsync(evento.Id, false);
                    return _mapper.Map<EventoDto>(retorno);
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<EventoDto> UpdateEvento(int eventoId, EventoDto model)
        {
            try
            {
                var evento = await _eventoPersist.GetEventosByIdAsync(eventoId, false);

                if (evento == null)
                {
                    return null;
                }

                model.Id = evento.Id;
                _mapper.Map(model, evento);

                _geralPersist.Update<Evento>(evento);
                if (await _geralPersist.SaveChangesAsync())
                {
                    var retorno = await _eventoPersist.GetEventosByIdAsync(evento.Id, false);
                    return _mapper.Map<EventoDto>(retorno);
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteEvento(int eventoId)
        {
            try
            {
                var evento = await _eventoPersist.GetEventosByIdAsync(eventoId);

                if (evento == null)
                {
                    throw new Exception("Evento para delete nao encontrado.");
                }

                _geralPersist.Delete<Evento>(evento);
                return await _geralPersist.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<EventoDto[]> GetAllEventosAsync(bool includePalestrante = false)
        {
            try
            {
                var eventos = await _eventoPersist.GetAllEventosAsync(includePalestrante);

                if (eventos == null)
                    return null;

                var resultado = _mapper.Map<EventoDto[]>(eventos);

                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<EventoDto[]> GetAllEventosByTemaAsync(string tema, bool includePalestrante = false)
        {
            try
            {
                var eventos = await _eventoPersist.GetAllEventosByTemaAsync(tema, includePalestrante);

                if (eventos == null)
                    return null;

                var resultado = _mapper.Map<EventoDto[]>(eventos);

                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<EventoDto> GetEventosByIdAsync(int eventoId, bool includePalestrante = false)
        {
            try
            {
                var eventos = await _eventoPersist.GetEventosByIdAsync(eventoId, includePalestrante);

                if (eventos == null)
                    return null;

                var resultado = _mapper.Map<EventoDto>(eventos);

                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        
    }
}
