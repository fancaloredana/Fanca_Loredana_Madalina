using System.ComponentModel.DataAnnotations;

namespace Fanca_Loredana_Madalina.Models
{
    public class Candidati
    {
        public int ID { get; set; }
        [Display(Name = "Nume Prenume Candidat")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Minim 5 caractere."), MaxLength(30, ErrorMessage = " Maxim 60 de caractere.")]
        public string Nume_Prenume { get; set; }

        [Display(Name = "GDPR Semnat")]
        [Required(ErrorMessage = "Camp obligatoriu.")]
        public Boolean GDPR { get; set; }

        [Display(Name = "Link Sharepoint Documente")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Minim 10 caractere."), MaxLength(30, ErrorMessage = " Maxim 100 de caractere.")]
        public string Documente { get; set; }

        [Display(Name = "Rol Companie")]
        public int? RolID { get; set; }
        public Roluri? Rol { get; set; }

        public ICollection<CandidatiResurseUmane>? CandidatResursaUmane { get; set; }
    }
}

