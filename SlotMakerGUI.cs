using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Ionic.Zip;
using Ionic.Zlib;
using Newtonsoft.Json;
using TTSlotMaker.Properties;

namespace TTSlotMaker
{
    public partial class SlotMakerForm : Form
    {
        public SlotMakerForm()
        {
            InitializeComponent();
        }

        private int SelectedRace => ((KeyValuePair<int, string>)cBoxRace.SelectedItem).Key;

        private int SubType => (int)numType.Value;

        private string SlotName => txtSlot.Text;

        private static readonly Dictionary<int, string> RaceDictionary = new()
        {
            { 0101, "Midlander (M)" },
            { 0201, "Midlander (F)" },
            { 0301, "Highlander (M)" },
            { 0401, "Highlander (F)" },
            { 0501, "Elezen (M)" },
            { 0601, "Elezen (F)" },
            { 0701, "Miqote (M)" },
            { 0801, "Miqote (F)" },
            { 0901, "Roe (M)" },
            { 1001, "Roe (F)" },
            { 1101, "Lalafell (M)" },
            { 1301, "Au Ra (M)" },
            { 1401, "Au Ra (F)" },
            { 1501, "Hrothgar (M)" },
            { 1601, "Hrothgar (F)" },
            { 1701, "Viera (M)" },
            { 1801, "Viera (F)" },
        };

        private void SlotMakerForm_Load(object sender, EventArgs e)
        {
            cBoxRace.DataSource = new BindingSource(RaceDictionary, null);
            cBoxRace.DisplayMember = "Value";
            cBoxRace.ValueMember = "Key";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int selectedRace = SelectedRace;
            int selectedType = SubType;
            string selectedSlot = SlotName;
            using (ZipFile zip = ZipFile.Read(new MemoryStream(Resources.Modpack)))
            {
                ZipEntry mpl = zip.Entries.First(x => x.FileName.EndsWith(".mpl"));
                ModPackJson jsonData;
                using (StreamReader stream = new(mpl.OpenReader()))
                {
                    jsonData = JsonConvert.DeserializeObject<ModPackJson>(stream.ReadToEnd()) ?? throw new InvalidOperationException(".mpl returned null json data!");
                }

                foreach (ModsJson modsJson in jsonData.AllModsJsons)
                {
                    if (!modsJson.FullPath.StartsWith("chara/human", StringComparison.OrdinalIgnoreCase)) continue;
                    modsJson.FullPath = $"chara/human/c{selectedRace.CodeToString()}/obj/body/b{selectedType.CodeToString()}/material/v0001/" +
                                        $"mt_c{selectedRace.CodeToString()}b{selectedType.CodeToString()}_{selectedSlot}.mtrl";
                }

                zip.RemoveEntry(mpl);
                zip.AddEntry(mpl.FileName, JsonConvert.SerializeObject(jsonData));
                zip.AddEntry("CONVERTED.txt", "Converted using TT Slot Maker made by Bread and Bizu.");
                zip.UseZip64WhenSaving = Zip64Option.AsNecessary;
                zip.CompressionLevel = CompressionLevel.None;
                zip.Save(Program.SavedPath);
            }

            MessageBox.Show("Saved as 'Base_Modpack.ttmp2'!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSlot_TextChanged(object sender, EventArgs e)
        {
            if (!txtSlot.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Slot can only be alphanumeric characters!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSlot.Text = string.Empty;
            }
        }
    }
}