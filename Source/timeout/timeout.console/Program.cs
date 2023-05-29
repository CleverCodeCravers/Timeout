using System.Runtime.InteropServices;

namespace timeout.console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("You must provide 2 arguments: duration in minutes and the path to the sound file.");
                return;
            }

            if (!int.TryParse(args[0], out int duration))
            {
                Console.WriteLine("The first argument must be an integer representing duration in minutes.");
                return;
            }

            string filePath = args[1];
            if (!File.Exists(filePath))
            {
                Console.WriteLine("The file at the provided path does not exist.");
                return;
            }

            ISoundPlayer player;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                player = new WindowsSoundPlayer();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                player = new LinuxSoundPlayer();
            }
            else
            {
                Console.WriteLine("Unsupported operating system.");
                return;
            }

            // Play the sound at the beginning to test
            player.PlaySound(filePath);

            // Start countdown
            TimeSpan timer = TimeSpan.FromMinutes(duration);
            while (timer > TimeSpan.Zero)
            {
                Console.Write("\rCountdown: {0}", timer.ToString(@"mm\:ss"));
                Thread.Sleep(1000);
                timer = timer.Add(TimeSpan.FromSeconds(-1));
            }

            // Play the sound when time is up
            player.PlaySound(filePath);

            Console.WriteLine("\nCountdown finished.");
        }
    }
}
