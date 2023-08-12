// TODO: Settings should be saved too

using Newtonsoft.Json;

namespace WindowsBuildTool
{
    public partial class MainForm : Form
    {
        public string[]? files;

        private bool _error;
        private readonly ConsoleHandler? _consoleHandler;

        public MainForm()
        {
            InitializeComponent();

            _consoleHandler = ConsoleHandler.Instance;
        }

        private void BootSelectButton_Click(object sender, EventArgs e)
        {
            _error = Common.ButtonHandler(BootSelectButton, BootPathTextBox);
        }

        private void KernelSelectButton_Click(object sender, EventArgs e)
        {
            _error = Common.ButtonHandler(KernelSelectButton, KernelPathTextBox);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(this);
            settings.Show();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            if (_error)
            {
                MessageBox.Show(@"Fix invalid path.", @"Error");
                return;
            }

            BuildFile buildCommands = new BuildFile(BootPathTextBox.Text, KernelPathTextBox.Text);
            string? buildFile = buildCommands.MakeFile();
            if (buildFile == null)
            {
                OutputTextBox.Text = @"ERROR! Could not create build file!";
                return;
            }

            if (_consoleHandler == null)
            {
                OutputTextBox.Text = @"ERROR! Could not set console output!\n";
                return;
            }

            OutputTextBox.Text += _consoleHandler.Command(".\\" + "BuildCommands.bat") + "\n";
        }

        private void BootSettingsButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConsoleHandler.Dispose();
        }
    }
}