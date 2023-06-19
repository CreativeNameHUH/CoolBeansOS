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

            if (Common.Paths is null)
                return;

            MsysPathTextBox.Text = Common.Paths.MsysPath;
            GccPathTextBox.Text  = Common.Paths.GccPath;
            NasmPathTextBox.Text = Common.Paths.NasmPath;
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

            Common.Paths = new BuildToolsPaths(MsysPathTextBox.Text,
                                               GccPathTextBox.Text,
                                               NasmPathTextBox.Text);

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
    }
}
