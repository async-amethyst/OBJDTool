using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJDTool.classes
{
    public class Section12Pair
    {
        public Section1Entry[] Section1Entries;
        public Section2Entry[] Section2Entries;
        public Section12Pair(int Sec1Size, int Sec2Size)
        {
            Section1Entries = new Section1Entry[Sec1Size];
            Section2Entries = new Section2Entry[Sec2Size];
        }
    }
}
