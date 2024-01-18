using System.ComponentModel.DataAnnotations;

namespace Fanca_Loredana_Madalina.Models
{
    public class Roluri
    {
        public int ID { get; set; }
        [Display(Name = "Rol Denumire")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Minim 5 caractere."), MaxLength(30, ErrorMessage = " Maxim 60 de caractere.")]
        public string DenumireRol { get; set; }
        [Display(Name = "Rol Companie")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Minim 5 caractere."), MaxLength(30, ErrorMessage = " Maxim 60 de caractere.")]
        public string Companie { get; set; }


        [Display(Name = "Link Sharepoint Documente")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Minim 10 caractere."), MaxLength(30, ErrorMessage = " Maxim 100 de caractere.")]
        public string Documente { get; set; }
        public Candidati? Candidat { get; set; }
    }
}
