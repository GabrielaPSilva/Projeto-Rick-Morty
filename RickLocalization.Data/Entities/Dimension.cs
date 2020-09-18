using System.ComponentModel.DataAnnotations;

namespace RickLocalization.Data.Entities
{
    public class Dimension
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
