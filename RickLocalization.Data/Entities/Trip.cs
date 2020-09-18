using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RickLocalization.Data.Entities
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }

        public int IdDimensao { get; set; }

        public int IdRick { get; set; }
        public string Descricao { get; set; }
    }
}