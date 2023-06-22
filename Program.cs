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
                Console.WriteLine(manager.CurrentlyInstalledVersion().ToString());
                var updateInfo = await manager.CheckForUpdate();
                if(updateInfo.ReleasesToApply.Count > 0) 
                {
                    await manager.UpdateApp();  
                }
                
            }
        }
    }
}