using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainFinder.Models
{
    public class Train
    {
        public int TrainId { get; set; }
        public virtual Station DepartureStation { get; set; }
        public virtual Station DestinationStation { get; set; }
        public ICollection<Seat> takenSeats { get; set; }
        public DateTime departureDateTime;
    }
}
