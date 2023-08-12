namespace WindowsBuildTool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            if (!Common.LoadBuildToolsPaths())
            {
                Application.Run(new NoConfigForm());
            }

            Application.Run(new MainForm());
        }
    }
}
