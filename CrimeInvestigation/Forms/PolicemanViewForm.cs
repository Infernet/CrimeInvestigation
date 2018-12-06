using CrimeInvestigation.Classes;
using System.Windows.Forms;

namespace CrimeInvestigation.Forms
{
    public partial class PolicemanViewForm : BaseForm
    {
        public PolicemanViewForm()
        {
            InitializeComponent();
            this.Text ="Полицейский: "+ DataSingleton.GetInstance().CurrentPoliceman.FirstName + " " + DataSingleton.GetInstance().CurrentPoliceman.LastName;
            pictureAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAvatar.Image = DataBus.GetPolicemanImage(DataSingleton.GetInstance().CurrentPoliceman.Rank);
            textBoxFName.Text = DataSingleton.GetInstance().CurrentPoliceman.FirstName;
            textBoxLName.Text = DataSingleton.GetInstance().CurrentPoliceman.LastName;
            textBoxRank.Text = DataSingleton.GetInstance().Ranks[DataSingleton.GetInstance().CurrentPoliceman.Rank];
        }
    }
}
