using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Add References to DataAccessLayer and BusinessLogicLayer
using BusinessLogicLayer;
using DataAccessLayer;

namespace SchoolAttendancePortal
{
    public partial class InsertStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // Part (3): Student Registration 

            statusLabel.Text = "";
            if (adminNumberTextBox.Text.Length != 7)
            {
                statusLabel.Text = "Admin number must be 7 characters long.";
            }
            else if (nameTextBox.Text.Length == 0)
            {
                statusLabel.Text = "Name field cannot be empty";
            }
            else if (addressTextBox.Text.Length == 0)
            {
                statusLabel.Text = "Address field cannot be empty";
            }
            else if (mobileTextBox.Text.Length == 0)
            {
                statusLabel.Text = "Mobile field cannot be empty";
            }
            else if (dobTextBox.Text.Length == 0)
            {
                statusLabel.Text = "Date of birth cannot be empty";
            }

            // Date of birth must be a valid date, registered student must be >= 16
            DateTime dob;
            try
            {
                dob = Convert.ToDateTime(dobTextBox.Text);
                if((DateTime.Now.Year - dob.Year) < 16)
                {
                    statusLabel.Text = "Student must be 16 years old and above.";
                }
                Student.Nationality citizenship = Student.strToNat(citizenshipDropDownList.SelectedValue);
                if (statusLabel.Text.Length == 0)
                {
                    // No errors 
                    string outMessage;
                    string fileName = "";
                    StudentBLL studentBLL = new StudentBLL();
                    string email = adminNumberTextBox.Text + "@mymail.nyp.edu.sg";
                    if (profileImageFileUpload.HasFile)
                    {
                        fileName = profileImageFileUpload.FileName;
                        string savePath = Server.MapPath("~\\Images") + "\\" + fileName;
                        profileImageFileUpload.SaveAs(savePath);
                    }
                    studentBLL.InsertStudent(
                        adminNumberTextBox.Text, nameTextBox.Text, genderRadioButtonList.SelectedValue,
                        dob, addressTextBox.Text, citizenship, mobileTextBox.Text, email, fileName, out outMessage);
                    statusLabel.Text = outMessage;
                }
            }
            catch (FormatException fe)
            {
                statusLabel.Text = "Invalid Date of Birth Format";
            }
           

        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            adminNumberTextBox.Text = "";
            nameTextBox.Text = "";
            genderRadioButtonList.Text = "";
            dobTextBox.Text = "";
            addressTextBox.Text = "";
            citizenshipDropDownList.SelectedIndex = 6;
            mobileTextBox.Text = "";
        }
    }
}