using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class PatientBLL
    {
        public List<Patient> GetAllPatient()
        {
            Patient patientDAL = new Patient();
            List<Patient> patients = patientDAL.GetAllPatient();

            return patients;
        }

        public String CreatePatient(String patientID,
                                    String patientName,
                                    String gender,
                                    String citizenship,
                                    String address,
                                    String postalCode,
                                    String country,
                                    String contactNo,
                                    String email)
        {
            StringBuilder messageBuilder = new StringBuilder();

            if (String.IsNullOrEmpty(patientID) || patientID.Length > 20)
                messageBuilder.Append("Patient ID exceeds 20 chars!<br/>");

            if (String.IsNullOrEmpty(patientID) || patientID.Length == 0)
                messageBuilder.Append("ID cannot be blank!<br/>");

            if (patientName.Length > 30)
                messageBuilder.Append("Patient Names exceed 30 chars!<br/>");

            if (patientName.Length == 0)
                messageBuilder.Append("Patient Names cannot be blank!<br/>");

            if (address.Length > 50)
                messageBuilder.Append("Address exceeds 50 chars!<br/>");

            if (address.Length == 0)
                messageBuilder.Append("Address cannot be blank!<br/>");

            if (postalCode.Length > 10)
                messageBuilder.Append("Postal Code exceeds 10 chars!<br/>");

            if (postalCode.Length == 0)
                messageBuilder.Append("Postal Code cannot be blank!<br/>");

            if (contactNo.Length > 10)
                messageBuilder.Append("Contact number exceeds 10 chars!<br/>");

            if (contactNo.Length == 0)
                messageBuilder.Append("Contact number cannot be blank!<br/>");

            if (email.Length > 20)
                messageBuilder.Append("Email exceeds 20 chars!<br/>");

            if (messageBuilder.Length == 0)
            {
                // No error; proceed
                Patient patient = new Patient(patientID, patientName, gender, citizenship, address, postalCode, country, contactNo, email);

                int numberOfRows = 0;
                numberOfRows = patient.InsertPatient();

                if (numberOfRows > 0)
                {
                    messageBuilder.AppendFormat("{0}'s record is saved successfully.", patientName);
                }
                else
                {
                    messageBuilder.AppendFormat("Failed to save {0}. Please try again.", patientName);
                }
            }

            return messageBuilder.ToString();
        }
    }
}
