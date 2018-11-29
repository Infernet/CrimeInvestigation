using CrimeInvestigation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeInvestigation.Forms
{
    public partial class CreateCriminalCase : BaseForm
    {
        private Regex NameReg = new Regex(@"^[^0-9]\w{3,20}");

        public CreateCriminalCase()
        {
            InitializeComponent();
            comboComplexity.DataSource = DataSingleton.GetInstance().Complexity;
            pictureAvatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void checkBoxRandom_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxRandom.Checked)
            {
                textBoxName.Enabled = false;
                comboComplexity.Enabled = false;
                return;
            }
            textBoxName.Enabled = true;
            comboComplexity.Enabled = true;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (NameReg.IsMatch(textBoxName.Text))
                textBoxName.BackColor = Color.Green;
            else
                textBoxName.BackColor = Color.Red;
        }

        private void comboComplexity_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureAvatar.Image=DataBus.GetCriminalImage(comboComplexity.SelectedIndex+1);
            pictureAvatar.Refresh();
        }
    }
}
