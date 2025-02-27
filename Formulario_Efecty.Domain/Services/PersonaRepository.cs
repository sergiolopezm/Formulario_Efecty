using Formulario_Efecty.Domain.Contracts;
using Formulario_Efecty.Infrastructure;

namespace Formulario_Efecty.Domain.Services
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly DBContext _context;

        public PersonaRepository(DBContext context)
        {
            _context = context;
        }

        public async Task<Persona> CreateAsync(Persona persona)
        {
            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();
            return persona;
        }

        public async Task DeleteAsync(int id)
        {
            var persona = await GetByIdAsync(id);
            _context.Personas.Remove(persona);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Persona>> GetAllAsync()
        {
            return _context.Personas;
        }

        public async Task<Persona> GetByIdAsync(int id)
        {
            return _context.Personas.FirstOrDefault(x => x.Id == id);
        }

        public async Task UpdateAsync(Persona persona)
        {
            _context.Personas.Update(persona);
            await _context.SaveChangesAsync();
        }
    }
}
