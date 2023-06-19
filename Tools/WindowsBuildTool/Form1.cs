// TODO: Paths should be saved too

namespace WindowsBuildTool
{
    public partial class MainForm : Form
    {
        private bool _error;
        private TextBoxWriter? _consoleOutput;

        public MainForm()
        {
            InitializeComponent();
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
            if (buildCommands.MakeFile() == null)
                OutputTextBox.Text = @"ERROR!";
        }
    }
}