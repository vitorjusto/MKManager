using MKManager.View;

namespace MKManager
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaMae());
        }
    }
}