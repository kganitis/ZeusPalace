using System;

namespace ZeusPalace.Entities.Accommodation
{
    public abstract class Accommodation
    {
        public string Id;
        public abstract AccommodationType Type { get; }

        protected static Random random = new Random();

        public abstract string GenerateId();
    }
}
