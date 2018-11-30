using CrimeInvestigation.Classes;
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
    public partial class CriminalCaseViewForm : BaseForm
    {
        public CriminalCaseViewForm()
        {
            InitializeComponent();
            textBoxName.Text = DataSingleton.GetInstance().CurrentCriminalCase.Name;
            textBoxComplexity.Text = DataSingleton.GetInstance().Complexity[DataSingleton.GetInstance().CurrentCriminalCase.Complexity];
            if (DataSingleton.GetInstance().CurrentCriminalCase.Disclosed)
            {
                textBoxStatus.BackColor = Color.Green;
                textBoxPoliceman.Visible = true;
                label4.Visible = true;
                textBoxPoliceman.Text = DataSingleton.GetInstance().CurrentCriminalCase.FullNamePoliceman;
            }
            else
            {
                textBoxStatus.BackColor = Color.Red;
                textBoxPoliceman.Visible = false;
                label4.Visible = false;
            }
            pictureAvatar.Image = DataBus.GetCriminalImage(DataSingleton.GetInstance().CurrentCriminalCase.Complexity);
            pictureAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAvatar.Refresh();
        }
    }
}
