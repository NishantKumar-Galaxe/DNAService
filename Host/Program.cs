using System;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ClassLibrary1.SimpleService)))
            {
                host.Open();
                Console.WriteLine($"Host started @ {DateTime.Now}");
                Console.ReadLine();
            }
        }
    }
}
