namespace ZeusPalace.Modules.Orders
{
    public partial class EmployeeChatForm : ZeusPalace.Modules.Orders.ChatForm
    {
        public EmployeeChatForm()
        {
            InitializeComponent();
        }

        public EmployeeChatForm(string customerName) : this()
        {
            labelUsername.Text = customerName;
        }
    }
}
