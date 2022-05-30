using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJDTool.parse
{
    internal class OBJDReader : BinaryReader
    {
        public OBJDReader(System.IO.Stream stream) : base(stream) { }

        public Int16 ReadShort()
        {
            var data = base.ReadBytes(2);
            return BitConverter.ToInt16(data, 0);
        }
        public override int ReadInt32()
        {
            var data = base.ReadBytes(4);
            /*Array.Reverse(data);*/
            return BitConverter.ToInt32(data, 0);
        }
        public string ReadMagic()
        {
            var data = base.ReadBytes(4);
            char[] data2 = Encoding.UTF8.GetChars(data);
            Array.Reverse(data2);
            return new string(data2);
        }
    }
}
