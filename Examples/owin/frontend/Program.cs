using Microsoft.Owin.Hosting;
using System;

namespace frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:6001/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Start server on {0}", baseAddress);
                Console.ReadLine();
            }
        }
    }
}
