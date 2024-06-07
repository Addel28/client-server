using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using client_server;
using System.ServiceModel;
namespace WCF_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8733/Design_Time_Addresses/client_server/Service1/x");
            using (ServiceHost host = new ServiceHost(typeof(Service1), baseAddress))
            {
                host.Open();
                Console.WriteLine("Сервис запущен.");
                Console.WriteLine("Нажмите Enter для остановки сервиса...");
                Console.ReadLine();

                host.Close();

            }
        }
    }
}