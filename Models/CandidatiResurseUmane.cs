namespace Fanca_Loredana_Madalina.Models
{
    public class CandidatiResurseUmane
    {
        public int ID { get; set; }
        public int ResurseUmaneID { get; set; }
        public ResurseUmane ResurseUmane { get; set; }
        public int CandidatiID { get; set; }
        public Candidati Candidati { get; set; }
    }
}
