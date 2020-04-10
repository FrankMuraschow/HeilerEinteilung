using HeilerEinteilung.Interfaces;
using System;
using System.Collections.Generic;
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
                lblTank.Location = new System.Drawing.Point(0, 5 + (value * 32));
                lblHealer.Location = new System.Drawing.Point(70, 5 + (value * 32));
                cbHealerTypeSelection.Location = new System.Drawing.Point(145, 5 + (value * 32));
                cbTankTypeSelectionPrimary.Location = new System.Drawing.Point(240, 5 + (value * 32));
                cbTankTypeSelectionSecondary.Location = new System.Drawing.Point(295, 5 + (value * 32));
                tbTankTypeSelectionCustom.Location = new System.Drawing.Point(350, 5 + (value * 32));
                btnDeleteRow.Location = new System.Drawing.Point(415, 8 + (value * 32));
            }
        }
        internal IHealerClassInformation healerClassInfo;
        internal List<Control> Controls = new List<Control>();

        private Label lblTank = new Label()
        {
            Size = new System.Drawing.Size(70, 32)
        };
        private Label lblHealer = new Label()
        {
            Size = new System.Drawing.Size(70, 32)
        };
        internal ComboBox cbHealerTypeSelection = new ComboBox()
        {
            Size = new System.Drawing.Size(80, 32)
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
        internal Button btnDeleteRow = new Button()
        {
            Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
            Margin = new Padding(0, 2, 0, 0),
            Size = new System.Drawing.Size(16, 16),
            Text = "X"
        };

        internal TankHealerAssociation(App app, string healerName, string tankName, int rowIndex)
        {
            TargetApp = app;
            HealerName = healerName;
            TankName = tankName;
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

            // c ff f48cba Zchaoll|r AT
            private List<Control> setControls()
        {
            var healTargetTypes = Enum.GetValues(typeof(HealTarget));
            for (var i = 0; i < healTargetTypes.Length; i++)
            {
                var healTargetType = healTargetTypes.GetValue(i);
                cbTankTypeSelectionPrimary.Items.Add(healTargetType);
                cbTankTypeSelectionSecondary.Items.Add(healTargetType);
            }

            var healerClasses = Enum.GetValues(typeof(HealerClass));
            for (var i = 0; i < healerClasses.Length; i++)
            {
                var healerClass = healerClasses.GetValue(i);
                cbHealerTypeSelection.Items.Add(healerClass);
            }

            // Set values
            lblTank.Text = TankName;
            lblHealer.Text = HealerName;
            cbHealerTypeSelection.SelectedIndex = cbHealerTypeSelection.FindStringExact(HealerClassName);
            cbTankTypeSelectionPrimary.SelectedIndex = cbTankTypeSelectionPrimary.FindStringExact(TankPrimary);
            cbTankTypeSelectionSecondary.SelectedIndex = cbTankTypeSelectionSecondary.FindStringExact(TankSecondary);
            tbTankTypeSelectionCustom.Text = TankCustom;

            cbHealerTypeSelection.SelectedIndexChanged += CbHealerTypeSelection_SelectedIndexChanged;
            cbTankTypeSelectionPrimary.SelectedIndexChanged += CbTankTypeSelectionPrimary_SelectedIndexChanged;
            cbTankTypeSelectionSecondary.SelectedIndexChanged += CbTankTypeSelectionSecondary_SelectedIndexChanged;
            tbTankTypeSelectionCustom.TextChanged += TbTankTypeSelectionCustom_TextChanged;
            btnDeleteRow.Click += BtnDeleteRow_Click;

            Controls.Add(lblTank);
            Controls.Add(lblHealer);
            Controls.Add(cbHealerTypeSelection);
            Controls.Add(cbTankTypeSelectionPrimary);
            Controls.Add(cbTankTypeSelectionSecondary);
            Controls.Add(tbTankTypeSelectionCustom);
            Controls.Add(btnDeleteRow);

            return Controls;
        }

        private void TbTankTypeSelectionCustom_TextChanged(object sender, EventArgs e)
        {
            TargetApp.lblClipboard.Visible = false;
            TankCustom = tbTankTypeSelectionCustom.Text;
        }

        private void CbTankTypeSelectionSecondary_SelectedIndexChanged(object sender, EventArgs e)
        {
            TargetApp.lblClipboard.Visible = false;
            TankSecondary = cbTankTypeSelectionSecondary.Text;
        }

        private void CbTankTypeSelectionPrimary_SelectedIndexChanged(object sender, EventArgs e)
        {
            TargetApp.lblClipboard.Visible = false;
            TankPrimary = cbTankTypeSelectionPrimary.Text;
        }

        private void CbHealerTypeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            TargetApp.lblClipboard.Visible = false;
            HealerClassName = cbHealerTypeSelection.Text;
        }

        private void BtnDeleteRow_Click(object sender, EventArgs e)
        {
            TargetApp.lblClipboard.Visible = false;
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
