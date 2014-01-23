using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1_1Versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CountButton_Click(object sender, EventArgs e)
        {
            VersalerLabel.Text = "Texten innehåller " + Convert.ToString(Model.TextAnalyzer.GetNumberOfCapitals(VersalerTextBox.Text)) + " versaller";
            VersalerTextBox.Enabled = false;
            CountButton.Visible = false;
            ClearButton.Visible = true;

        }
        protected void ClearButton_Click(object sender, EventArgs e)
        {
                VersalerLabel.Text = "";
                VersalerTextBox.Text = "";
                VersalerTextBox.Enabled = true;
                CountButton.Visible = true;
                ClearButton.Visible = false;
        }
    }
}