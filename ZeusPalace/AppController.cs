using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeusPalace.Modules;
using ZeusPalace.Modules.PoolControl;

namespace ZeusPalace
{
    public class AppController
    {
        private static AppController instance;

        private MainForm mainForm;

        public event EventHandler CurrentFormChanged;

        public EmbeddedForm CurrentForm => mainForm.CurrentForm;

        public Customer Customer { get; internal set; }

        public Employee Employee { get; internal set; }

        public int Time { get; internal set; }

        public DateTime DateTime { get; internal set; }

        public void SetPersonInPool(bool personInPool)
        {
            mainForm.SetPersonInPool(personInPool);
        }

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
    }
}
