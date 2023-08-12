namespace WindowsBuildTool
{
    public partial class NoConfigForm : Form
    {
        public NoConfigForm()
        {
            InitializeComponent();
            Common.Settings = new BuildToolsSettings();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            if (!Common.SaveBuildToolsPaths())
                throw new Exception("Could not save settings");

            Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(this);
            settings.Show();
        }
    }
}
