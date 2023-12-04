namespace Shutdown_Prompt
{
    using System.Diagnostics;

    public partial class FormMain : Form
    {
        private readonly DateTime appShutdown = DateTime.Now.AddMinutes(10);

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now > appShutdown)
            {
                Shutdown();
            }

            TimeDisplay.Text = $"System shutdown in {appShutdown - DateTime.Now:mm\\:ss}";
        }

        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            Shutdown();
        }

        private static void Shutdown()
        {
            ProcessStartInfo psi = new("shutdown", "/s /t 0")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(psi);
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
