using System.ComponentModel.DataAnnotations;

namespace Fanca_Loredana_Madalina.Models
{
    public class StudiiSuperioare
    {
        public int ID { get; set; }
        [Display(Name = "Facultate")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Minim 5 caractere."), MaxLength(30, ErrorMessage = " Maxim 60 de caractere.")]
        public string Facultate { get; set; }
        [Display(Name = "Specializare")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Minim 5 caractere."), MaxLength(30, ErrorMessage = " Maxim 60 de caractere.")]
        public string Specializare { get; set; }
        public ICollection<ResurseUmane>? Resurse_Umane { get; set; }
    }
}
