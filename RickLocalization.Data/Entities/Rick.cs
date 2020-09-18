using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RickLocalization.Data.Entities
{
    public class Rick
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Dimensao")]
        public int IdDimensao { get; set; }
        public virtual Dimension Dimensao { get; set; }

        [ForeignKey("Morty")]
        public int IdMorty { get; set; }     
        public virtual Morty Morty { get; set; }
    }
}
