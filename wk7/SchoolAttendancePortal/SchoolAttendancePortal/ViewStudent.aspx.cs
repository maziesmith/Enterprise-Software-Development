using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Adding References 
using DataAccessLayer;
using BusinessLogicLayer;

namespace SchoolAttendancePortal
{
    public partial class ViewStudent : System.Web.UI.Page
    {
        StudentBLL studentBLL = new StudentBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Student> students = studentBLL.GetAllStudents();
                studentsGridView.DataSource = students;
                studentsGridView.DataBind();
            }
        }

        protected void studentsGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string adminNumber = studentsGridView.SelectedRow.Cells[0].Text;
            Response.Redirect("~/StudentDetails.aspx?adminNumber=" + adminNumber);
        }
        protected void studentsGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string adminNumber = studentsGridView.Rows[e.RowIndex].Cells[0].Text;
            studentBLL.DeleteStudent(adminNumber);
            studentsGridView.DataBind();
        }
    }
}