using System;
using System.Collections.Generic;

namespace Formulario_Efecty.Infrastructure
{
    public partial class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public decimal ValorGanar { get; set; }
        public string EstadoCivil { get; set; } = null!;
        public DateTime? FechaRegistro { get; set; }
        public bool? Estado { get; set; }
    }
}
