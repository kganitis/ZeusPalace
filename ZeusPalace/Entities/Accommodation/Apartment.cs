using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Accommodation
{
    internal class Apartment : Accommodation
    {
        public override AccommodationType Type => AccommodationType.Apartment;

        public Apartment()
        { 

        }
    }
}
