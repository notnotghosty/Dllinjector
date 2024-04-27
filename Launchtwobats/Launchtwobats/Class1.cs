using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

class Class1
{
    static void Main(string[] args)
    {
        // Get the directory of the current executable
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

        // Specify the relative paths to your executables (batch files, exe, anything you want to execute)
        string batchFileName = "Launcher.bat";
        string dllInjectorName = "Dllinjector.exe";

        // Combine the directory with the file names to get the full paths
        string batchFilePath = Path.Combine(currentDirectory, batchFileName);
        string dllInjectorPath = Path.Combine(currentDirectory, dllInjectorName);

        // Start the batch file
        Process.Start(batchFilePath);

        // Wait for 20 seconds (20000 milliseconds)
        Thread.Sleep(20000); // Wait for 20 seconds

        // Start Dll Injector
        Process.Start(dllInjectorPath);
    }
}