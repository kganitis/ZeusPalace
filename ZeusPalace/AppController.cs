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
        private PublicPoolForm publicPoolForm;

        public event EventHandler CurrentFormChanged;
        public event EventHandler TimeChanged;
        public event EventHandler PersonInPoolChanged;

        public Form CurrentForm
        {
            get
            {
                if (publicPoolForm != null)
                {
                    return publicPoolForm;
                }
                if (mainForm.CurrentForm != null)
                {
                    return mainForm.CurrentForm;
                }
                return mainForm;
            }
        }

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
                mainForm = null;
            }
            if (publicPoolForm != null)
            {
                publicPoolForm.Close();
                publicPoolForm.Dispose();
                publicPoolForm = null;
            }

            if (ComputerType == ComputerType.PublicPool)
            {
                publicPoolForm = new PublicPoolForm();
                publicPoolForm.Show();
            }
            else
            {
                mainForm = new MainForm();
                mainForm.CurrentFormChanged += MainForm_CurrentFormChanged;
                mainForm.Show();
            }
            CurrentFormChanged?.Invoke(this, EventArgs.Empty);
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
