using System;
using System.Drawing;
using System.Net.Sockets;

namespace PortScan
{
   class Program
   {
      private static string IP = "";

      static void Main(string[] args)
      {
         UserInput();
         PortScan();
         Console.ReadKey();
      }

      private static void UserInput()
      {
         Console.WriteLine("IP Address:", Color.Lime);
         IP = Console.ReadLine();
      }

      private static void PortScan()
      {
         Console.Clear();
         TcpClient Scan = new TcpClient();
         foreach (int s in Ports)
         {
            using (TcpClient scan = new TcpClient())
            {
               try
               {
                  scan.Connect(IP, s);
                  Console.WriteLine($"[{s}] | OPEN", Color.Green);
               }
               catch
               {
                  Console.WriteLine($"[{s}] | CLOSED", Color.Red);
               }
            }
         }
      }

      private static int[] Ports = new int[]
      {
        8080,
        51372,
        31146,
        4145,
         80,
         21,
         22
      };
   }
}
