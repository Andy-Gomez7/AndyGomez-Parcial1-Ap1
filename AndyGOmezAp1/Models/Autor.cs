using System.ComponentModel.DataAnnotations;

namespace AndyGOmezAp1.Models;

public class Autor
{
    [Key]
    public int AutorId { get; set; }
    [Required (ErrorMessage ="Este campo es requerido")]
    public String? Nombres { get; set; }
    [Required (ErrorMessage="Este campo es requerido")]
    public String? Nacionalidad { get; set ;}
    [Required(ErrorMessage ="Este campo es requerido")]
    public DateOnly FechaNacimiento { get; set; }
    [Required(ErrorMessage ="Este campo es requerido")]
    public Double Sueldo { get; set; }
}