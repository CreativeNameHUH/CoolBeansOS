using Newtonsoft.Json;
using File = System.IO.File;

namespace WindowsBuildTool
{
    internal class BuildToolsSettings
    {
        public string MsysPath;
        public string GccPath;
        public string NasmPath;

        public bool IsVBoxEnabled;
        public bool IsWErrorEnabled;
        public bool IsWAllEnabled;

        public BuildToolsSettings()
        {
            MsysPath = @"C:\msys64";
            GccPath = @"C:\msys64\mingw64\bin";
            NasmPath = @"C:\Program Files\NASM";
        }

        public BuildToolsSettings(string msysPath, string gccPath, string nasmPath)
        {
            MsysPath = msysPath;
            GccPath = gccPath;
            NasmPath = nasmPath;
        }
    }

    internal static class Common
    {
        public static BuildToolsSettings? Settings;

        private const string SETTINGS_PATH = @"BuildToolsSettings.json";

        public static bool LoadBuildToolsPaths()
        {
            if (!File.Exists(SETTINGS_PATH))
                return false;

            string jsonString = File.ReadAllText(SETTINGS_PATH);
            Settings = JsonConvert.DeserializeObject<BuildToolsSettings>(jsonString);

            return Settings is not null;
        }

        public static bool SaveBuildToolsPaths()
        {
            if (Settings is null)
                return false;

            string jsonString = JsonConvert.SerializeObject(Settings);
            File.WriteAllText(SETTINGS_PATH, jsonString);
            return true;
        }

        public static string? GetPath()
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            DialogResult result = browse.ShowDialog();

            if (result != DialogResult.OK || string.IsNullOrWhiteSpace(browse.SelectedPath))
                return null;

            return browse.SelectedPath;
        }

        public static bool ButtonHandler(Button button, TextBox textBox)
        {
            bool error = false;
            Color color = Color.DarkSeaGreen;

            string? path = Common.GetPath();
            if (path == null)
            {
                color = Color.IndianRed;
                path = @"Error: Wrong path!";
                error = true;
            }
            else if (Directory.GetFiles(path).Length == 0)
            {
                color = Color.IndianRed;
                path = @"Error: Directory is empty!";
                error = true;
            }

            button.BackColor = color;
            textBox.BackColor = color;
            textBox.Text = path;

            return error;
        }
    }
}
