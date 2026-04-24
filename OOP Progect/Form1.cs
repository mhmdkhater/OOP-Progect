namespace OOP_Progect
{
    using System.Drawing.Drawing2D;

    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            string[] messages = {
                "Start now ... your future is waiting 🥇",
                "Stay focused. You're closer than you think ❤️",
                "Discipline beats motivation every time 🔥",
                "One hour of focus can change your day ⏳",
                "Don't quit now… you're building something great 😎",
                "Focus on your goal, not your distractions 🎯",
                "Small steps every day = big results 💯",
                "You don't need more time… you need more focus ⚡"
            };

            Random random = new Random();
            labelMotivation.Text = messages[random.Next(messages.Length)];

            SetRoundedRegion(panel3, 30);
        }

        private void SetRoundedRegion(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            path.CloseAllFigures();
            control.Region = new Region(path);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Enter your name ❤️ ");
                return;
            }

            string userName = textBoxName.Text;

            SessionForm form = new SessionForm(userName);
            form.Show();
            this.Hide();
        }
    }
}