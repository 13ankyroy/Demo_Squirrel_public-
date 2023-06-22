using Squirrel;

namespace SampleConsole
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            CheckForUpdates();

        }

        static async void CheckForUpdates()
        {
            using (var manager = await UpdateManager.GitHubUpdateManager(@"https://github.com/13ankyroy/Demo_Squirrel_public-"))
            {
                await manager.UpdateApp();
            }
        }
    }
}