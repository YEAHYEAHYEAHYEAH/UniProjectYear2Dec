using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TrainFinder.Models;

namespace TrainFinder.DataLayer
{
    public partial class TrainFinderDBEntities : DbContext
    {
        public TrainFinderDBEntities() : base("name=TrainFinderDBEntities")
        {
        }

        public virtual DbSet<Train> Trains { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
    }
}
