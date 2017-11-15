using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;

namespace P10
{
    public partial class PatientInput : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            PatientBLL patientBLL = new PatientBLL();

            String message =
                patientBLL.CreatePatient(tbPatientID.Text,
                                         tbPatientName.Text,
                                         rblGender.SelectedValue,
                                         ddlCitizenship.SelectedValue,
                                         tbAddress.Text,
                                         tbPostalCode.Text,
                                         ddlCountry.SelectedValue,
                                         tbContactNumber.Text,
                                         tbEmail.Text);

            lbMessage.Text = message;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            tbPatientID.Text = String.Empty;
            tbPatientName.Text = String.Empty;
            rblGender.SelectedIndex = 0;
            ddlCitizenship.SelectedIndex = 5;
            tbAddress.Text = String.Empty;
            tbPostalCode.Text = String.Empty;
            ddlCountry.SelectedIndex = 5;
            tbContactNumber.Text = String.Empty;
            tbEmail.Text = String.Empty;
            lbMessage.Text = String.Empty;
        }
    }
}