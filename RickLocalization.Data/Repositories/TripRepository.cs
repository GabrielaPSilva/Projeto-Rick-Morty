using RickLocalization.Data.Context;
using RickLocalization.Data.Entities;
using RickLocalization.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Data.Repositories
{
    public class TripRepository : RepositoryBase<Trip>, ITripRepository
    {
        public TripRepository(DataContext db) : base(db)
        {
        }
    }
}
