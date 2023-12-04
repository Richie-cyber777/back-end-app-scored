using System.ComponentModel.DataAnnotations;

namespace IonicWs.Models
{
    public class Competition
    {
        [Key] 
        public int idCompetition { get; set; }
        public string nomCompetition {  get; set; } 
        
        //navigation property
        //public virtual ICollection<Equipe> equipes { get; set; }

    }
}
