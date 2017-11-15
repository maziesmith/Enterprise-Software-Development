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
    public partial class PatientView : System.Web.UI.Page
    {
        PatientBLL patientBLL = new PatientBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Patient> patients = patientBLL.GetAllPatient();
            gvPatient.DataSource = patients;
            gvPatient.DataBind();
        }
    }
}