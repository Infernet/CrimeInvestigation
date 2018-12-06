using CrimeInvestigation.Classes;
using CrimeInvestigation.Classes.Commands;
using CrimeInvestigation.Classes.Receivers;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CrimeInvestigation.Forms
{
    public partial class CreatePolicemanForm : BaseForm
    {
        private Regex NameReg = new Regex(@"^([A-ЯЁ]|[а-яё])[а-яё]{2,20}");

        public CreatePolicemanForm()
        {
            InitializeComponent();
            pictureAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            comboRank.DataSource = DataSingleton.GetInstance().Ranks;

        }

        private void textBoxFName_TextChanged(object sender, EventArgs e)
        {
            if (NameReg.IsMatch((sender as TextBox).Text))
                (sender as TextBox).BackColor = Color.Green;
            else
                (sender as TextBox).BackColor = Color.Red;
        }

        private void checkBoxRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRandom.Checked)
            {
                textBoxFName.Enabled = false;
                textBoxLName.Enabled = false;
                comboRank.Enabled = false;
            }
            else
            {
                textBoxFName.Enabled = true;
                textBoxLName.Enabled = true;
                comboRank.Enabled = true;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string fname;
            string lname;
            int rank;
            if (checkBoxRandom.Checked)
            {
                Random random = new Random();
                fname = DataSingleton.GetInstance().FNames[random.Next(DataSingleton.GetInstance().FNames.Count)];
                lname = DataSingleton.GetInstance().Lnames[random.Next(DataSingleton.GetInstance().Lnames.Count)];
                rank = random.Next(DataSingleton.GetInstance().Ranks.Count);

                InvokerCommands.GetInstance().SetCommand(new CommandAddPoliceman(new AddPoliceman(), fname, lname, rank));
                InvokerCommands.GetInstance().StartCommand();
            }
            else if (NameReg.IsMatch(textBoxFName.Text) && NameReg.IsMatch(textBoxLName.Text))
            {
                fname = textBoxFName.Text;
                lname = textBoxLName.Text;
                rank = comboRank.SelectedIndex;

                InvokerCommands.GetInstance().SetCommand(new CommandAddPoliceman(new AddPoliceman(), fname, lname, rank));
                InvokerCommands.GetInstance().StartCommand();
            }
            else
                MessageBox.Show("Некорректно введены данные, проверьте правильность введеных данных Имени и Фамилии.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void comboRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureAvatar.Image = DataBus.GetPolicemanImage((sender as ComboBox).SelectedIndex);
            pictureAvatar.Refresh();
        }

        private void textBoxLName_TextChanged(object sender, EventArgs e)
        {
            if (NameReg.IsMatch((sender as TextBox).Text))
                (sender as TextBox).BackColor = Color.Green;
            else
                (sender as TextBox).BackColor = Color.Red;
        }
    }
}
