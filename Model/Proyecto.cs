using System.ComponentModel.DataAnnotations;

namespace intentocuatro.Model
{
    public class Proyecto
    {
        [Key]
        [Required]
        public int ProyectoId { get; set; }
        public int NroContrato { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string TipoObra { get; set; }
        public int Valor { get; set; }


    }
}
