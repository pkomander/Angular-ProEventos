using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface ILotePersist
    {
        //Lotes

        /// <summary>
        /// Metodo get que retornara uma lista de lotes por eventoId
        /// </summary>
        /// <param name="eventoId">Codigo chave da tabela lote</param>
        /// <returns>lista de lotes</returns>
        Task<Lote[]> GetLotesByEventoIdAsync(int eventoId);

        /// <summary>
        /// Metodo get que retornara apenas 1 lote
        /// </summary>
        /// <param name="eventoId">Codigo chave da tabela Evento</param>
        /// <param name="loteId">Codigo chave da tabela Lote</param>
        /// <returns>Apenas 1 lote</returns>
        Task<Lote> GetLoteByIdsAsync(int eventoId, int loteId);
    }
}
