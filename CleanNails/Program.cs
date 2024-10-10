using CleanNails.HelperClasses;

namespace CleanNails
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            NailSaloon nailAndBeauty = new NailSaloon("Nail And Beauty");

            AppManager manager = new AppManager(nailAndBeauty);

            manager.Run();
        }
    }
}