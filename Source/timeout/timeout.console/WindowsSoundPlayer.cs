using System.Diagnostics;

namespace timeout.console;

public class WindowsSoundPlayer : ISoundPlayer
{
    public void PlaySound(string filePath)
    {
        if (!File.Exists("powershell.exe"))
        {
            Console.WriteLine("Couldn't find 'powershell'. Please ensure it's installed and available in your PATH.");
            return;
        }

        var psi = new ProcessStartInfo
        {
            FileName = "powershell",
            Arguments = $"-c (New-Object Media.SoundPlayer \"{filePath}\").PlaySync()",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        var process = Process.Start(psi);
        process.WaitForExit();
    }
}