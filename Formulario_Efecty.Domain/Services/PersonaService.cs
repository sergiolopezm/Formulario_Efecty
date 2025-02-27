using Formulario_Efecty.Domain.Contracts;
using Formulario_Efecty.Infrastructure;
using Formulario_Efecty.Shared.GeneralDTO;

namespace Formulario_Efecty.Domain.Services
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;
        public PersonaService(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public async Task<RespuestaDto> CreatePersonaAsync(Persona persona)
        {
            try
            {
                var personaCreada = await _personaRepository.CreateAsync(persona);
                return new RespuestaDto
                {
                    Exito = true,
                    Mensaje = "Persona creada con éxito",
                    Detalle = "La persona ha sido creada con éxito",
                    Resultado = personaCreada
                };
            }
            catch (Exception ex)
            {
                return RespuestaDto.ErrorInterno();
            }
        }
        public async Task<RespuestaDto> DeletePersonaAsync(int id)
        {
            try
            {
                await _personaRepository.DeleteAsync(id);
                return new RespuestaDto
                {
                    Exito = true,
                    Mensaje = "Persona eliminada con éxito",
                };

            }
            catch (Exception ex)
            {
                return RespuestaDto.ErrorInterno();
            }
        }
        public async Task<IEnumerable<Persona>> GetAllPersonasAsync()
        {
            return await _personaRepository.GetAllAsync();
        }
        public async Task<Persona> GetPersonaByIdAsync(int id)
        {
            return await _personaRepository.GetByIdAsync(id);
        }
        public async Task<RespuestaDto> UpdatePersonaAsync(Persona persona)
        {
            try
            {
                await _personaRepository.UpdateAsync(persona);
                return new RespuestaDto
                {
                    Exito = true,
                    Mensaje = "Persona actualizada con éxito",
                    Detalle = "La persona ha sido actualizada con éxito",
                    Resultado = persona
                };
            }
            catch (Exception ex)
            {
                return RespuestaDto.ErrorInterno();
            }
        }
    }
}
