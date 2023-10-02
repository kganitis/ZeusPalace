using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace
{
    internal abstract class User
    {
        public string Name { get; set; }
        public abstract UserRole Role { get; }

    }
}
