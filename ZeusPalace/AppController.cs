using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeusPalace.Modules;
using ZeusPalace.Modules.PoolControl;

namespace ZeusPalace
{
    public class AppController
    {
        private static AppController instance;

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

        private MainForm mainForm;

        public event EventHandler CurrentFormChanged;
        public event EventHandler TimeChanged;
        public event EventHandler PersonInPoolChanged;

        public EmbeddedForm CurrentForm => mainForm.CurrentForm;

        public Customer Customer { get; internal set; }

        public Employee Employee { get; internal set; }

        public User User { get; internal set; }

        public ComputerType ComputerType { get; internal set; }

        private DateTime dateTime;
        public DateTime DateTime
        {
            get => dateTime;
            internal set
            {
                dateTime = value;
                TimeChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private bool personInPool;
        public bool PersonInPool
        {
            get => personInPool;
            internal set
            {
                personInPool = value;
                PersonInPoolChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        internal void StartApplication()
        {
            if (mainForm != null)
            {
                mainForm.Close();
                mainForm.Dispose();
            }
            mainForm = new MainForm();
            mainForm.CurrentFormChanged += MainForm_CurrentFormChanged;
            mainForm.Show();
        }

        private void MainForm_CurrentFormChanged(object sender, EventArgs e)
        {
            CurrentFormChanged?.Invoke(this, e);
        }

        public int TimeAsInt()
        {
            int hours = dateTime.Hour;
            int minutes = dateTime.Minute;
            int timeAsInt = (hours * 100) + minutes;

            return timeAsInt;
        }
    }
}
