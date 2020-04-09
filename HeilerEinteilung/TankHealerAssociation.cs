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
        internal string HealerName;
        internal HealTarget PrimaryHealerTarget;
        internal HealTarget SecondaryHealerTarget;
        internal HealTarget TertiaryHealerTarget;
        internal string TankName;
        internal int RowIndex;
        private Label lblTank = new Label()
        {
            Size = new System.Drawing.Size(120, 32)
        };
        private Label lblHealer = new Label()
        {
            Size = new System.Drawing.Size(120, 32)
        };
        internal ComboBox tankTypeSelectionPrimary = new ComboBox()
        {
            Size = new System.Drawing.Size(70, 32)
        };
        internal ComboBox tankTypeSelectionSecondary = new ComboBox()
        {
            Size = new System.Drawing.Size(70, 32)
        };
        internal ComboBox tankTypeSelectionTertiary = new ComboBox()
        {
            Size = new System.Drawing.Size(70, 32)
        };

        // c fff48cba Zchaoll|r AT
        internal List<Control> Render()
        {
            List<Control> controls = new List<Control>();
            lblTank.Text = TankName;
            lblHealer.Text = HealerName;

            var healTargetTypes = Enum.GetValues(typeof(HealTarget));

            for (var i = 0; i < healTargetTypes.Length; i++)
            {
                var healTargetType = healTargetTypes.GetValue(i);
                tankTypeSelectionPrimary.Items.Add(healTargetType);
                tankTypeSelectionSecondary.Items.Add(healTargetType);
                tankTypeSelectionTertiary.Items.Add(healTargetType);
            }
            
            lblTank.Location = new System.Drawing.Point(10, 350 + (RowIndex * 32));
            lblHealer.Location = new System.Drawing.Point(130, 350 + (RowIndex * 32));
            tankTypeSelectionPrimary.Location = new System.Drawing.Point(250, 350 + (RowIndex * 32));
            tankTypeSelectionSecondary.Location = new System.Drawing.Point(320, 350 + (RowIndex * 32));
            tankTypeSelectionTertiary.Location = new System.Drawing.Point(390, 350 + (RowIndex * 32));

            controls.Add(lblTank);
            controls.Add(lblHealer);
            controls.Add(tankTypeSelectionPrimary);
            controls.Add(tankTypeSelectionSecondary);
            controls.Add(tankTypeSelectionTertiary);

            return controls;
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
