using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Accommodation
{
    internal abstract class Accommodation
    {
        public string Id { get; set; }
        public abstract AccommodationType Type { get; }
    }
}
