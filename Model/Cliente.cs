using System.ComponentModel.DataAnnotations;

namespace intentocuatro.Model
{
    public class Cliente
    {
        [Key]
        [Required]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Cedula_Nit { get; set; }
        public string Profesion { get; set; }

        public string MatriculaProfesional { get; set; }
        public string CorreoElectronico { get; set; }
        public int NumeroCelular { get; set; }

        public string TipoCliente { get; set; }


    }
}
