using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HeilerEinteilung
{
    public partial class App : Form
    {
        internal Players Players = new Players();
        private List<TankHealerAssociation> tankHealerAssociations = new List<TankHealerAssociation>();
        private Dictionary<HealerClass, string> healerColors = new Dictionary<HealerClass, string>()
        {
            { HealerClass.Druide, "ffff7c0a" },
            { HealerClass.Priester, "ffffffff" },
            { HealerClass.Schamane, "fff48cba" },
        };

        public App()
        {
            InitializeComponent();
            XmlSerializer deserializer = new XmlSerializer(typeof(Players));
            using (TextReader reader = new StreamReader("players.xml"))
            {
                Players = (Players)deserializer.Deserialize(reader);
            }
        }

        private void AddAssocRow()
        {
            var assoc = new TankHealerAssociation(this, tankHealerAssociations.Count);
            this.tankHealerAssociations.Add(assoc);
        }

        private void RerenderAssocs()
        {
            var controlsCount = pnlAssocs.Controls.Count;
            for (int controlIndex = 0; controlIndex < controlsCount; controlIndex++)
            {
                this.pnlAssocs.Controls.RemoveAt(0);
            }

            var assocIndex = 0;
            tankHealerAssociations.ForEach(assoc =>
            {
                assoc.RowIndex = assocIndex;
                assocIndex++;

                assoc.Controls.ForEach(control =>
                {
                    this.pnlAssocs.Controls.Add(control);
                });
            });
        }

        private void btnAddAssoc_Click(object sender, EventArgs e)
        {
            AddAssocRow();
            RerenderAssocs();
        }

        internal void RemoveAssoc(int rowIndex)
        {
            tankHealerAssociations.RemoveAt(rowIndex);
            RerenderAssocs();
        }

        internal string GetHealerClassColor(HealerClass healerClass)
        {
            string color = "";
            healerColors.TryGetValue(healerClass, out color);

            return color;
        }

        private void btnSaveAssoc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoadAssocs_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGenerateAssocText_Click(object sender, EventArgs e)
        {
           
    }

        private void chatnachrichtInZwischenablageKopierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var output = $"{tbBossName.Text}{Environment.NewLine}";
            output += $"{Environment.NewLine}";
            tankHealerAssociations.ForEach(assoc =>
            {
                if (!string.IsNullOrEmpty(assoc.HealerClassName))
                {
                    HealerClass currentClass = (HealerClass)Enum.Parse(typeof(HealerClass), assoc.HealerClassName);
                    output += $"|c{GetHealerClassColor(currentClass)}{assoc.HealerName}|r    {assoc.TankName} ({assoc.TankPrimary})";
                }
                else
                {
                    output += $"|cffffffff{assoc.HealerName}|r    {assoc.TankName} ({assoc.TankPrimary})";
                }

                if (!string.IsNullOrEmpty(assoc.TankSecondary))
                {
                    output += $" / {assoc.TankSecondary}";
                }

                if (!string.IsNullOrEmpty(assoc.TankCustom))
                {
                    output += $" / {assoc.TankCustom}";
                }

                output += Environment.NewLine;
            });

            Clipboard.SetText(output);
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loadFile = new OpenFileDialog()
            {
                Filter = "Peters Heileinteilungen|*.pH"
            };

            if (loadFile.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(loadFile.FileName, Encoding.UTF8);

                tankHealerAssociations.Clear();

                for (int lineIndex = 0; lineIndex < lines.Length; lineIndex++)
                {
                    string[] assocValues = lines[lineIndex].Split(';');

                    if (assocValues.Length < 6)
                    {
                        continue;
                    }

                    var tankName = assocValues[0];
                    var healerName = assocValues[1];
                    var bossName = assocValues.Length == 7 ? assocValues[6] : "";

                    tbBossName.Text = bossName;
                    tankHealerAssociations.Add(new TankHealerAssociation(this, healerName, tankName, assocValues[2], assocValues[3], assocValues[4], assocValues[5], lineIndex));
                }
            }

            RerenderAssocs();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog()
            {
                AddExtension = true,
                Filter = "Peters Heileinteilungen|*.pH",
                RestoreDirectory = true
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFile.OpenFile()))
                {
                    tankHealerAssociations.ForEach(assoc =>
                    {
                        writer.WriteLine($@"{assoc.TankName};{assoc.HealerName};{assoc.HealerClassName};{assoc.TankPrimary};{assoc.TankSecondary};{assoc.TankCustom};{tbBossName.Text}");
                    });
                }
            }
        }
    }
    }
