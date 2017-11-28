using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;
using System.Text.RegularExpressions;
using System.Text;

namespace SchoolAttendancePortal
{
    public partial class InsertStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static T ToEnum<T>(string value)
        {

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Cannot convert null or empty string to an enum");
            }

            // Get enum from the built-in Parse method
            return (T)Enum.Parse(typeof(T), value, true);

        }

        protected void btnok_Click(object sender, EventArgs e)
        {
            StudentBLL studentBLL = new StudentBLL();
            Student student = new Student();
            StringBuilder messageBuilder = new StringBuilder();

            if (String.IsNullOrEmpty(this.adminNumberTextBox.Text) || this.adminNumberTextBox.Text.Length < 7)
            {
                messageBuilder.Append("<BR>Admin Number must be 7 characters!");
            }
            if (String.IsNullOrEmpty(this.adminNumberTextBox.Text) || this.adminNumberTextBox.Text.Length > 7)
            {
                messageBuilder.Append("<BR>Admin Number must only be 7 characters!");
            }
            if (String.IsNullOrEmpty(this.adminNumberTextBox.Text) || this.adminNumberTextBox.Text.Length == 0)
            {
                messageBuilder.Append("<BR>Admin Number must not be blank!");
            }
            if (this.nameTextBox.Text.Length == 0)
            {
                messageBuilder.Append("<BR>Name must not be blank!");
            }
            if (this.addressTextBox.Text.Length == 0)
            {
                messageBuilder.Append("<BR>Address must not be blank!");
            }
            if (this.mobileTextBox.Text.Length == 0)
            {
                messageBuilder.Append("<BR>Mobile must not be blank!");
            }
            /* string datevalidation = "(((0|1)[0-9]|2[0-9]|3[0-1])\\/(0[1-9]|1[0-2])\\/((19|20)\\d\\d))$";
            Match match = Regex.Match(dobTextBox.Text.ToString(), datevalidation);
            if (match.Success == false)
            {
                messageBuilder.Append("\n" + "Date of Birth is invalid!");
            } */
            DateTime today = DateTime.Today;
            DateTime dob = Convert.ToDateTime(dobTextBox.Text);

            int age = today.Year - dob.Year;
            if (age < 16)
            {
                messageBuilder.Append("<BR>You must be at least 16 years old to register!");
            }
            string image = "";

            if (profileImageFileUpload.HasFile)
            {
                image = "\\Images\\" + profileImageFileUpload.FileName;
            }

            string Email = this.adminNumberTextBox.Text + "@mymail.nyp.edu.sg";

            Student.Nationality nationality = Student.Nationality.SG;

            switch (this.citizenshipDropDownList.SelectedValue)
            {
                case "BD":
                    nationality = Student.Nationality.BD;
                    break;
                case "CA":
                    nationality = Student.Nationality.CA;
                    break;
                case "CN":
                    nationality = Student.Nationality.CN;
                    break;
                case "HK":
                    nationality = Student.Nationality.HK;
                    break;
                case "ID":
                    nationality = Student.Nationality.ID;
                    break;
                case "JP":
                    nationality = Student.Nationality.JP;
                    break;
                case "MY":
                    nationality = Student.Nationality.MY;
                    break;
                case "SG":
                    nationality = Student.Nationality.SG;
                    break;
            }
            string status = string.Empty;
            int result = studentBLL.InsertStudent(adminNumberTextBox.Text, nameTextBox.Text, genderRadioButtonList.SelectedValue, Convert.ToDateTime(dobTextBox.Text), addressTextBox.Text, nationality, mobileTextBox.Text, Email, profileImageFileUpload.FileName, out status);

            if (result == 1)
            {
                status = String.Format("{0} has been saved successfully.", this.nameTextBox.Text);

                if (profileImageFileUpload.HasFile)
                {
                    string saveimg = Server.MapPath(" ") + "\\" + image;
                    this.statusLabel.Text = "\n" + saveimg.ToString();
                    profileImageFileUpload.SaveAs(saveimg);
                }
            }
            else
            {
                if (String.IsNullOrEmpty(status))
                {
                    status = String.Format("Error encountered when saving {0}.", this.nameTextBox.Text);
                }
                else
                {
                    status = String.Format("Error encountered when saving {0}. Details: {1}", this.nameTextBox.Text, status);
                }
            }
            statusLabel.Text = "";
            statusLabel.Text += "<BR>" + messageBuilder.ToString();
            statusLabel.Text += "<BR>" + status;
        }
    }
}
