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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected void ShowNextForm(BaseForm nextForm,bool enableForm=true)
        {
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.Location = this.Location;

            if(enableForm)
            {
                this.Enabled = false;
                nextForm.ShowDialog();
                this.Enabled = true;
            }
            else
            {
                this.Hide();
                nextForm.ShowDialog();
                this.Show();
            }
            
        }
    }
}
