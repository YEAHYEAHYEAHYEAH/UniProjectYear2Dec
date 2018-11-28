using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainFinder.Models
{
    public class Seat
    {
        public int SeatId;
        public virtual Train Train { get; set; }
        public int SeatNumber;
        public string CoachId;
    }
}
