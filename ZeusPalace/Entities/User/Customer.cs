using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZeusPalace.Entities.Accommodation;

namespace ZeusPalace
{
    public class Customer : User
    {
        public override UserRole Role => UserRole.Customer;
        public Accommodation Accommodation { get; }
        public decimal Balance { get; set; }

        public Customer(string name, Accommodation accommodation, decimal initialBalance=0)
        {
            Name = name;
            Username = GenerateUsernameFromName(Name);
            Password = accommodation.Id;
            Accommodation = accommodation;
            Balance = initialBalance;
        }
    }
}
