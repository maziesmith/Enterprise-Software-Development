using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class Patient
    {
        private String connectionString = Properties.Settings.Default.DBConnString;

        private String patientID;
        private String patientName;
        private String gender;
        private String citizenship;
        private String address;
        private String postalCode;
        private String country;
        private String contactNumber;
        private String email;
        public Patient(String patientID = "",
                        String patientName = "",
                        String gender = "",
                        String citizenship = "",
                        String address = "",
                        String postalCode = "",
                        String country = "",
                        String contactNumber = "",
                        String email = "")
        {
            this.patientID = patientID;
            this.patientName = patientName;
            this.gender = gender;
            this.citizenship = citizenship;
            this.address = address;
            this.postalCode = postalCode;
            this.country = country;
            this.contactNumber = contactNumber;
            this.email = email;
        }
        public String PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }
        public String PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }
        public String Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public String Citizenship
        {
            get { return citizenship; }
            set { citizenship = value; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        public String PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }
        public String Country
        {
            get { return country; }
            set { country = value; }
        }
        public String ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public int InsertPatient()
        {
            String query =
                String.Format("INSERT INTO Patient (PatientID, PatientName, Gender, Citizenship, Address, PostalCode, Country, ContactNo, Email) " +
                                "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                                this.patientID,
                                this.patientName,
                                this.gender,
                                this.citizenship,
                                this.address,
                                this.postalCode,
                                this.country,
                                this.contactNumber,
                                this.email);

            int numberOfRows = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    numberOfRows = command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return numberOfRows;
        }
        public int UpdatePatient()
        {
            String query =
                " UPDATE Patient SET PatientName = @patientName, " +
                " Gender = @gender, Citizenship = @citizenship, Address = @address, " +
                " PostalCode = @postalCode, Country = @country, " +
                " ContactNo = @contactNo, email = @email " +
                " WHERE PatientID = @patientID";

            int numberOfRows = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patientID", this.patientID);
                    command.Parameters.AddWithValue("@patientName", this.patientName);

                    connection.Open();
                    numberOfRows = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return numberOfRows;
        }
        public Patient GetPatient(String patientID)
        {
            Patient patient = null;
            String query = "SELECT * FROM Patient WHERE PatientID = @patientID ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@patientID", patientID);

                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.Read())
                    {
                        String patientName = dataReader["PatientName"].ToString();
                        String gender = dataReader["Gender"].ToString();
                        String citienship = dataReader["Citizenship"].ToString();
                        String address = dataReader["Address"].ToString();
                        String postalCode = dataReader["PostalCode"].ToString();
                        String country = dataReader["Country"].ToString();
                        String contactNo = dataReader["ContactNo"].ToString();

                        patient = new Patient(patientID, patientName, gender, citienship
                            , address, postalCode, country, contactNo);
                    }
                    connection.Close();
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            return patient;
        }
        public List<Patient> GetAllPatient()
        {
            List<Patient> patients = new List<Patient>();
            String query = "SELECT * FROM Patient Order By PatientID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            String patientID = dataReader["PatientID"].ToString();
                            String patientName = dataReader["PatientName"].ToString();
                            String gender = dataReader["Gender"].ToString();
                            String citizenship = dataReader["Citizenship"].ToString();
                            String address = dataReader["Address"].ToString();
                            String postalCode = dataReader["PostalCode"].ToString();
                            String country = dataReader["Country"].ToString();
                            String contactNo = dataReader["ContactNo"].ToString();
                            String email = dataReader["Email"].ToString();

                            patients.Add(new Patient(patientID, patientName, gender, citizenship,
                                                     address, postalCode, country, contactNo, email));
                        }

                        connection.Close();
                        dataReader.Close();
                        dataReader.Dispose();
                    }
                }
            }

            return patients;
        }
    }
}

