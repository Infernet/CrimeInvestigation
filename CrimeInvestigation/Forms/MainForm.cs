using System;
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
        }

        private void buttonAddPoliceman_Click(object sender, EventArgs e)
        {
            this.ShowNextForm(new CreatePolicemanForm());
        }

        private void buttonAddCriminal_Click(object sender, EventArgs e)
        {
            this.ShowNextForm(new CreateCriminalCase());
        }
    }
}
