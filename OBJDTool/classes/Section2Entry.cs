using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace OBJDTool.classes
{
    public class Section2Entry
    {
        public Vector4 Scale { get; set; }
        public Vector4 Rotation { get; set; }
        public Vector4 Position { get; set; }
        public short Entry { get; set; }
    }
}
