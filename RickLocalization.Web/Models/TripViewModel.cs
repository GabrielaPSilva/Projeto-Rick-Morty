using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Web.Models
{
    public class TripViewModel
    {
        public int Id { get; set; }
        public int IdDimensao { get; set; }
        public int IdRick { get; set; }
        public string Descricao { get; set; }
    }
}
