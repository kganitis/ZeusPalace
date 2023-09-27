using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace
{
    public class AppController
    {
        private static AppController instance;

        public Customer Customer { get; internal set; }

        public Employee Employee { get; internal set; }

        public int Time { get; internal set; }

        private AppController() { }

        public static AppController Instance
        {
            get
            {
                if (instance == null)
                    instance = new AppController();
                return instance;
            }
        }
    }
}
