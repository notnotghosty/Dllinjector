using System;
using System.Diagnostics;
using System.Threading;

class Class1
{
    static void Main(string[] args)
    {
        // Specify the path to your batch file
        string batchFilePath = @"C:\Program Files\Destiny\58afdea4-c702-4b4e-995f-e98a4f7ed7ce\FortniteGame\Binaries\Win64\Launcher.bat";
        string DlllInjectorPath = @"C:\Program Files\Destiny\58afdea4-c702-4b4e-995f-e98a4f7ed7ce\FortniteGame\Binaries\Win64\Dllinjector.exe";

        // Start the batch file
        Process.Start(batchFilePath);

        // Wait for 20 seconds (20000 milliseconds)
        Thread.Sleep(20000); // Wait for 20 seconds

        //Start Dll Injector
        Process.Start(DlllInjectorPath);
    }
}