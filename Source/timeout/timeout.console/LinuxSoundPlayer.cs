using System.Diagnostics;

namespace timeout.console;

public class LinuxSoundPlayer : ISoundPlayer
{
    public void PlaySound(string filePath)
    {
        if (!File.Exists("/usr/bin/aplay"))
        {
            Console.WriteLine("Couldn't find 'aplay'. You may need to install it (typically 'sudo apt-get install alsa-utils').");
            return;
        }

        var psi = new ProcessStartInfo
        {
            FileName = "aplay",
            Arguments = filePath,
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        var process = Process.Start(psi);
        process.WaitForExit();
    }
}