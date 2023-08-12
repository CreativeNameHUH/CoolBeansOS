namespace WindowsBuildTool
{
    internal class BuildFile
    {
        private const string FILE_PATH = @"BuildCommands.bat";
        private const string LINKER_PATH = @"linker.ld";

        private readonly string _bootPath;
        private readonly string _kernelPath;

        private string _nasmParams = " -f elf32";
        private string _gccParams = " -m32 -static -fno-asynchronous-unwind-tables -nostdlib -nodefaultlibs";

        public BuildFile(string bootPath, string kernelPath)
        {
            _bootPath = bootPath;
            _kernelPath = kernelPath;
        }

        public string? MakeFile()
        {
            if (!File.Exists(LINKER_PATH))
            {
                StreamWriter linkerFile = new StreamWriter(LINKER_PATH);
                linkerFile.Write("ENTRY (_START)\n\nSECTIONS\n{\n\t. = 0x7c00;\n\t.text :\n\t{\n\t\t*(.text);\n\t}\n}\n");
                linkerFile.Close();
            }

            if (Common.Settings == null)
                return null;

            if (File.Exists(FILE_PATH))
                File.Delete(FILE_PATH);

            StreamWriter buildFile = new StreamWriter(FILE_PATH);

            if (Common.Settings.IsWErrorEnabled)
            {
                _nasmParams += " -Werror";
                _gccParams  += " -Werror";
            }

            if (Common.Settings.IsWAllEnabled)
            {
                _nasmParams += " -Wall";
                _gccParams += " -Wall";
            }

            buildFile.WriteLine(GetTitle());
            AddBootFiles(buildFile);
            AddKernelFiles(buildFile);
            
            if (Common.Settings.IsVBoxEnabled)
                buildFile.WriteLine("\nVBoxManage convertfromraw build\\bootloader.bin build\\bootloader.vdi --format VHD");

            buildFile.Close();
            return FILE_PATH;
        }

        // TODO: We are assuming that the boot.asm exists. Should be checked
        private void AddBootFiles(StreamWriter buildFile)
        {
            buildFile.WriteLine("\n:: === BOOT COMPILE COMMANDS ===\n");

            string buildPath = _bootPath.Replace("\\src", "\\build");
            buildFile.WriteLine("rd /s /q \"" + buildPath + "\"");
            buildFile.WriteLine("mkdir \"" + buildPath + "\"\n");

#pragma warning disable CS8602 // Null dereference is not possible. We are checking for null in MakeFile() function
            string begin = "\"" + Common.Settings.NasmPath + "\\nasm\"" + _nasmParams + "\" ";
#pragma warning restore CS8602

            string[] files = Directory.GetFiles(_bootPath);
            string[] objFiles = new string[files.Length];
            for (int index = 0; index < files.Length; index++)
            {
                string objFilePath = files[index].Replace("asm", "obj");
                objFilePath = objFilePath.Replace("\\src\\", "\\build\\");
                
                objFiles[index] = objFilePath;

                buildFile.WriteLine(begin + files[index] + "\" -o \"" + objFilePath + "\"");
            }
            
            buildFile.WriteLine("");

            // Align files, boot.obj has to be the first file
            string firstFile = objFiles[0];
            for (int index = 1; index < objFiles.Length; index++)
            {
                if (objFiles[index] != "build.obj") continue;
                
                objFiles[0] = "build.obj";
                objFiles[index] = firstFile;
            }

            buildFile.Write("\"" + Common.Settings.GccPath +
                            "\\gcc\"" + _gccParams);
            foreach (string file in objFiles)
                buildFile.Write(" \"" + file + "\"");

            buildFile.Write(" -T linker.ld -o \"" + buildPath + "\\bootloader.bin\"\n");
            buildFile.WriteLine("objcopy -O binary \"" + buildPath + "\\linked_bootloader.bin\" \"" + buildPath + "\\bootloader.bin\"\n");

            foreach (string file in objFiles)
                buildFile.WriteLine("del /f /q \"" + file + "\"");
        }

        private void AddKernelFiles(StreamWriter buildFile)
        {
            buildFile.WriteLine("\n:: === KERNEL COMPILE COMMANDS ===\n");

            string buildPath = _kernelPath.Replace("\\src", "\\build");
            buildFile.WriteLine("rd /s /q \"" + buildPath + "\"");
            buildFile.WriteLine("mkdir \"" + buildPath + "\"\n");
        }

        private static string GetTitle()
        {
            return ":: === AUTO GENERATED COMPILE COMMANDS AT: " + DateTime.Now + " ===";
        }

        private static string GetFilename(string file)
        {
            string filename = "";

            for (int index = 0; index < file.Length - 4; index++)
                filename += file[index];

            return filename;
        }
    }
}
