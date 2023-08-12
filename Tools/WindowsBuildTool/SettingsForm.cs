namespace WindowsBuildTool
{
    public partial class SettingsForm : Form
    {
        private bool _error;
        private readonly Form _parent;

        public SettingsForm(Form parent)
        {
            InitializeComponent();

            _parent = parent;
            _parent.Visible = false;

            if (Environment.GetEnvironmentVariable(@"VBoxManage") == null)
            {
                VBoxCheckBox.Enabled = false;
                VBoxCheckBox.Checked = false;
            }

            if (Common.Settings is null)
                return;

            MsysPathTextBox.Text = Common.Settings.MsysPath;
            GccPathTextBox.Text  = Common.Settings.GccPath;
            NasmPathTextBox.Text = Common.Settings.NasmPath;

            VBoxCheckBox.Checked = Common.Settings.IsVBoxEnabled;
            WErrorCheckBox.Checked = Common.Settings.IsWErrorEnabled;
            WAllCheckBox.Checked = Common.Settings.IsWAllEnabled;
        }

        private void MsysSelectButton_Click(object sender, EventArgs e)
        {
            _error = Common.ButtonHandler(MsysSelectButton, MsysPathTextBox);
        }

        private void GccSelectButton_Click(object sender, EventArgs e)
        {
            _error = Common.ButtonHandler(GccSelectButton, GccPathTextBox);
        }

        private void NasmSelectButton_Click(object sender, EventArgs e)
        {
            _error = Common.ButtonHandler(NasmSelectButton, NasmPathTextBox);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_error)
            {
                MessageBox.Show(@"Fix invalid path.", @"Error");
                return;
            }

            Common.Settings = new BuildToolsSettings(MsysPathTextBox.Text,
                GccPathTextBox.Text,
                NasmPathTextBox.Text)
            {
                IsVBoxEnabled = VBoxCheckBox.Checked,
                IsWErrorEnabled = WErrorCheckBox.Checked,
                IsWAllEnabled = WAllCheckBox.Checked
            };

            if (!Common.SaveBuildToolsPaths())
                throw new Exception("Error when saving.");

            if (_parent is NoConfigForm)
                _parent.Close();
            else
                _parent.Visible = true;

            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            _parent.Visible = true;
            Close();
        }

        private void VBoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // does nothing.
        }
    }
}
