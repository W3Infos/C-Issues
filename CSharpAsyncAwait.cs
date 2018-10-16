using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace AsyncCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");

            var smsohanDotCom = GetSmSohanDotCom();

            Console.WriteLine("Passed the get line, status {0}", smsohanDotCom.IsCompleted);            

            Console.WriteLine(smsohanDotCom.Result.Length);

            Console.WriteLine("Printed the length, status {0}", smsohanDotCom.IsCompleted);            

            Console.ReadLine();


        }

        private async static Task<String> GetSmSohanDotCom(){
            Console.WriteLine("Before Waiting...");
            var data =  await new WebClient().DownloadStringTaskAsync(new Uri("http://smsohan.com"));
            Console.WriteLine("Waiting...");
            return data;
        }

    }
}
