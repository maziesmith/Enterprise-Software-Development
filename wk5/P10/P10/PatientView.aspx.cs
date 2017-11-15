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

        protected void gvPatient_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowNumber = int.Parse(e.CommandArgument.ToString());

            GridViewRow gridViewRow = gvPatient.Rows[rowNumber];
            String patientID = gridViewRow.Cells[0].Text;
            
            if(e.CommandName == "Select")
            {

            }
            else if (e.CommandName == "Update")
            {
                Response.Redirect(String.Format("PatientUpdate.aspx?id={0}", patientID));
            }
        }
    }
}