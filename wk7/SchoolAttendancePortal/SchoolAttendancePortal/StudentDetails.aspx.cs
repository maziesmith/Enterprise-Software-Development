using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;

namespace SchoolAttendancePortal
{
    public partial class StudentDetails : System.Web.UI.Page
    {
        StudentBLL studentBLL = new StudentBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string adminNumber = Request.QueryString["adminNumber"].ToString();
                Student student = studentBLL.GetStudent(adminNumber);
                if (student != null)
                {
                    adminNumberLabel.Text = student.AdminNumber;
                    nameLabel.Text = student.Name;
                    genderRadioButtonList.SelectedValue = student.Gender;
                    addressTextBox.Text = student.Address;
                    citizenshipDropDownList.SelectedValue = Student.natToStr(student.CitizenShip);
                    emailLabel.Text = student.SchoolEmail;
                    mobileLabel.Text = student.MobileNumber;
                    profileImage.ImageUrl = "~/Images/" + student.ImageURL;
                }
                else
                {
                    statusLabel.Text = "Studetn not found"
                }
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ViewStudent.aspx");
        }
    }
}