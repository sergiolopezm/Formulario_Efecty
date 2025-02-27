namespace Formulario_Efecty.Shared.InDTO
{
    public class UsuarioOut
    {
        public int Id { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? EstadoCivil { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public decimal? ValorGanar { get; set; }
        public bool Estado { get; set; }
        public DateTime? FechaRegistro { get; set; }


    }
}
