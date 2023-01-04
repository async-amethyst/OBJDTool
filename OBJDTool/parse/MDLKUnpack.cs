using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJDTool.parse
{
    internal class MDLKUnpack
    {
        public static void BatchUnpackMDLK()
        {
            string[] MDLKFiles = File.ReadAllLines(@"resrc/mdlkname.txt");
            foreach(string MDLKFile in MDLKFiles)
            {
                if(MDLKFile == "NULL")
                {
                    continue;
                }
            }
        }
    }
}
