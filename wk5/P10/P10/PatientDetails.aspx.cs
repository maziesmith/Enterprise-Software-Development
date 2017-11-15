using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;

namespace P10
{
    public partial class PatientDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String patientID = Request.QueryString["id"];

                PatientBLL patientBLL = new PatientBLL();
                Patient patient = patientBLL.GetPatient(patientID);

                if (patient == null)
                {
                    this.lbMessage.Text = "Error retreiving patient details";
                }
                else
                {
                    lbPatientID.Text = patient.PatientID;
                    lbPatientName.Text = patient.PatientName;
                    rblGender.SelectedValue = patient.Gender;
                    ddlCitizenship.SelectedValue = patient.Citizenship;
                    ddlCountry.SelectedValue = patient.Country;
                    tbAddress.Text = patient.Address;
                    lbContactNumber.Text = patient.ContactNumber;
                    lbEmail.Text = patient.Email;
                    lbPostalCode.Text = patient.PostalCode;
                }
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}