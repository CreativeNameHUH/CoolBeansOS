namespace WindowsBuildTool
{
    public partial class SelectFilesForm : Form
    {
        private readonly MainForm _parent;

        public SelectFilesForm(Form parent, ref string filesPath)
        {
            InitializeComponent();
            FileCheckListBox.Items.Clear();

            _parent = (MainForm) parent;
            _parent.Hide();

            string[] files = Directory.GetFiles(filesPath);
            foreach (string file in files)
                FileCheckListBox.Items.Add(file);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            string[] files = new string[FileCheckListBox.CheckedItems.Count];

            int index = 0;
            foreach (object file in FileCheckListBox.CheckedItems)
            {
                files[index] = (string) file;
                index++;
            }
            
            _parent.files = files;
            _parent.Show();
            
            Close();
        }
    }
}
