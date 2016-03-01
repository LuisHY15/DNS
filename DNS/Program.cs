using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;



namespace DNS
{
    class Program
    {   
        class ACTDNS
        {   
            
            public void host(string hostname)
            {
                IPHostEntry host;

                host = Dns.GetHostEntry(hostname);

                Console.WriteLine("GetHostEntry({0}) returns:", hostname);

                foreach (IPAddress ip in host.AddressList)
                {
                    Console.WriteLine("{0}", ip);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--------------------PRUEBA -------------------");
            string result;
        

            result = System.Net.Dns.GetHostByName("LocalHost").HostName;

            Console.WriteLine("DNS Name = {0}", result);


            const string fic = @"X:\DNS\DNS.txt";
            string escribir = "DNS rodolfo.";
            string leer = "";

            StreamReader sr = new StreamReader(fic);
            leer = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine("---------------LEER ARCHIVO CON DNS---------------");
            Console.WriteLine(leer);

            if(result != leer)
            {
                StreamWriter sw = new StreamWriter(fic, true);
                sw.WriteLine(escribir);
                sw.Close();
                Console.WriteLine("---------------ESCRIBIR DNS SI NO ESTA ---------------");
                Console.WriteLine(escribir);
            }
            else
            {
               
            }

         

    
            Console.ReadKey();

        }
    }
}
