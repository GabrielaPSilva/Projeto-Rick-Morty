using RickLocalization.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Web.Models
{
    public class RickViewModel
    {
        public int Id { get; set; }
        public int IdDimensao { get; set; }
        public virtual Dimension Dimensao { get; set; }
        public int IdMorty { get; set; }
        public virtual Morty Morty { get; set; }
    }
}
