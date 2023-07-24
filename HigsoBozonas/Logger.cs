using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HigsoBozonas
{
    public static class Logger
    {
        public static void WriteLog(string msg)
        {
            string logPath = System.IO.Path.GetFullPath(@"..\..\..\")+"log.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(logPath, true))
                {
                    writer.WriteLine($"{DateTime.Now} : {msg}");
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
