using System.Diagnostics;

namespace WindowsBuildTool
{
    internal class ConsoleHandler
    {
        private static ConsoleHandler? instance;
        public static ConsoleHandler Instance => instance ??= new ConsoleHandler();

        public static void Dispose()
        {
            if (instance == null)
                return;

            instance._cmd?.WaitForExit();
            instance = null;
        }

        private readonly Process? _cmd;

        private ConsoleHandler()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"cmd")
            {
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            _cmd = new Process();
            _cmd.StartInfo = startInfo;
            _cmd.Start();
        }

        public string? Command(string command, bool readOutput = true)
        {
            if (_cmd == null)
                return null;

            _cmd.StandardInput.WriteLine(command);
            _cmd.StandardInput.Flush();
            _cmd.StandardInput.Close();
            _cmd.WaitForExit();

            string output = readOutput ? _cmd.StandardOutput.ReadToEnd() : string.Empty;
            
            _cmd.Start();
            return output;
        }

        public string? ReadLine()
        {
            return _cmd?.StandardOutput.ReadLine();
        }

        public string? ReadConsole()
        {
            return _cmd?.StandardOutput.ReadToEnd();
        }
    }
}
