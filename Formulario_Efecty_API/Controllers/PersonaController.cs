using Formulario_Efecty.Domain.Contracts;
using Formulario_Efecty.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Formulario_Efecty_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;
        public PersonaController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPersonasAsync()
        {
            var personas = await _personaService.GetAllPersonasAsync();
            return Ok(personas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonaByIdAsync(int id)
        {
            var persona = await _personaService.GetPersonaByIdAsync(id);
            return Ok(persona);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreatePersonaAsync(Persona persona)
        {
            var respuesta = await _personaService.CreatePersonaAsync(persona);
            return Ok(respuesta);
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdatePersonaAsync(Persona persona)
        {
            var respuesta = await _personaService.UpdatePersonaAsync(persona);
            return Ok(respuesta);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> DeletePersonaAsync(int id)
        {
            var respuesta = await _personaService.DeletePersonaAsync(id);
            return Ok(respuesta);
        }
    }
}