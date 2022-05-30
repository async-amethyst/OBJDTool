using OBJDTool.parse;
using OBJDTool.classes;
using System.Numerics;

namespace OBJDTool
{
    public partial class Form1 : Form
    {

        private OpenFileDialog openOBJD;
        public static List<Section12Pair> OBJDArr = new List<Section12Pair>();
        public static string[] MapNames = File.ReadAllLines(@"resrc/mapname.txt");
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
                DropDown.Items.Add(map);
            }
            DropDown.SelectedIndex = 0;
        }

        private void LoadAllOBJD()
        {
            string path = Initialize.LoadPath() + @"\stage\obj";
            int i = 0;
            string[] fileList = Directory.GetFiles(path);
            for(int po = 0; po < MapNames.Length; po++)
            {
                string file = fileList[po];
                var br = new OBJDReader(File.Open(file, FileMode.Open));
                br.BaseStream.Position = 38;
                short Sec0Size = br.ReadShort();
                short Sec1Size = br.ReadShort();
                short Sec2Size = br.ReadShort();
                Section12Pair pair = new Section12Pair(Sec1Size, Sec2Size);
                br.BaseStream.Position = 48 + 16 + (64 * Sec0Size) + 16;
                for(int j = 0; j < pair.Section1Entries.Length; j++)
                {
                    Section1Entry hiFyreFlii = new Section1Entry();
                    br.BaseStream.Position += 0x30;
                    br.BaseStream.Position += 32;
                    br.BaseStream.Position += 0x180;
                    hiFyreFlii.ModelID = br.ReadShort();
                    br.BaseStream.Position += 0x35;
                    hiFyreFlii.BundleID = br.ReadByte();
                    hiFyreFlii.EntryID = br.ReadShort();
                    br.BaseStream.Position += 502;
                    pair.Section1Entries[j] = hiFyreFlii;
                }
                br.BaseStream.Position += 0x10;
                for(int j = 0; j < pair.Section2Entries.Length; j++)
                {
                    Section2Entry hiSky = new Section2Entry();
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
                                    hiSky.Scale = new Vector4(x, y, z, w);
                                    break;
                                case 1:
                                    hiSky.Rotation = new Vector4(x, y, z, w);
                                    break;
                                case 2:
                                    hiSky.Position = new Vector4(x, y, z, w);
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
                                    hiSky.Scale = new Vector4(x, y, z, w);
                                    break;
                                case 1:
                                    hiSky.Rotation = new Vector4(x, y, z, w);
                                    break;
                                case 2:
                                    hiSky.Position = new Vector4(x, y, z, w);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    br.BaseStream.Position += 4;
                    hiSky.Entry = br.ReadShort();
                    br.BaseStream.Position += 10;
                    pair.Section2Entries[j] = hiSky;
                }
                OBJDArr.Add(pair);
            }
        }

        private void LoadOBJD_Click(object sender, EventArgs e)
        {
        }

        private void DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = DropDown.SelectedIndex;
            entry1Cnt.Text = "Section 1 Entries: " + OBJDArr[i].Section1Entries.Length;
            entry2Cnt.Text = "Section 2 Entries: " + OBJDArr[i].Section2Entries.Length;
            ActivePair = OBJDArr[i];
            Section1Box.Items.Clear();
            Section2Box.Items.Clear();
            for(int m = 0; m < ActivePair.Section1Entries.Length; m++)
            {
                Section1Box.Items.Add("Entry" + m.ToString());
            }
            Section1Box.SelectedIndex = 0;
            for (int m = 0; m < ActivePair.Section2Entries.Length; m++)
            {
                Section2Box.Items.Add("Entry" + m.ToString());
            }
            Section2Box.SelectedIndex = 0;
        }

        private void Section1Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = Section1Box.SelectedIndex;
            Sec1Bundle.Text = "Bundle ID: " + ActivePair.Section1Entries[k].BundleID.ToString();
            Sec1G1M.Text = "Model ID: " + ActivePair.Section1Entries[k].ModelID.ToString();
        }

        private void Section2Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Section2Box.SelectedIndex;
            Section2Scale.Text = ("Scale: (" + ActivePair.Section2Entries[i].Scale.X + ", " + ActivePair.Section2Entries[i].Scale.Y + ", " + ActivePair.Section2Entries[i].Scale.Z + ")").ToString();
            Section2Rot.Text = ("Rotation: (" + ActivePair.Section2Entries[i].Rotation.X + ", " + ActivePair.Section2Entries[i].Rotation.Y + ", " + ActivePair.Section2Entries[i].Rotation.Z + ")").ToString();
            Section2Pos.Text = ("Positions: (" + ActivePair.Section2Entries[i].Position.X + ", " + ActivePair.Section2Entries[i].Position.Y + ", " + ActivePair.Section2Entries[i].Position.Z + ")").ToString();
            Sec2ModelID.Text = "Entry: " + ActivePair.Section2Entries[i].Entry.ToString();
        }
    }
}