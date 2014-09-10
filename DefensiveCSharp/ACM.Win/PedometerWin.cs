using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACM.BL;

namespace ACM.Win
{
    public partial class PedometerWin : Form
    {
        public PedometerWin()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var customer = new Customer();

            var result = customer.CalculatePercentOfGoalSteps(this.txtTowardsGoal.Text,
                this.txtStepsToday.Text);

            lblResult.Text = "You reached " + result + "% of your goal!!!";
        }
    }
}
