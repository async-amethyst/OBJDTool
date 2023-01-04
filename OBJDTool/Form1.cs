using OBJDTool.parse;
using OBJDTool.classes;
using System.Numerics;
using System.Text;

namespace OBJDTool
{
    public partial class Form1 : Form
    {

        private OpenFileDialog openOBJD;
        public static List<Section12Pair> OBJDArr = new List<Section12Pair>();
        public static string[] MapNames = File.ReadAllLines(@"resrc/mapname.txt");
        public static string[] fileList;
        public static Section1Entry ActiveSec1Entry;
        public static Section12Pair ActivePair;
        public Form1()
        {
            InitializeComponent();
            if(!Directory.Exists(@"resrc"))
            {
                Directory.CreateDirectory("resrc");
            }
            if (!File.Exists(@"resrc\path.conf"))
            {
                var setup = new forms.FirstSetup();
                setup.Show();
            }
            else
            {
                LoadAllOBJD();
            }
            foreach(string map in MapNames)
            {
                MapList.Items.Add(map);
            }
            if (!File.Exists(@"resrc\monastery.bundlecount"))
            {
                File.Create(@"resrc\monastery.bundlecount");
            }
            Section12Pair monasteryOBJD = OBJDArr[OBJDArr.Count - 1];
            /*int[] bundleCount = EvaluateBundles(monasteryOBJD);
            string[] bundleText = new string[bundleCount.Length];
            for(int i = 0; i < bundleCount.Length; i++)
            {
                bundleText[i] = "Bundle" + i + ": " + bundleCount[i] + " entries";
            }
            File.WriteAllLines(@"resrc\monastery.bundlecount", bundleText);*/
            List<Section2Entry> libList = new List<Section2Entry>();
            IEnumerable<Section1Entry> libList2 = monasteryOBJD.Section1Entries.Where(x => x.BundleID == 56);
            foreach(Section2Entry libSec2 in monasteryOBJD.Section2Entries)
            {
                foreach(var lib in libList2)
                {
                    if(libSec2.Entry == lib.EntryID)
                    {
                        libList.Add(libSec2);
                        break;
                    }
                }
            }
            using(var stream = File.Open(@"resrc\library.kurobjd", FileMode.Open))
            {
                using(var writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.Write('K');
                    writer.Write('O');
                    writer.Write('B');
                    writer.Write('J');
                    writer.Write(libList.Count);
                    foreach(var sec2 in libList)
                    {
                        foreach(var sec1 in libList2)
                        {
                            if(sec1.EntryID == sec2.Entry)
                            {
                                writer.Write(sec1.ModelID);
                                writer.Write(0);
                                writer.Write(0);
                                break;
                            }
                        }
                        writer.Write(sec2.Position.X);
                        writer.Write(sec2.Position.Y);
                        writer.Write(sec2.Position.Z);
                        writer.Write(sec2.Rotation.X);
                        writer.Write(sec2.Rotation.Y);
                        writer.Write(sec2.Rotation.Z);
                        writer.Write(sec2.Scale.X);
                        writer.Write(sec2.Scale.Y);
                        writer.Write(sec2.Scale.Z);
                    }
                }
            }
        }

