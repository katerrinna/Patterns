using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structure.Facade
{
    public class StreamWriterFacade
    {
        public static void Write(string line, string filename)
        {
            if (File.Exists(filename))
            {
                using (StreamWriter sw = new StreamWriter(File.OpenWrite(filename)))
                {
                    sw.WriteLine(line);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(File.Create(filename)))
                {
                    sw.WriteLine(line);
                }
            }
        }
    }
}
