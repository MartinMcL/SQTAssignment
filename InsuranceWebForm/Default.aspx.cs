using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Insurance;

namespace InsuranceWebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            Customer sut = new Customer();
            string gender = genderTxt.Text;
            int age = Convert.ToInt16(AgeTxt.Text);
            PremiumLbl.Text = Convert.ToString(sut.CalcPremium(age, gender));
        }
    }
}