using System;
using System.Collections.Generic;
using System.Text;

namespace Aprel22.Data.Entity
{
    public class Reservations
    {
        public int Id { get; set; }
        public Stadions Stadion { get; set; }
        public int StadionId { get; set; }
        public Users User { get; set; }
        public int UserId { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
