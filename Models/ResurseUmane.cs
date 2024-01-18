using System.ComponentModel.DataAnnotations;

namespace Fanca_Loredana_Madalina.Models
{
    public class ResurseUmane
    {
        public int ID { get; set; }

        [Display(Name = "Nume Prenume")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Minim 5 caractere."), MaxLength(30, ErrorMessage = " Maxim 60 de caractere.")]
        public string Nume_Prenume { get; set; }


        [Display(Name = "Functie")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(5, ErrorMessage = "Minim 5 caractere."), MaxLength(30, ErrorMessage = " Maxim 60 de caractere.")]
        public string Functie { get; set; }


        [Display(Name = "Numar de telefon")]
        [Required(ErrorMessage = "Camp obligatoriu."), MinLength(10, ErrorMessage = "Minim 10 caractere."), MaxLength(10, ErrorMessage = " Maxim 10 de caractere.")]

        public string Numar_Telefon { get; set; }
        [Display(Name = "Studii Sperioare")]
        public int StudiiSuperioareID { get; set; }
        public StudiiSuperioare? StudiiSuperioare { get; set; }

        [Display(Name = "Candidat")]
        public int? CandidatiID { get; set; }
        public Candidati? Candidati { get; set; }
        public ICollection<CandidatiResurseUmane>? CandidatResursaUmane { get; set; }
    }
}
