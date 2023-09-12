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
        public Accommodation Accommodation { get; }
        public decimal Balance { get; set; }

        public Customer(string name, Accommodation accommodation)
        {
            Name = name;
            Accommodation = accommodation;
            Balance = 0;
        }

        public void AddToBalance(decimal amount)
        {
            Balance += amount;
        }
    }
}
