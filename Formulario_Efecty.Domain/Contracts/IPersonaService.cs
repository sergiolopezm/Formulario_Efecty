using Formulario_Efecty.Infrastructure;
using Formulario_Efecty.Shared.GeneralDTO;

namespace Formulario_Efecty.Domain.Contracts
{
    public interface IPersonaService
    {
        Task<IEnumerable<Persona>> GetAllPersonasAsync();
        Task<Persona> GetPersonaByIdAsync(int id);
        Task<RespuestaDto> CreatePersonaAsync(Persona persona);
        Task<RespuestaDto> UpdatePersonaAsync(Persona persona); 
        Task<RespuestaDto> DeletePersonaAsync(int id);
    }
}
