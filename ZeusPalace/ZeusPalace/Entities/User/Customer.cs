using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZeusPalace.Entities.Accommodation;

namespace ZeusPalace
{
    internal class Customer : User
    {
        public override UserRole Role => UserRole.Customer;
        public Accommodation accommodation { get; }

        public Customer(string name, Accommodation accommodation)
        {
            Name = name;
            this.accommodation = accommodation;
        }
    }
}
