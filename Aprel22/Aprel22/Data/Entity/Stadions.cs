using System;
using System.Collections.Generic;
using System.Text;

namespace Aprel22.Data.Entity
{
    public class Stadions
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal HourPrice { get; set; }
        public int Capacity { get; set; }
    }
}
