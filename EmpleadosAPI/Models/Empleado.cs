using System.ComponentModel.DataAnnotations.Schema;

namespace EmpleadosAPI.Models
{
    public class Empleado{
       [Column("id")]
        public int Id {get; set;}
        [Column("nombre")]
        public string Nombre {get; set;}
        [Column("apellido")]
        public string Apellido {get; set;}
        [Column("tipo_documento")]
        public string TipoDocumento {get; set;}
        [Column("estado_civil")]
        public string EstadoCivil {get; set;}
        [Column("fecha_nacimiento")]
        public DateTime FechaNacimiento {get; set;}
        [Column("valor_a_ganar")]
        public decimal ValorAganar {get; set;}

    }
    
}