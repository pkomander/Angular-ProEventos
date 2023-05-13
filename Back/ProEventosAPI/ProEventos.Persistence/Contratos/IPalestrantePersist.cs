using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
        //Palestrantes
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includePalestrante);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includePalestrante);
        Task<Palestrante> GetPalestrantesByIdAsync(int palestranteId, bool includePalestrante);

    }
}