        private void LoadAllOBJD()
        {
            string path = Initialize.LoadPath() + @"\stage\obj"; //load path from file to know OBJD directory
            int i = 0;
            fileList = Directory.GetFiles(path);
            for(int po = 0; po < MapNames.Length; po++) //for each OBJD...
            {
                string file = fileList[po];
                var br = new OBJDReader(File.Open(file, FileMode.Open)); //read OBJD file
                br.BaseStream.Position = 38;
                short Sec0Size = br.ReadShort();
                short Sec1Size = br.ReadShort();
                short Sec2Size = br.ReadShort();
                Section12Pair pair = new Section12Pair(Sec1Size, Sec2Size);
                br.BaseStream.Position = 48 + 16 + (64 * Sec0Size) + 16;
                for(int j = 0; j < pair.Section1Entries.Length; j++) //add each Section 1 Entry
                {
                    Section1Entry tempSec1 = new Section1Entry();
                    br.BaseStream.Position += 0x30;
                    br.BaseStream.Position += 32;
                    br.BaseStream.Position += 0x180;
                    tempSec1.ModelID = br.ReadShort();
                    br.BaseStream.Position += 0x35;
                    tempSec1.BundleID = br.ReadByte();
                    tempSec1.EntryID = br.ReadShort();
                    br.BaseStream.Position += 502;
                    pair.Section1Entries[j] = tempSec1;
                }
                br.BaseStream.Position += 0x10;
                for(int j = 0; j < pair.Section2Entries.Length; j++) //add each Section 2 Entry
                {
                    Section2Entry tempSec2 = new Section2Entry();
                    for(int k = 0; k < 3; k++)
                    {
                        if(k == 1)
                        {
                            float x = (float)(br.ReadSingle() * (180 / Math.PI));
                            float y = (float)(br.ReadSingle() * (180 / Math.PI));
                            float z = (float)(br.ReadSingle() * (180 / Math.PI));
                            float w = (float)(br.ReadSingle() * (180 / Math.PI));
                            switch (k)
                            {
                                case 0:
                                    tempSec2.Scale = new Vector4(x, y, z, w);
                                    break;
                                case 1:
                                    tempSec2.Rotation = new Vector4(x, y, z, w);
                                    break;
                                case 2:
                                    tempSec2.Position = new Vector4(x, y, z, w);
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            float x = br.ReadSingle();
                            float y = br.ReadSingle();
                            float z = br.ReadSingle();
                            float w = br.ReadSingle();
                            switch (k)
                            {
                                case 0:
                                    tempSec2.Scale = new Vector4(x, y, z, w);
                                    break;
                                case 1:
                                    tempSec2.Rotation = new Vector4(x, y, z, w);
                                    break;
                                case 2:
                                    tempSec2.Position = new Vector4(x, y, z, w);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    br.BaseStream.Position += 4;
                    tempSec2.Entry = br.ReadShort();
                    br.BaseStream.Position += 10;
                    pair.Section2Entries[j] = tempSec2;
                }
                OBJDArr.Add(pair); //add OBJD file to the array
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MapList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = MapList.SelectedIndex;
            ActivePair = OBJDArr[i];
            FileLoadedName.Text = "File Loaded:" + Path.GetFileName(fileList[i]);
            Entry1List.Items.Clear();
            for(int j = 0; j < ActivePair.Section1Entries.Length; j++)
            {
                Entry1List.Items.Add("Entry" + j);
            }
        }

        private void Entry1List_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Entry1List.SelectedIndex;
            Entry2List.Items.Clear();
            foreach(var Sec2Entry in ActivePair.Section2Entries)
            {
                if(Sec2Entry.Entry == ActivePair.Section1Entries[i].EntryID)
                {
                    Entry2List.Items.Add("Entry" + Array.IndexOf(ActivePair.Section2Entries, Sec2Entry));
                }
            }
            bundleID.Text = "Bundle " + ActivePair.Section1Entries[i].BundleID.ToString();
            ModelID.Text = "G1M " + ActivePair.Section1Entries[i].ModelID.ToString();
            ActiveSec1Entry = ActivePair.Section1Entries[i];
        }

        private void Entry2List_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Entry2List.SelectedIndex;
            string name = Entry2List.Items[i].ToString();
            name = name.TrimStart("Entry".ToCharArray());
            int j = int.Parse(name);
            Section2Entry sec2Ent = ActivePair.Section2Entries[j];
            EntryPos.Text = "Position: (" + sec2Ent.Position.X + "), (" + sec2Ent.Position.Y + "), (" + sec2Ent.Position.Z + ")";
            EntryRot.Text = "Rotation: (" + sec2Ent.Rotation.X + "), (" + sec2Ent.Rotation.Y + "), (" + sec2Ent.Rotation.Z + ")";
            EntryScale.Text = "Scale: (" + sec2Ent.Scale.X + "), (" + sec2Ent.Scale.Y + "), (" + sec2Ent.Scale.Z + ")";
        }

        private int[] EvaluateBundles(Section12Pair objd)
        {
            int largest = 0;
            foreach(Section1Entry entry in objd.Section1Entries)
            {
                if(entry.BundleID > largest)
                {
                    largest = entry.BundleID;
                }
            }
            int[] entryCounts = new int[largest];
            for(int i = 0; i < largest; i++)
            {
                IEnumerable<Section1Entry> entries = objd.Section1Entries.Where(x => x.BundleID == i);
                int count = entries.Count();
                foreach(var entry in entries)
                {
                    if(entry.ModelID == -1)
                    {
                        count -= 1;
                    }
                }
                entryCounts[i] = count;
            }
            return entryCounts;
        }
    }
}