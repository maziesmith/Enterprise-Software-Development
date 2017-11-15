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
    public partial class PatientUpdate : System.Web.UI.Page
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
                    this.lbMessage.Text = "Error in getting Patient details!";
                }
                else
                {
                    lbPatientID.Text = patient.PatientID;
                    tbPatientName.Text = patient.PatientName;
                    rblGender.SelectedValue = patient.Gender;
                    ddlCitizenship.SelectedValue = patient.Citizenship;
                    ddlCountry.SelectedValue = patient.Country;
                    tbAddress.Text = patient.Address;
                    tbContactNumber.Text = patient.ContactNumber;
                    tbEmail.Text = patient.Email;
                    tbPostalCode.Text = patient.PostalCode;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            PatientBLL patientBLL = new PatientBLL();
            String message = patientBLL.UpdatePatient(lbPatientID.Text,
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

        }
    }
}