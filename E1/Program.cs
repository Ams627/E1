using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace E1
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                IKvStore store = new KvStore
                {
                    { "e", 1 }
                };

                foreach (var p in store)
                {
                    Console.WriteLine($"{p.Key} {p.Value}");
                }

            }
            catch (Exception ex)
            {
                var fullname = System.Reflection.Assembly.GetEntryAssembly().Location;
                var progname = Path.GetFileNameWithoutExtension(fullname);
                Console.Error.WriteLine($"{progname} Error: {ex.Message}");
            }

        }
    }
}
