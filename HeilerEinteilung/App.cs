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

namespace HeilerEinteilung
{
    public partial class App : Form
    {
        private List<TankHealerAssociation> tankHealerAssociations = new List<TankHealerAssociation>();

        public App()
        {
            InitializeComponent();
        }

        private void btnAddTank_Click(object sender, EventArgs e)
        {
            var availableTanks = lbAvailableTanks.Items;
            var newTank = tbTankName.Text;

            if (string.IsNullOrEmpty(newTank))
            {
                return;
            }

            if (availableTanks.Contains(newTank))
            {
                return;
            }

            availableTanks.Add(newTank);
        }

        private void btnRemoveTank_Click(object sender, EventArgs e)
        {
            var selectedTankIndex = lbAvailableTanks.SelectedIndex;

            if (selectedTankIndex < 0)
            {
                return;
            }

            lbAvailableTanks.Items.RemoveAt(selectedTankIndex);
        }

        private void btnAddHealer_Click(object sender, EventArgs e)
        {
            var availableHealers = lbAvailableHealers.Items;
            var newHealer = tbHealerName.Text;

            if (string.IsNullOrEmpty(newHealer))
            {
                return;
            }

            if (availableHealers.Contains(newHealer))
            {
                return;
            }

            availableHealers.Add(newHealer);
        }

        private void btnRemoveHealer_Click(object sender, EventArgs e)
        {
            var selectedHealerIndex = lbAvailableHealers.SelectedIndex;

            if (selectedHealerIndex < 0)
            {
                return;
            }

            lbAvailableHealers.Items.RemoveAt(selectedHealerIndex);
        }

        private void AddAssocRow()
        {
            var selectedHealerIndex = lbAvailableHealers.SelectedIndex;

            if (selectedHealerIndex < 0)
            {
                MessageBox.Show("Kein Heiler ausgewählt");
                return;
            }

            var selectedTankIndex = lbAvailableTanks.SelectedIndex;

            if (selectedTankIndex < 0)
            {
                MessageBox.Show("Kein Tank ausgewählt");
                return;
            }

            var assoc = new TankHealerAssociation()
            {
                HealerName = lbAvailableHealers.SelectedItem.ToString(),
                TankName = lbAvailableTanks.SelectedItem.ToString(),
                RowIndex = tankHealerAssociations.Count
            };

            if (this.tankHealerAssociations.Contains(assoc))
            {
                MessageBox.Show("Die Kombination wurde schon hinzugefügt");
                return;
            }

            this.tankHealerAssociations.Add(assoc);

            var controls = assoc.Render();
            controls.ForEach(control => { this.Controls.Add(control); });
        }

        private void btnAddAssoc_Click(object sender, EventArgs e)
        {
            this.AddAssocRow();
        }

        private void btnSaveAssoc_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFile.OpenFile()))
                {
                    //tankHealerAssociations.ForEach(assoc =>
                    //{
                    //    writer.WriteLine($@"{assoc.TankName};{assoc.HealerName};{assoc.};");
                    //});
                }
            }
        }
    }
}
