using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJDTool.parse
{
    internal class Initialize
    {
        public static string LoadPath()
        {
            return File.ReadAllText(@"resrc/path.conf");
        }
    }
}
