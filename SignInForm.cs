namespace Project_TSP_21621541
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogInForm logform = new LogInForm();
            this.Hide();
            logform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm regform = new RegisterForm();
            this.Hide();
            regform.Show();
        }
    }
}