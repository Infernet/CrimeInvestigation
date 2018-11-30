using System;
using CrimeInvestigation.Classes;
using CrimeInvestigation.Classes.Commands;
using CrimeInvestigation.Classes.Receivers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeInvestigation.Forms
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            listBoxPolicemen.DataSource = DataSingleton.GetInstance().Policemen;
            listBoxPolicemen.DisplayMember = "ToString()";
            listBoxCriminalCases.DataSource = DataSingleton.GetInstance().CriminalCases;
            listBoxCriminalCases.DisplayMember = "ToString()";
        }

        private void buttonAddPoliceman_Click(object sender, EventArgs e)
        {
            this.ShowNextForm(new CreatePolicemanForm());
            DataSingleton.GetInstance().ChainCreate();
            UpdateForm();
        }

        private void buttonAddCriminal_Click(object sender, EventArgs e)
        {
            this.ShowNextForm(new CreateCriminalCase());
            UpdateForm();
        }

        private void listBoxPolicemen_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSingleton.GetInstance().CurrentPoliceman = (sender as ListBox).SelectedItem as Policeman;
        }

        private void listBoxCriminalCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSingleton.GetInstance().CurrentCriminalCase = (sender as ListBox).SelectedItem as CriminalCase;
        }

        private void UpdateForm()
        {
            textBoxLogs.Text = "";
            foreach (string item in DataSingleton.GetInstance().Logs)
            {
                textBoxLogs.Text += item + Environment.NewLine;
            }
            listBoxPolicemen.DataSource = null;
            listBoxPolicemen.DataSource = DataSingleton.GetInstance().Policemen;
            listBoxPolicemen.DisplayMember = "ToString()";

            listBoxCriminalCases.DataSource = null;
            listBoxCriminalCases.DataSource = DataSingleton.GetInstance().CriminalCases;
            listBoxCriminalCases.DisplayMember = "ToString()";
        }

        private void buttonRemovePoliceman_Click(object sender, EventArgs e)
        {
            if (DataSingleton.GetInstance().CurrentPoliceman != null)
            {
                InvokerCommands.GetInstance().SetCommand(new CommandRemovePoliceman(new RemovePoliceman()));
                InvokerCommands.GetInstance().StartCommand();
                DataSingleton.GetInstance().ChainCreate();
                UpdateForm();
            }
            else
                MessageBox.Show("Выберете полицейского.", "Внимание");
        }

        private void buttonShowPoliceman_Click(object sender, EventArgs e)
        {
            if (DataSingleton.GetInstance().CurrentPoliceman != null)
                ShowNextForm(new PolicemanViewForm());
            else
                MessageBox.Show("Выберете полицейского.", "Внимание");
        }

        private void buttonRemoveCriminal_Click(object sender, EventArgs e)
        {
            if (DataSingleton.GetInstance().CurrentCriminalCase != null)
            {
                InvokerCommands.GetInstance().SetCommand(new CommandRemoveCriminalCase(new RemoveCriminalCase()));
                InvokerCommands.GetInstance().StartCommand();
                UpdateForm();
            }
            else
                MessageBox.Show("Выберете уголовное дело.", "Внимание");
        }

        private void buttonShowCriminal_Click(object sender, EventArgs e)
        {
            if (DataSingleton.GetInstance().CurrentCriminalCase != null)
                ShowNextForm(new CriminalCaseViewForm());
            else
                MessageBox.Show("Выберете уголовное дело.", "Внимание");
        }

        private void buttonCriminalSendToPolice_Click(object sender, EventArgs e)
        {
            if (DataSingleton.GetInstance().Policemen.Count != 0 && DataSingleton.GetInstance().CurrentCriminalCase!=null)
            {
                InvokerCommands.GetInstance().SetCommand(new CommandToSendCriminalCase(new ToSendCriminalCase()));
                InvokerCommands.GetInstance().StartCommand();
                UpdateForm();
            }
            else
                MessageBox.Show("Преступление некому раскрывать, или вы не выбрали дело", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
