using CrimeInvestigation.Classes;
using CrimeInvestigation.Classes.Commands;
using CrimeInvestigation.Classes.Receivers;
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
            pictureAvatar.Image=DataBus.GetCriminalImage(comboComplexity.SelectedIndex);
            pictureAvatar.Refresh();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string name;
            int complexity;
            if (checkBoxRandom.Checked)
            {
                Random random = new Random();
                name = DataSingleton.GetInstance().CriminalNames[random.Next(DataSingleton.GetInstance().CriminalNames.Count)];
                complexity= random.Next( DataSingleton.GetInstance().Complexity.Count);
                InvokerCommands.GetInstance().SetCommand(new CommandAddCriminalCase(new AddCriminalCase(), name, complexity));
                InvokerCommands.GetInstance().StartCommand();
            }
            else if (NameReg.IsMatch(textBoxName.Text))
            {
                name = textBoxName.Text;
                complexity = comboComplexity.SelectedIndex;
                InvokerCommands.GetInstance().SetCommand(new CommandAddCriminalCase(new AddCriminalCase(), name, complexity));
                InvokerCommands.GetInstance().StartCommand();
            }
            else
                MessageBox.Show("Введите имя уголовного дела", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
