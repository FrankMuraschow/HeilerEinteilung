using HeilerEinteilung.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeilerEinteilung
{
    internal class TankHealerAssociation
    {
        internal App TargetApp;
        internal string HealerName;
        internal string TankName;
        internal string HealerClassName;
        internal string TankPrimary;
        internal string TankSecondary;
        internal string TankCustom;

        private int _rowIndex;
        internal int RowIndex
        {
            get
            {
                return _rowIndex;
            }
            set
            {
                _rowIndex = value;
                cbHealers.Location = new System.Drawing.Point(10, 6 + (value * 32));
                cbTanks.Location = new System.Drawing.Point(80, 6 + (value * 32));
                lblHealerClass.Location = new System.Drawing.Point(155, 8 + (value * 32));
                cbTankTypeSelectionPrimary.Location = new System.Drawing.Point(240, 6 + (value * 32));
                cbTankTypeSelectionSecondary.Location = new System.Drawing.Point(295, 6 + (value * 32));
                tbTankTypeSelectionCustom.Location = new System.Drawing.Point(350, 6 + (value * 32));
                btnDeleteRow.Location = new System.Drawing.Point(405, 8 + (value * 32));
                pnlColor.Location = new System.Drawing.Point(0, 0 + (value * 32));
            }
        }

        internal List<Control> Controls = new List<Control>();

        private ComboBox cbTanks = new ComboBox()
        {
            Size = new System.Drawing.Size(70, 32)
        };

        private ComboBox cbHealers = new ComboBox()
        {
            Size = new System.Drawing.Size(70, 32)
        };

        internal Label lblHealerClass = new Label()
        {
            Size = new System.Drawing.Size(80, 20)
        };

        internal ComboBox cbTankTypeSelectionPrimary = new ComboBox()
        {
            Size = new System.Drawing.Size(50, 32)
        };

        internal ComboBox cbTankTypeSelectionSecondary = new ComboBox()
        {
            Size = new System.Drawing.Size(50, 32)
        };

        internal TextBox tbTankTypeSelectionCustom = new TextBox()
        {
            Size = new System.Drawing.Size(50, 32)
        };

        internal Panel pnlColor = new Panel()
        {
            Size = new System.Drawing.Size(434, 32)
        };

        internal Button btnDeleteRow = new Button()
        {
            Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
            Margin = new Padding(0, 2, 0, 0),
            Size = new System.Drawing.Size(16, 16),
            Text = "X"
        };

        internal TankHealerAssociation(App app, int rowIndex)
        {
            TargetApp = app;
            RowIndex = rowIndex;
            setControls();
        }

        internal TankHealerAssociation(App app, string healerName, string tankName, string healerClassName, string tankPrimary, string tankSecondary, string tankCustom, int rowIndex)
        {
            TargetApp = app;
            HealerName = healerName;
            TankName = tankName;
            RowIndex = rowIndex;
            HealerClassName = healerClassName;
            TankPrimary = tankPrimary;
            TankSecondary = tankSecondary;
            TankCustom = tankCustom;
            setControls();
        }

        private List<Control> setControls()
        {
            var healTargetTypes = Enum.GetValues(typeof(HealTarget));
            for (var i = 0; i < healTargetTypes.Length; i++)
            {
                var healTargetType = healTargetTypes.GetValue(i);
                cbTankTypeSelectionPrimary.Items.Add(healTargetType);
                cbTankTypeSelectionSecondary.Items.Add(healTargetType);
            }

            // Set values
            var tanksInformation = TargetApp.Players.PlayerInformations.Where(playerInformation =>
            {
                return playerInformation.PlayerType == PlayerType.Tank;
            });

            var tanks = tanksInformation.Select(playerInformation => { return playerInformation.Name; });

            var healersInformation = TargetApp.Players.PlayerInformations.Where(playerInformation =>
            {
                return playerInformation.PlayerType == PlayerType.Healer;
            });

            var healers = healersInformation.Select(playerInformation => { return playerInformation.Name; });

            cbTanks.Items.AddRange(tanks.ToArray());
            cbHealers.Items.AddRange(healers.ToArray());
            cbTanks.SelectedIndex = cbTanks.FindStringExact(TankName);
            cbHealers.SelectedIndex = cbHealers.FindStringExact(HealerName);

            setHealerClass();

            cbHealers.SelectedIndexChanged += CbHealers_SelectedIndexChanged;
            cbTanks.SelectedIndexChanged += CbTanks_SelectedIndexChanged;

            cbTankTypeSelectionPrimary.SelectedIndex = cbTankTypeSelectionPrimary.FindStringExact(TankPrimary);
            cbTankTypeSelectionSecondary.SelectedIndex = cbTankTypeSelectionSecondary.FindStringExact(TankSecondary);
            tbTankTypeSelectionCustom.Text = TankCustom;

            cbTankTypeSelectionPrimary.SelectedIndexChanged += CbTankTypeSelectionPrimary_SelectedIndexChanged;
            cbTankTypeSelectionSecondary.SelectedIndexChanged += CbTankTypeSelectionSecondary_SelectedIndexChanged;
            tbTankTypeSelectionCustom.TextChanged += TbTankTypeSelectionCustom_TextChanged;
            btnDeleteRow.Click += BtnDeleteRow_Click;

            Controls.Add(cbHealers);
            Controls.Add(cbTanks);
            Controls.Add(lblHealerClass);
            Controls.Add(cbTankTypeSelectionPrimary);
            Controls.Add(cbTankTypeSelectionSecondary);
            Controls.Add(tbTankTypeSelectionCustom);
            Controls.Add(btnDeleteRow);
            Controls.Add(pnlColor);

            return Controls;
        }

        private void CbTanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            TankName = cbTanks.Text;
        }

        private void CbHealers_SelectedIndexChanged(object sender, EventArgs e)
        {
            HealerName = cbHealers.Text;
            setHealerClass();
        }

        private void setHealerClass()
        {
            var healersInformation = TargetApp.Players.PlayerInformations.Where(playerInformation =>
            {
                return playerInformation.PlayerType == PlayerType.Healer;
            });

            if (!string.IsNullOrEmpty(HealerName))
            {
                var healer = healersInformation.FirstOrDefault(playerInformation =>
                {
                    return playerInformation.Name == HealerName;
                });

                HealerClassName = healer.HealerClass.ToString();
                lblHealerClass.Text = HealerClassName;

                var colorString = TargetApp.GetHealerClassColor(healer.HealerClass);
                Color healerColor = Util.HexToColor(colorString.Substring(2,6));

                pnlColor.BackColor = healerColor;
                lblHealerClass.BackColor = healerColor;
            }
        }

        private void TbTankTypeSelectionCustom_TextChanged(object sender, EventArgs e)
        {
            TankCustom = tbTankTypeSelectionCustom.Text;
        }

        private void CbTankTypeSelectionSecondary_SelectedIndexChanged(object sender, EventArgs e)
        {
            TankSecondary = cbTankTypeSelectionSecondary.Text;
        }

        private void CbTankTypeSelectionPrimary_SelectedIndexChanged(object sender, EventArgs e)
        {
            TankPrimary = cbTankTypeSelectionPrimary.Text;
        }

        private void BtnDeleteRow_Click(object sender, EventArgs e)
        {
            this.TargetApp.RemoveAssoc(this.RowIndex);
        }

        public override bool Equals(object other)
        {
            TankHealerAssociation y = other as TankHealerAssociation;

            var currentTankName = TankName;
            var currentHealerName = HealerName;

            var otherTankName = y.TankName;
            var otherHealerName = y.HealerName;


            return TankName == y.TankName && HealerName == y.HealerName;
        }
    }
}
