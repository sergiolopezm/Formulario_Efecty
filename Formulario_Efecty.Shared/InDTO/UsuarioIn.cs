namespace Formulario_Efecty.Shared.InDTO
{
    public class UsuarioIn
    {
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? EstadoCivil { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public decimal? ValorGanar { get; set; }
    }
}
